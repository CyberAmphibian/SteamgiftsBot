using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Policy;

namespace SteamgiftsBot
{
	public partial class GameListViewItem : UserControl
	{
		public GameListViewItem()
		{
			InitializeComponent();
		}
		//------------------------------------------------------------------------

		public void SetGameLink(string game_name, string link)
		{
			GameNameLabel.Text = game_name;
			GameNameLabel.Links.Add(0, link.Length, "www.steamgifts.com" + link);
		}
		//------------------------------------------------------------------------

		public void SetGameCost(string cost)
		{
			CostLabel.Text = "Cost: " + cost;
		}
		//------------------------------------------------------------------------

		public void SetGamePicture(string picture_link)
		{
			GamePictureBox.LoadAsync(picture_link);
		}
		//------------------------------------------------------------------------

		private void OpenLink(string link)
		{
			if (null != link && link.StartsWith("www"))
				System.Diagnostics.Process.Start(link);
			else
				MessageBox.Show("Item clicked: " + link);
		}
		//------------------------------------------------------------------------

		private void GameNameLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			e.Link.Visited = true;

			string link = e.Link.LinkData as string;

			OpenLink(link);
		}
		//------------------------------------------------------------------------

		private void GamePictureBox_Click(object sender, EventArgs e)
		{
			this.GameNameLabel.Links[0].Visited = true;
			string link = this.GameNameLabel.Links[0].LinkData as string;

			OpenLink(link);
		}
		//------------------------------------------------------------------------
	}
	//------------------------------------------------------------------------
	//------------------------------------------------------------------------
	//------------------------------------------------------------------------
}
