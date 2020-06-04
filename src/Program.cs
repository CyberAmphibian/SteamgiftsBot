using System;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Collections.Generic;
using System.Linq;

namespace SteamgiftsBot
{
	[Serializable]
	public enum OrderType
	{
		Wishlist = 0,
		Recommended = 1,
		All = 2
	};
	//------------------------------------------------------------------------

	[Serializable]
	public class Order
	{
		public OrderType type;
		public int order;

		public Order(OrderType type, int order)
		{
			this.type = type;
			this.order = order;
		}
	}
	//------------------------------------------------------------------------

	[Serializable]
	public struct Settings
	{
		public string PHPSESSID;
		public List<Order> Orders;
		public decimal From, To;
		
		public Settings(string PHPSESSID, Order[] orders)
		{
			this.PHPSESSID = PHPSESSID;
			this.Orders = orders.ToList<Order>();
			this.From = 0;
			this.To = 50;
		}
		//------------------------------------------------------------------------

		public static void SaveSettings()
		{
			BinaryFormatter formatter = new BinaryFormatter();

			Stream s = File.Open(Program.SettingsFile, FileMode.OpenOrCreate);
			formatter.Serialize(s, Program.settings);
			s.Close();
		}
		//------------------------------------------------------------------------

		public static bool LoadSettings()
		{
			BinaryFormatter formatter = new BinaryFormatter();

			Stream s = File.Open(Program.SettingsFile, FileMode.Open);

			try
			{
				Program.settings = (Settings)formatter.Deserialize(s);
				s.Close();

				return true;
			}
			catch
			{
				if (s != null)
				{
					s.Close();
				}

				return false;
			}
		}
		//------------------------------------------------------------------------

	}
	//------------------------------------------------------------------------

	static class Program
	{
		public static Uri BaseAddress = new Uri("https://www.steamgifts.com");
		public static string Token = "";
		public static readonly string SettingsFile = AppDomain.CurrentDomain.BaseDirectory
											.Insert(AppDomain.CurrentDomain.BaseDirectory.Length, "settings.dat");

		public static Settings settings = new Settings("",
			new Order[] {
				new Order(OrderType.Wishlist, 0),
				new Order(OrderType.Recommended, 1),
				new Order(OrderType.All, 2)
			});

		//------------------------------------------------------------------------

		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);

			StartForm startForm = new StartForm();

			if (File.Exists(SettingsFile) == false)
			{
				Application.Run(startForm);
			}
			else
			{
				if (Settings.LoadSettings() == false)
				{
					Application.Run(startForm);
				}
				else
				{
					Application.Run(new MainForm());
				}
			}
			
			if (startForm.Logged == true)
			{
				Application.Run(new MainForm());
			}
		}
	}
}
