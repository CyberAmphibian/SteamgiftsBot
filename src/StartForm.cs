using System;
using System.Windows.Forms;
using System.IO;
using System.Net;
using System.Net.Http;
using HtmlAgilityPack;
//------------------------------------------------------------------------

namespace SteamgiftsBot
{
	public partial class StartForm : Form
	{
		private bool logged;

		public bool Logged
		{
			get
			{
				return logged;
			}
			private set
			{
				logged = value;
			}
		}
		//------------------------------------------------------------------------

		public StartForm()
		{
			InitializeComponent();
		}
		//------------------------------------------------------------------------

		private void ApplyBtn_Click(object sender, EventArgs e)
		{
			string id = PHPSESSID_TextBox.Text;

			CookieContainer cookies = new CookieContainer();
			cookies.Add(Program.BaseAddress, new Cookie("PHPSESSID", id));

			using (var handler = new HttpClientHandler() { CookieContainer = cookies })
			using (var client = new HttpClient(handler) { BaseAddress = Program.BaseAddress })
			{
				HttpResponseMessage result;

				try
				{
					result = client.GetAsync("").Result;
					result.EnsureSuccessStatusCode();
				}
				catch
				{
					//MainForm.ShowLoadErrorMessage("Failed check PHPSESSID");
					return;
				}

				string responseString = result.Content.ReadAsStringAsync().Result;

				HtmlAgilityPack.HtmlDocument document = new HtmlAgilityPack.HtmlDocument();
				document.LoadHtml(responseString);

				HtmlNode login_node = document.DocumentNode.SelectSingleNode("//*[@class=\"nav__sits\"]");

				if(login_node != null)
				{
					MessageBox.Show("Incorrect PHPSESSID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}
			}

			Program.settings.PHPSESSID = id;

			Settings.SaveSettings();

			Logged = true;
			Close();
		}
		//------------------------------------------------------------------------

		private void button3_Click(object sender, EventArgs e)
		{
			System.Diagnostics.Process.Start(@"Tutorial\How to get PHPSESSID\How_to_get_PHPSESSID.html");
		}
		//------------------------------------------------------------------------

	}
	//------------------------------------------------------------------------
	//------------------------------------------------------------------------
	//------------------------------------------------------------------------
}
