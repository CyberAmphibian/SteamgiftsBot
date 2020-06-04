using System;
using System.Windows.Forms;

namespace SteamgiftsBot
{
	public partial class RangeEdit : UserControl
	{
		public RangeEdit()
		{
			InitializeComponent();
		}
		//------------------------------------------------------------------------

		private void FromUpDown_ValueChanged(object sender, EventArgs e)
		{
			if (FromUpDown.Value >= ToUpDown.Value)
				FromUpDown.Value = ToUpDown.Value - 1;
		}
		//------------------------------------------------------------------------

		private void ToUpDown_ValueChanged(object sender, EventArgs e)
		{
			FromUpDown.Maximum = ToUpDown.Value;

			if (FromUpDown.Value >= ToUpDown.Value)
				FromUpDown.Value = ToUpDown.Value - 1;
		}
		//------------------------------------------------------------------------

	}
	//------------------------------------------------------------------------
	//------------------------------------------------------------------------
	//------------------------------------------------------------------------
}
