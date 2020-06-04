namespace SteamgiftsBot
{
	partial class RangeEdit
	{
		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary> 
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.FromLabel = new System.Windows.Forms.Label();
			this.FromUpDown = new System.Windows.Forms.NumericUpDown();
			this.ToUpDown = new System.Windows.Forms.NumericUpDown();
			this.ToLabel = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.FromUpDown)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ToUpDown)).BeginInit();
			this.SuspendLayout();
			// 
			// FromLabel
			// 
			this.FromLabel.AutoSize = true;
			this.FromLabel.Location = new System.Drawing.Point(4, 5);
			this.FromLabel.Name = "FromLabel";
			this.FromLabel.Size = new System.Drawing.Size(33, 13);
			this.FromLabel.TabIndex = 0;
			this.FromLabel.Text = "From:";
			// 
			// FromUpDown
			// 
			this.FromUpDown.Location = new System.Drawing.Point(43, 3);
			this.FromUpDown.Name = "FromUpDown";
			this.FromUpDown.Size = new System.Drawing.Size(50, 20);
			this.FromUpDown.TabIndex = 1;
			this.FromUpDown.ValueChanged += new System.EventHandler(this.FromUpDown_ValueChanged);
			// 
			// ToUpDown
			// 
			this.ToUpDown.Location = new System.Drawing.Point(128, 3);
			this.ToUpDown.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
			this.ToUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.ToUpDown.Name = "ToUpDown";
			this.ToUpDown.Size = new System.Drawing.Size(50, 20);
			this.ToUpDown.TabIndex = 3;
			this.ToUpDown.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
			this.ToUpDown.ValueChanged += new System.EventHandler(this.ToUpDown_ValueChanged);
			// 
			// ToLabel
			// 
			this.ToLabel.AutoSize = true;
			this.ToLabel.Location = new System.Drawing.Point(99, 5);
			this.ToLabel.Name = "ToLabel";
			this.ToLabel.Size = new System.Drawing.Size(23, 13);
			this.ToLabel.TabIndex = 2;
			this.ToLabel.Text = "To:";
			// 
			// RangeEdit
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.ToUpDown);
			this.Controls.Add(this.ToLabel);
			this.Controls.Add(this.FromUpDown);
			this.Controls.Add(this.FromLabel);
			this.Name = "RangeEdit";
			this.Size = new System.Drawing.Size(190, 25);
			((System.ComponentModel.ISupportInitialize)(this.FromUpDown)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ToUpDown)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label FromLabel;
		private System.Windows.Forms.Label ToLabel;
		public System.Windows.Forms.NumericUpDown FromUpDown;
		public System.Windows.Forms.NumericUpDown ToUpDown;
	}
}
