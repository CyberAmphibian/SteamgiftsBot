namespace SteamgiftsBot
{
	partial class GameListViewItem
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
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.GamePictureBox = new System.Windows.Forms.PictureBox();
			this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
			this.GameNameLabel = new System.Windows.Forms.LinkLabel();
			this.CostLabel = new System.Windows.Forms.Label();
			this.tableLayoutPanel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.GamePictureBox)).BeginInit();
			this.tableLayoutPanel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 2;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.Controls.Add(this.GamePictureBox, 1, 0);
			this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 1;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 98F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(498, 98);
			this.tableLayoutPanel1.TabIndex = 4;
			// 
			// GamePictureBox
			// 
			this.GamePictureBox.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.GamePictureBox.InitialImage = global::SteamgiftsBot.Properties.Resources.GameNotFound;
			this.GamePictureBox.Location = new System.Drawing.Point(252, 3);
			this.GamePictureBox.Name = "GamePictureBox";
			this.GamePictureBox.Size = new System.Drawing.Size(243, 92);
			this.GamePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.GamePictureBox.TabIndex = 4;
			this.GamePictureBox.TabStop = false;
			this.GamePictureBox.Click += new System.EventHandler(this.GamePictureBox_Click);
			// 
			// tableLayoutPanel2
			// 
			this.tableLayoutPanel2.ColumnCount = 1;
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel2.Controls.Add(this.GameNameLabel, 0, 0);
			this.tableLayoutPanel2.Controls.Add(this.CostLabel, 0, 1);
			this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
			this.tableLayoutPanel2.Name = "tableLayoutPanel2";
			this.tableLayoutPanel2.RowCount = 2;
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel2.Size = new System.Drawing.Size(243, 92);
			this.tableLayoutPanel2.TabIndex = 5;
			// 
			// GameNameLabel
			// 
			this.GameNameLabel.ActiveLinkColor = System.Drawing.Color.Blue;
			this.GameNameLabel.AutoSize = true;
			this.GameNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.GameNameLabel.LinkColor = System.Drawing.Color.MidnightBlue;
			this.GameNameLabel.Location = new System.Drawing.Point(3, 0);
			this.GameNameLabel.Name = "GameNameLabel";
			this.GameNameLabel.Padding = new System.Windows.Forms.Padding(5, 5, 0, 0);
			this.GameNameLabel.Size = new System.Drawing.Size(113, 25);
			this.GameNameLabel.TabIndex = 4;
			this.GameNameLabel.TabStop = true;
			this.GameNameLabel.Text = "Game Name";
			this.GameNameLabel.VisitedLinkColor = System.Drawing.Color.Black;
			// 
			// CostLabel
			// 
			this.CostLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.CostLabel.AutoSize = true;
			this.CostLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.CostLabel.Location = new System.Drawing.Point(3, 67);
			this.CostLabel.Name = "CostLabel";
			this.CostLabel.Padding = new System.Windows.Forms.Padding(5, 0, 0, 5);
			this.CostLabel.Size = new System.Drawing.Size(55, 25);
			this.CostLabel.TabIndex = 5;
			this.CostLabel.Text = "Cost: ";
			// 
			// GameListViewItem
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.Controls.Add(this.tableLayoutPanel1);
			this.Name = "GameListViewItem";
			this.Size = new System.Drawing.Size(498, 98);
			this.tableLayoutPanel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.GamePictureBox)).EndInit();
			this.tableLayoutPanel2.ResumeLayout(false);
			this.tableLayoutPanel2.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.PictureBox GamePictureBox;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
		private System.Windows.Forms.LinkLabel GameNameLabel;
		private System.Windows.Forms.Label CostLabel;
	}
}
