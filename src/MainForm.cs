using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Net.Http;
using System.Net;
using HtmlAgilityPack;
using System.Text.RegularExpressions;
using System.Drawing;
using System.Threading.Tasks;
using System.Json;
using System.Threading;
using SteamgiftsBot;
using System.Linq;
//------------------------------------------------------------------------

namespace SteamgiftsBot
{
	public partial class MainForm : Form
	{
		struct Giveaway
		{
			public string ID;
			public Control Control;
			public string Link;

			public Giveaway(string id, Control control, string link)
			{
				ID = id;
				Control = control;
				Link = link;
			}
		};

		private static List<Giveaway> giveaways = new List<Giveaway>();

		private static string ProfileLink;

		private static bool IsBotRunning = false;

		private TableLayoutPanel GamesListView = new TableLayoutPanel();

		List<Order> orders = new List<Order>();
		//------------------------------------------------------------------------

		public MainForm()
		{
			InitializeComponent();

			GamesListView.AutoScroll = true;
			GamesListView.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			GamesListView.ColumnCount = 1;
			GamesListView.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			GamesListView.Location = new System.Drawing.Point(3, 33);
			GamesListView.Name = "GamesListView";
			GamesListView.RowCount = 1;
			GamesListView.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
			GamesListView.Size = new System.Drawing.Size(201, 100);
			GamesListView.TabIndex = 3;

			notifyIcon.Visible = false;

			SetToken();
		}
		//------------------------------------------------------------------------

		static async void SetToken()
		{
			CookieContainer cookies = new CookieContainer();
			cookies.Add(Program.BaseAddress, new Cookie("PHPSESSID", Program.settings.PHPSESSID));

			using (var handler = new HttpClientHandler() { CookieContainer = cookies })
			using (var client = new HttpClient(handler) { BaseAddress = Program.BaseAddress })
			{
				HttpResponseMessage result;

				try
				{
					result = await client.GetAsync("");
					result.EnsureSuccessStatusCode();
				}
				catch
				{
					MainForm.ShowLoadErrorMessage("Failed to get Token");
					return;
				}

				string responseString = await result.Content.ReadAsStringAsync();

				HtmlAgilityPack.HtmlDocument document = new HtmlAgilityPack.HtmlDocument();
				document.LoadHtml(responseString);

				HtmlNodeCollection htmlNodeCollection = document.DocumentNode.SelectNodes("//*[@name=\"xsrf_token\"]");

				if(htmlNodeCollection == null)
				{
					MainForm.ShowLoadErrorMessage("Failed to get Token");
					return;
				}
				else if (htmlNodeCollection.Count > 0)
				{
					Program.Token = htmlNodeCollection[0].GetAttributeValue("value", "");
				}
			}
		}
		//------------------------------------------------------------------------

		async private Task<bool> EntryInsert(Giveaway giveaway)
		{
			CookieContainer cookies = new CookieContainer();
			cookies.Add(Program.BaseAddress, new Cookie("PHPSESSID", Program.settings.PHPSESSID));

			using (var handler = new HttpClientHandler() { CookieContainer = cookies })
			using (var client = new HttpClient(handler) { BaseAddress = Program.BaseAddress })
			{
				HttpResponseMessage result;

				try
				{
					result = await client.GetAsync(giveaway.Link);
					result.EnsureSuccessStatusCode();
				}
				catch
				{
					MainForm.ShowLoadErrorMessage("Failed to get Token");
					return false;
				}

				string response_string = await result.Content.ReadAsStringAsync();
				Regex regex = new Regex("Not Enough Points");

				if(regex.Match(response_string).Success == true)
				{
					return false;
				}

				FormUrlEncodedContent content = new FormUrlEncodedContent(new Dictionary<string, string>()
				{
					{ "xsrf_token", Program.Token},
					{ "do", "entry_insert"},
					{ "code", giveaway.ID}
				});

				try
				{
					result = await client.PostAsync("ajax.php", content);
					result.EnsureSuccessStatusCode();
				}
				catch
				{
					MainForm.ShowLoadErrorMessage("Failed to entry giveaway");
					return false;
				}

				response_string = await result.Content.ReadAsStringAsync();

				if (response_string.Length != 0)
				{
					JsonValue value = await Task.Run(() => JsonObject.Parse(response_string));

					if (value["type"] == "success")
					{
						GamesListView.Controls.Remove(giveaways[0].Control);
						giveaways.RemoveAt(0);

						PointsLabel.Text = "Points: " + value["points"];
						return true;
					}
				}
			}
			return false;
		}
		//------------------------------------------------------------------------

		async private Task<HtmlNodeCollection> GetNodes(string request, int page = 1)
		{
			HtmlNodeCollection html_node_collection = null;

			CookieContainer cookies = new CookieContainer();
			cookies.Add(Program.BaseAddress, new Cookie("PHPSESSID", Program.settings.PHPSESSID));

			string responseString;

			string request_temp = request;

			if (page > 1)
			{
				if (request_temp == "")
				{
					request_temp += "giveaways/search?page=" + page;
				}
				else
				{
					request_temp += "&page=" + page;
				}
			}

			using (var handler = new HttpClientHandler() { CookieContainer = cookies })
			using (var client = new HttpClient(handler) { BaseAddress = Program.BaseAddress })
			{
				HttpResponseMessage result;

				try
				{
					result = await client.GetAsync(request_temp);
					result.EnsureSuccessStatusCode();
				}
				catch
				{
					MainForm.ShowLoadErrorMessage("Filed to get giveaways");
					return html_node_collection;
				}

				responseString = await result.Content.ReadAsStringAsync();
			}

			HtmlAgilityPack.HtmlDocument document = new HtmlAgilityPack.HtmlDocument();
			document.LoadHtml(responseString);

			html_node_collection = document.DocumentNode.SelectNodes("//*[@class=\"giveaway__row-inner-wrap\"]");

			List<HtmlNode> remove_list = new List<HtmlNode>();

			foreach (var single_node in html_node_collection)
			{
				if (single_node.ParentNode.ParentNode.XPath == "/html[1]/body[1]/div[4]/div[1]/div[1]/div[2]/div[1]/div[1]")
				{
					remove_list.Add(single_node);
					continue;
				}

				HtmlNode cost_node = single_node.SelectSingleNode(".//*[@class=\"giveaway__heading__thin\"]");
				if (CheckNode(cost_node) == false)
				{
					remove_list.Add(single_node);
					continue;
				}

				Match m = Regex.Match(cost_node.InnerText, @"\d+");
				decimal game_cost = 0;

				if (m.Success)
				{
					game_cost = Convert.ToDecimal(m.Value);

					if (game_cost < Program.settings.From || game_cost > Program.settings.To)
					{
						remove_list.Add(single_node);
						continue;
					}
				}
			}

			foreach (var remove in remove_list)
			{
				html_node_collection.Remove(remove);
			}

			if (html_node_collection.Count == 0)
			{
				document.LoadHtml(responseString);
				HtmlNode result_node = document.DocumentNode.SelectSingleNode("//*[@class=\"pagination__results\"]");
				if (CheckNode(result_node) == false || result_node.InnerText == "No results were found.")
				{
					return html_node_collection;
				}

				document.LoadHtml(responseString);
				HtmlNode pages_node = document.DocumentNode.SelectSingleNode("//*[@class=\"pagination__navigation\"]");
				if (CheckNode(pages_node) == false)
				{
					return html_node_collection;
				}
				else
				{
					return await GetNodes(request, page + 1);
				}
			}

			return html_node_collection;
		}
		//------------------------------------------------------------------------

		async private void GetAllGifts()
		{
			RightLayoutPanel.Controls.Remove(GamesListView);
			RightLayoutPanel.Controls.Add(RefreshPictureBox, 0, 1);

			GamesListView.Controls.Clear();

			foreach (Order order in Program.settings.Orders)
			{
				string response;

				switch (order.type)
				{
					case OrderType.Wishlist: response = "giveaways/search?type=wishlist"; break;
					case OrderType.Recommended: response = "giveaways/search?type=recommended"; break;
					case OrderType.All: response = ""; break;
					default: response = ""; break;
				}

				HtmlNodeCollection html_node_collection = await GetNodes(response);

				if(html_node_collection == null)
				{
					ApplyFilterBtn.Enabled = true;
					return;
				}

				foreach (var single_node in html_node_collection)
				{
					HtmlNode heading_node = single_node.SelectSingleNode(".//*[@class=\"giveaway__heading__name\"]");
					if (CheckNode(heading_node) == false)
					{
						continue;
					}

					HtmlNode image_node = single_node.SelectSingleNode(".//*[@class=\"giveaway_image_thumbnail\"]");
					if (CheckNode(image_node) == false)
					{
						continue;
					}

					HtmlNode cost_node = single_node.SelectSingleNode(".//*[@class=\"giveaway__heading__thin\"]");
					if (CheckNode(cost_node) == false)
					{
						continue;
					}

					Match m = Regex.Match(cost_node.InnerText, @"\d+");
					decimal game_cost = 0;

					if (m.Success)
					{
						game_cost = Convert.ToDecimal(m.Value);
					}

					string href = heading_node.GetAttributeValue("href", "");
					string game_name = heading_node.InnerText;

					GameListViewItem new_item = new GameListViewItem();

					new_item.SetGameLink(game_name, href);

					string image_url = image_node.GetAttributeValue("style", "");
					image_url = image_url.Substring(21);
					image_url = image_url.Remove(image_url.Length - 2);

					new_item.SetGamePicture(image_url);

					new_item.SetGameCost(game_cost.ToString());

					new_item.Dock = DockStyle.Fill;

					GamesListView.Controls.Add(new_item);

					string game_id = href.Substring(10, 5);

					giveaways.Add(new Giveaway(game_id, new_item, href));
				}
				if (giveaways.Count > 25)
					break;
			}
			//Add an empty control to display correctly.
			Label empty = new Label();
			GamesListView.Controls.Add(empty);

			RightLayoutPanel.Controls.Remove(RefreshPictureBox);
			RightLayoutPanel.Controls.Add(GamesListView, 0, 1);
			GamesListView.Dock = DockStyle.Fill;

			if (giveaways.Count > 0)
			{
				StartBotBtn.Enabled = true;
			}
			ApplyFilterBtn.Enabled = true;
		}	
		//------------------------------------------------------------------------

		async private void GetProfileInfo()
		{
			CookieContainer cookies = new CookieContainer();
			cookies.Add(Program.BaseAddress, new Cookie("PHPSESSID", Program.settings.PHPSESSID));

			using (var handler = new HttpClientHandler() { CookieContainer = cookies })
			using (var client = new HttpClient(handler) { BaseAddress = Program.BaseAddress })
			{
				HttpResponseMessage result;
				try
				{
					result = await client.GetAsync("");
					result.EnsureSuccessStatusCode();
				}
				catch
				{

					MainForm.ShowLoadErrorMessage("Failed to get profile info");
					return;
				}

				var responseString = await result.Content.ReadAsStringAsync();

				HtmlAgilityPack.HtmlDocument document = new HtmlAgilityPack.HtmlDocument();
				document.LoadHtml(responseString);

				//Get profile avatar
				HtmlNode avatar_node = document.DocumentNode.SelectSingleNode("//*[@class=\"nav__avatar-inner-wrap\"]");
				if (CheckNode(avatar_node))
				{
					string avatar_link = avatar_node.GetAttributeValue("style", "");

					avatar_link = avatar_link.Substring(21);
					avatar_link = avatar_link.Remove(avatar_link.Length - 2);

					Regex rx = new Regex(@"_medium");
					avatar_link = rx.Replace(avatar_link, "_full");

					AvatarPictureBox.LoadAsync(avatar_link);
				}


				//Get profile link and name
				HtmlNode profile_link_node = document.DocumentNode.SelectSingleNode("//*[@class=\"nav__avatar-outer-wrap\"]");
				if (CheckNode(profile_link_node))
				{
					ProfileLink = profile_link_node.GetAttributeValue("href", "");
					ProfileNameTextEdit.Text = ProfileLink.Remove(0, ProfileLink.LastIndexOf("/") + 1);
				}

				//Get points 
				HtmlNode points_node = document.DocumentNode.SelectSingleNode("//*[@class=\"nav__points\"]");
				if (CheckNode(points_node))
				{
					PointsLabel.Text = "Points: " + points_node.InnerText;
				}

				//Get level
				HtmlNode level_node = document.DocumentNode.SelectSingleNode("//*[@title=\"1.34\"]");
				if (CheckNode(points_node))
				{
					LevelLabel.Text = level_node.InnerText;
				}
			}
		}
		//------------------------------------------------------------------------

		private void LoadSettings()
		{
			foreach (Order order in Program.settings.Orders)
			{
				orders.Add(order);

				UpdateLabelOrder(order.type);
			}

			CostRangeEdit.FromUpDown.Value = Program.settings.From;
			CostRangeEdit.ToUpDown.Value = Program.settings.To;
		}
		//------------------------------------------------------------------------

		private void MainForm_Load(object sender, EventArgs e)
		{
			LoadSettings();

			GetProfileInfo();
			GetAllGifts();
		}
		//------------------------------------------------------------------------

		private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			Settings.SaveSettings();
		}
		//------------------------------------------------------------------------

		private async Task BotProcess()
		{
			while (IsBotRunning)
			{
				if (giveaways.Count != 0)
				{
					if (await EntryInsert(giveaways[0]) == false)
					{
						//20 minutes pause to increase points and try again.
						await Task.Delay(1000 * 60 * 16);
					}
				}
				else
				{
					GetAllGifts();
				}
				await Task.Delay(2000);
			}
		}
		//------------------------------------------------------------------------

		private async void StartBotProcess()
		{
			IsBotRunning = true;
			StartBotBtn.Text = "Stop Bot";

			await BotProcess();

			StartBotBtn.Enabled = true;
			StartBotBtn.Text = "Start Bot";
		}
		//------------------------------------------------------------------------

		private void StopBotProcess()
		{
			if (IsBotRunning)
			{
				StartBotBtn.Enabled = false;
				IsBotRunning = false;
			}
		}
		//------------------------------------------------------------------------

		private void StartBotBtn_Click(object sender, EventArgs e)
		{
			if (IsBotRunning == false)
			{
				StartBotProcess();
			}
			else
			{
				StopBotProcess();
			}
		}
		//------------------------------------------------------------------------

		private void LeftTablePanel_CellPaint(object sender, TableLayoutCellPaintEventArgs e)
		{
			var rectangle = e.CellBounds;
			rectangle.Inflate(-1, -1);

			ControlPaint.DrawBorder(e.Graphics, rectangle, Color.Black, ButtonBorderStyle.Solid);
		}
		//------------------------------------------------------------------------

		private void DrawTableBorder(TableLayoutCellPaintEventArgs e)
		{
			var rectangle = e.CellBounds;
			rectangle.Inflate(-1, -1);

			ControlPaint.DrawBorder(e.Graphics, rectangle, Color.Black, ButtonBorderStyle.Solid);
		}
		//------------------------------------------------------------------------

		private void RightLayoutPanel_CellPaint(object sender, TableLayoutCellPaintEventArgs e)
		{
			DrawTableBorder(e);
		}
		//------------------------------------------------------------------------

		private void tableLayoutPanel1_CellPaint(object sender, TableLayoutCellPaintEventArgs e)
		{
			DrawTableBorder(e);
		}
		//------------------------------------------------------------------------

		private void ProfileTablePanel_CellPaint(object sender, TableLayoutCellPaintEventArgs e)
		{
			DrawTableBorder(e);
		}
		//------------------------------------------------------------------------

		private void OrderTablePanel_CellPaint(object sender, TableLayoutCellPaintEventArgs e)
		{
			DrawTableBorder(e);
		}
		//------------------------------------------------------------------------

		private void FilterTablePanel_CellPaint(object sender, TableLayoutCellPaintEventArgs e)
		{
			DrawTableBorder(e);
		}
		//------------------------------------------------------------------------

		private void tableLayoutPanel1_CellPaint_1(object sender, TableLayoutCellPaintEventArgs e)
		{
			DrawTableBorder(e);
		}
		//------------------------------------------------------------------------

		private void UpdateLabelOrder(OrderType type)
		{
			int order = orders.Find(x => x.type == type).order;

			switch (type)
			{
				case OrderType.Wishlist:
					WishlistOrderLabel.Text = (order >= 0) ? (order + 1).ToString() : "";
					break;
				case OrderType.Recommended:
					RecommendedOrderLabel.Text = (order >= 0) ? (order + 1).ToString() : "";
					break;
				case OrderType.All:
					AllOrderLabel.Text = (order >= 0) ? (order + 1).ToString() : "";
					break;
			}
		}
		//------------------------------------------------------------------------

		private void SwitchOrder(OrderType type)
		{
			if (orders.Exists(order => order.type == type))
			{
				int index = orders.IndexOf(orders.Find(order => order.type == type));

				for (int i = index + 1; i < orders.Count; ++i)
				{
					orders[i].order -= 1;
				}

				orders[index].order = -1;

				UpdateLabelOrder(type);

				orders.RemoveAt(index);
			}
			else
			{
				orders.Add(new Order(type, orders.Count));
			}

			foreach (var order in orders)
			{
				UpdateLabelOrder(order.type);
			}
		}
		//------------------------------------------------------------------------

		private void WishlistButton_Click(object sender, EventArgs e)
		{
			SwitchOrder(OrderType.Wishlist);
		}
		//------------------------------------------------------------------------

		private void RecommendedButton_Click(object sender, EventArgs e)
		{
			SwitchOrder(OrderType.Recommended);
		}
		//------------------------------------------------------------------------

		private void AllButton_Click(object sender, EventArgs e)
		{
			SwitchOrder(OrderType.All);
		}
		//------------------------------------------------------------------------

		private static bool CheckNode(HtmlNode node)
		{
			if (node == null)
			{
				Console.WriteLine("HtmlNode not found.");
				return false;
			}
			else
			{
				return true;
			}
		}
		//------------------------------------------------------------------------

		private static void ShowLoadErrorMessage(string str)
		{
			MessageBox.Show(str, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
		}
		//------------------------------------------------------------------------

		private void notifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
		{
			notifyIcon.Visible = false;
			this.ShowInTaskbar = true;
			WindowState = FormWindowState.Normal;
		}
		//------------------------------------------------------------------------

		private void MainForm_Resize(object sender, EventArgs e)
		{
			if (WindowState == FormWindowState.Minimized)
			{
				this.ShowInTaskbar = false;
				notifyIcon.Visible = true;
			}
		}
		//------------------------------------------------------------------------

		private void ApplyFilterBtn_Click(object sender, EventArgs e)
		{
			ApplyFilterBtn.Enabled = false;

			Program.settings.Orders.Clear();

			foreach (Order order in orders)
			{
				Program.settings.Orders.Add(order);
			}

			Program.settings.From = CostRangeEdit.FromUpDown.Value;
			Program.settings.To = CostRangeEdit.ToUpDown.Value;

			StartBotBtn.Enabled = false;

			giveaways.Clear();
			GamesListView.RowCount = 0;
			GamesListView.Dock = DockStyle.None;
			GamesListView.Size = new Size(0, 0);

			GetAllGifts();
		}
		//------------------------------------------------------------------------

	}
	//------------------------------------------------------------------------
	//------------------------------------------------------------------------
	//------------------------------------------------------------------------
}
