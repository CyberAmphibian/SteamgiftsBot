namespace SteamgiftsBot
{
	partial class StartForm
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

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartForm));
			this.PHPSESSID_GB = new System.Windows.Forms.GroupBox();
			this.button3 = new System.Windows.Forms.Button();
			this.ApplyBtn = new System.Windows.Forms.Button();
			this.PHPSESSID_TextBox = new System.Windows.Forms.TextBox();
			this.PHPSESSID_GB.SuspendLayout();
			this.SuspendLayout();
			// 
			// PHPSESSID_GB
			// 
			this.PHPSESSID_GB.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.PHPSESSID_GB.Controls.Add(this.button3);
			this.PHPSESSID_GB.Controls.Add(this.ApplyBtn);
			this.PHPSESSID_GB.Controls.Add(this.PHPSESSID_TextBox);
			this.PHPSESSID_GB.Location = new System.Drawing.Point(32, 50);
			this.PHPSESSID_GB.Name = "PHPSESSID_GB";
			this.PHPSESSID_GB.Size = new System.Drawing.Size(320, 60);
			this.PHPSESSID_GB.TabIndex = 1;
			this.PHPSESSID_GB.TabStop = false;
			this.PHPSESSID_GB.Text = "PHPSESSID";
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(284, 17);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(25, 25);
			this.button3.TabIndex = 2;
			this.button3.Text = "?";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// ApplyBtn
			// 
			this.ApplyBtn.Location = new System.Drawing.Point(217, 18);
			this.ApplyBtn.Name = "ApplyBtn";
			this.ApplyBtn.Size = new System.Drawing.Size(61, 23);
			this.ApplyBtn.TabIndex = 1;
			this.ApplyBtn.Text = "Apply";
			this.ApplyBtn.UseVisualStyleBackColor = true;
			this.ApplyBtn.Click += new System.EventHandler(this.ApplyBtn_Click);
			// 
			// PHPSESSID_TextBox
			// 
			this.PHPSESSID_TextBox.Location = new System.Drawing.Point(6, 20);
			this.PHPSESSID_TextBox.MaxLength = 32;
			this.PHPSESSID_TextBox.Name = "PHPSESSID_TextBox";
			this.PHPSESSID_TextBox.Size = new System.Drawing.Size(205, 20);
			this.PHPSESSID_TextBox.TabIndex = 0;
			// 
			// StartForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(384, 161);
			this.Controls.Add(this.PHPSESSID_GB);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "StartForm";
			this.Text = "Login";
			this.PHPSESSID_GB.ResumeLayout(false);
			this.PHPSESSID_GB.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox PHPSESSID_GB;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button ApplyBtn;
		private System.Windows.Forms.TextBox PHPSESSID_TextBox;
	}
}