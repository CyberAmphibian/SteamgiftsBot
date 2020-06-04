namespace SteamgiftsBot
{
	partial class MainForm
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.RightLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
			this.QueueLabel = new System.Windows.Forms.Label();
			this.StartBotBtn = new System.Windows.Forms.Button();
			this.RefreshPictureBox = new System.Windows.Forms.PictureBox();
			this.MainTablePanel = new System.Windows.Forms.TableLayoutPanel();
			this.LeftTablePanel = new System.Windows.Forms.TableLayoutPanel();
			this.ApplyFilterBtn = new System.Windows.Forms.Button();
			this.ProfileTablePanel = new System.Windows.Forms.TableLayoutPanel();
			this.AvatarPictureBox = new System.Windows.Forms.PictureBox();
			this.ProfileInfoTablePanel = new System.Windows.Forms.TableLayoutPanel();
			this.LevelLabel = new System.Windows.Forms.Label();
			this.PointsLabel = new System.Windows.Forms.Label();
			this.ProfileNameTextEdit = new System.Windows.Forms.TextBox();
			this.BotSettingsLabel = new System.Windows.Forms.Label();
			this.GiveawaysOrderLabel = new System.Windows.Forms.Label();
			this.OrderTablePanel = new System.Windows.Forms.TableLayoutPanel();
			this.AllOrderLabel = new System.Windows.Forms.Label();
			this.RecommendedOrderLabel = new System.Windows.Forms.Label();
			this.WishlistButton = new System.Windows.Forms.Button();
			this.RecommendedButton = new System.Windows.Forms.Button();
			this.AllButton = new System.Windows.Forms.Button();
			this.WishlistOrderLabel = new System.Windows.Forms.Label();
			this.FilterLabel = new System.Windows.Forms.Label();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.label1 = new System.Windows.Forms.Label();
			this.LevelOrderCB = new System.Windows.Forms.ComboBox();
			this.LabelCostOrder = new System.Windows.Forms.Label();
			this.CostOrderComboBox = new System.Windows.Forms.ComboBox();
			this.FilterTablePanel = new System.Windows.Forms.TableLayoutPanel();
			this.CostFilterLabel = new System.Windows.Forms.Label();
			this.OrderLabel = new System.Windows.Forms.Label();
			this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
			this.CostRangeEdit = new SteamgiftsBot.RangeEdit();
			this.RightLayoutPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.RefreshPictureBox)).BeginInit();
			this.MainTablePanel.SuspendLayout();
			this.LeftTablePanel.SuspendLayout();
			this.ProfileTablePanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.AvatarPictureBox)).BeginInit();
			this.ProfileInfoTablePanel.SuspendLayout();
			this.OrderTablePanel.SuspendLayout();
			this.tableLayoutPanel1.SuspendLayout();
			this.FilterTablePanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// RightLayoutPanel
			// 
			this.RightLayoutPanel.BackColor = System.Drawing.Color.Gray;
			this.RightLayoutPanel.ColumnCount = 1;
			this.RightLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.RightLayoutPanel.Controls.Add(this.QueueLabel, 0, 0);
			this.RightLayoutPanel.Controls.Add(this.StartBotBtn, 0, 2);
			this.RightLayoutPanel.Controls.Add(this.RefreshPictureBox, 0, 1);
			this.RightLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.RightLayoutPanel.Location = new System.Drawing.Point(253, 3);
			this.RightLayoutPanel.Name = "RightLayoutPanel";
			this.RightLayoutPanel.RowCount = 3;
			this.RightLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
			this.RightLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.RightLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
			this.RightLayoutPanel.Size = new System.Drawing.Size(528, 555);
			this.RightLayoutPanel.TabIndex = 2;
			this.RightLayoutPanel.CellPaint += new System.Windows.Forms.TableLayoutCellPaintEventHandler(this.RightLayoutPanel_CellPaint);
			// 
			// QueueLabel
			// 
			this.QueueLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.QueueLabel.AutoSize = true;
			this.QueueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.QueueLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.QueueLabel.Location = new System.Drawing.Point(229, 3);
			this.QueueLabel.Name = "QueueLabel";
			this.QueueLabel.Size = new System.Drawing.Size(69, 24);
			this.QueueLabel.TabIndex = 1;
			this.QueueLabel.Text = "Queue";
			// 
			// StartBotBtn
			// 
			this.StartBotBtn.BackColor = System.Drawing.Color.LightGreen;
			this.StartBotBtn.Dock = System.Windows.Forms.DockStyle.Fill;
			this.StartBotBtn.Enabled = false;
			this.StartBotBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.StartBotBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.StartBotBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.StartBotBtn.Location = new System.Drawing.Point(3, 518);
			this.StartBotBtn.Name = "StartBotBtn";
			this.StartBotBtn.Size = new System.Drawing.Size(522, 34);
			this.StartBotBtn.TabIndex = 2;
			this.StartBotBtn.Text = "Start bot";
			this.StartBotBtn.UseVisualStyleBackColor = false;
			this.StartBotBtn.Click += new System.EventHandler(this.StartBotBtn_Click);
			// 
			// RefreshPictureBox
			// 
			this.RefreshPictureBox.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.RefreshPictureBox.Image = global::SteamgiftsBot.Properties.Resources.Refresh;
			this.RefreshPictureBox.Location = new System.Drawing.Point(233, 240);
			this.RefreshPictureBox.Name = "RefreshPictureBox";
			this.RefreshPictureBox.Size = new System.Drawing.Size(62, 64);
			this.RefreshPictureBox.TabIndex = 3;
			this.RefreshPictureBox.TabStop = false;
			// 
			// MainTablePanel
			// 
			this.MainTablePanel.ColumnCount = 2;
			this.MainTablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 250F));
			this.MainTablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.MainTablePanel.Controls.Add(this.RightLayoutPanel, 1, 0);
			this.MainTablePanel.Controls.Add(this.LeftTablePanel, 0, 0);
			this.MainTablePanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.MainTablePanel.Location = new System.Drawing.Point(0, 0);
			this.MainTablePanel.Name = "MainTablePanel";
			this.MainTablePanel.RowCount = 1;
			this.MainTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.MainTablePanel.Size = new System.Drawing.Size(784, 561);
			this.MainTablePanel.TabIndex = 3;
			// 
			// LeftTablePanel
			// 
			this.LeftTablePanel.BackColor = System.Drawing.Color.Gray;
			this.LeftTablePanel.ColumnCount = 1;
			this.LeftTablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.LeftTablePanel.Controls.Add(this.ApplyFilterBtn, 0, 8);
			this.LeftTablePanel.Controls.Add(this.ProfileTablePanel, 0, 0);
			this.LeftTablePanel.Controls.Add(this.BotSettingsLabel, 0, 1);
			this.LeftTablePanel.Controls.Add(this.GiveawaysOrderLabel, 0, 2);
			this.LeftTablePanel.Controls.Add(this.OrderTablePanel, 0, 3);
			this.LeftTablePanel.Controls.Add(this.FilterLabel, 0, 4);
			this.LeftTablePanel.Controls.Add(this.tableLayoutPanel1, 0, 7);
			this.LeftTablePanel.Controls.Add(this.FilterTablePanel, 0, 5);
			this.LeftTablePanel.Controls.Add(this.OrderLabel, 0, 6);
			this.LeftTablePanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.LeftTablePanel.Location = new System.Drawing.Point(3, 3);
			this.LeftTablePanel.Name = "LeftTablePanel";
			this.LeftTablePanel.RowCount = 9;
			this.LeftTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
			this.LeftTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
			this.LeftTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.LeftTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 150F));
			this.LeftTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.LeftTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
			this.LeftTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.LeftTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.LeftTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
			this.LeftTablePanel.Size = new System.Drawing.Size(244, 555);
			this.LeftTablePanel.TabIndex = 3;
			this.LeftTablePanel.CellPaint += new System.Windows.Forms.TableLayoutCellPaintEventHandler(this.LeftTablePanel_CellPaint);
			// 
			// ApplyFilterBtn
			// 
			this.ApplyFilterBtn.BackColor = System.Drawing.Color.DimGray;
			this.ApplyFilterBtn.Dock = System.Windows.Forms.DockStyle.Fill;
			this.ApplyFilterBtn.Enabled = false;
			this.ApplyFilterBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.ApplyFilterBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.ApplyFilterBtn.Location = new System.Drawing.Point(3, 518);
			this.ApplyFilterBtn.Name = "ApplyFilterBtn";
			this.ApplyFilterBtn.Size = new System.Drawing.Size(238, 34);
			this.ApplyFilterBtn.TabIndex = 6;
			this.ApplyFilterBtn.Text = "Apply filter";
			this.ApplyFilterBtn.UseVisualStyleBackColor = false;
			this.ApplyFilterBtn.Click += new System.EventHandler(this.ApplyFilterBtn_Click);
			// 
			// ProfileTablePanel
			// 
			this.ProfileTablePanel.BackColor = System.Drawing.Color.DarkGray;
			this.ProfileTablePanel.ColumnCount = 2;
			this.ProfileTablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
			this.ProfileTablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.ProfileTablePanel.Controls.Add(this.AvatarPictureBox, 0, 0);
			this.ProfileTablePanel.Controls.Add(this.ProfileInfoTablePanel, 1, 0);
			this.ProfileTablePanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.ProfileTablePanel.Location = new System.Drawing.Point(3, 3);
			this.ProfileTablePanel.Name = "ProfileTablePanel";
			this.ProfileTablePanel.RowCount = 1;
			this.ProfileTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.ProfileTablePanel.Size = new System.Drawing.Size(238, 94);
			this.ProfileTablePanel.TabIndex = 0;
			this.ProfileTablePanel.CellPaint += new System.Windows.Forms.TableLayoutCellPaintEventHandler(this.ProfileTablePanel_CellPaint);
			// 
			// AvatarPictureBox
			// 
			this.AvatarPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.AvatarPictureBox.Image = global::SteamgiftsBot.Properties.Resources.loading;
			this.AvatarPictureBox.InitialImage = global::SteamgiftsBot.Properties.Resources.Avatar;
			this.AvatarPictureBox.Location = new System.Drawing.Point(3, 3);
			this.AvatarPictureBox.Name = "AvatarPictureBox";
			this.AvatarPictureBox.Padding = new System.Windows.Forms.Padding(5);
			this.AvatarPictureBox.Size = new System.Drawing.Size(94, 88);
			this.AvatarPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.AvatarPictureBox.TabIndex = 0;
			this.AvatarPictureBox.TabStop = false;
			// 
			// ProfileInfoTablePanel
			// 
			this.ProfileInfoTablePanel.ColumnCount = 1;
			this.ProfileInfoTablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.ProfileInfoTablePanel.Controls.Add(this.LevelLabel, 0, 2);
			this.ProfileInfoTablePanel.Controls.Add(this.PointsLabel, 0, 1);
			this.ProfileInfoTablePanel.Controls.Add(this.ProfileNameTextEdit, 0, 0);
			this.ProfileInfoTablePanel.Location = new System.Drawing.Point(103, 3);
			this.ProfileInfoTablePanel.Name = "ProfileInfoTablePanel";
			this.ProfileInfoTablePanel.RowCount = 3;
			this.ProfileInfoTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.ProfileInfoTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.ProfileInfoTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.ProfileInfoTablePanel.Size = new System.Drawing.Size(132, 88);
			this.ProfileInfoTablePanel.TabIndex = 1;
			// 
			// LevelLabel
			// 
			this.LevelLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.LevelLabel.AutoSize = true;
			this.LevelLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.LevelLabel.Location = new System.Drawing.Point(3, 65);
			this.LevelLabel.Name = "LevelLabel";
			this.LevelLabel.Size = new System.Drawing.Size(46, 15);
			this.LevelLabel.TabIndex = 2;
			this.LevelLabel.Text = "Level ?";
			// 
			// PointsLabel
			// 
			this.PointsLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.PointsLabel.AutoSize = true;
			this.PointsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.PointsLabel.Location = new System.Drawing.Point(3, 36);
			this.PointsLabel.Name = "PointsLabel";
			this.PointsLabel.Size = new System.Drawing.Size(47, 15);
			this.PointsLabel.TabIndex = 1;
			this.PointsLabel.Text = "Points: ";
			// 
			// ProfileNameTextEdit
			// 
			this.ProfileNameTextEdit.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.ProfileNameTextEdit.BackColor = System.Drawing.Color.DarkGray;
			this.ProfileNameTextEdit.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.ProfileNameTextEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.ProfileNameTextEdit.Location = new System.Drawing.Point(6, 7);
			this.ProfileNameTextEdit.Name = "ProfileNameTextEdit";
			this.ProfileNameTextEdit.ReadOnly = true;
			this.ProfileNameTextEdit.Size = new System.Drawing.Size(120, 15);
			this.ProfileNameTextEdit.TabIndex = 3;
			this.ProfileNameTextEdit.Text = "Name";
			// 
			// BotSettingsLabel
			// 
			this.BotSettingsLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.BotSettingsLabel.AutoSize = true;
			this.BotSettingsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.BotSettingsLabel.Location = new System.Drawing.Point(85, 106);
			this.BotSettingsLabel.Name = "BotSettingsLabel";
			this.BotSettingsLabel.Size = new System.Drawing.Size(74, 13);
			this.BotSettingsLabel.TabIndex = 1;
			this.BotSettingsLabel.Text = "Bot settings";
			// 
			// GiveawaysOrderLabel
			// 
			this.GiveawaysOrderLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.GiveawaysOrderLabel.AutoSize = true;
			this.GiveawaysOrderLabel.Location = new System.Drawing.Point(3, 128);
			this.GiveawaysOrderLabel.Name = "GiveawaysOrderLabel";
			this.GiveawaysOrderLabel.Size = new System.Drawing.Size(86, 13);
			this.GiveawaysOrderLabel.TabIndex = 2;
			this.GiveawaysOrderLabel.Text = "Giveaways order";
			// 
			// OrderTablePanel
			// 
			this.OrderTablePanel.BackColor = System.Drawing.Color.DarkGray;
			this.OrderTablePanel.ColumnCount = 2;
			this.OrderTablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 45F));
			this.OrderTablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.OrderTablePanel.Controls.Add(this.AllOrderLabel, 0, 2);
			this.OrderTablePanel.Controls.Add(this.RecommendedOrderLabel, 0, 1);
			this.OrderTablePanel.Controls.Add(this.WishlistButton, 1, 0);
			this.OrderTablePanel.Controls.Add(this.RecommendedButton, 1, 1);
			this.OrderTablePanel.Controls.Add(this.AllButton, 1, 2);
			this.OrderTablePanel.Controls.Add(this.WishlistOrderLabel, 0, 0);
			this.OrderTablePanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.OrderTablePanel.Location = new System.Drawing.Point(3, 148);
			this.OrderTablePanel.Name = "OrderTablePanel";
			this.OrderTablePanel.RowCount = 3;
			this.OrderTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.OrderTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.OrderTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.OrderTablePanel.Size = new System.Drawing.Size(238, 144);
			this.OrderTablePanel.TabIndex = 3;
			this.OrderTablePanel.CellPaint += new System.Windows.Forms.TableLayoutCellPaintEventHandler(this.OrderTablePanel_CellPaint);
			// 
			// AllOrderLabel
			// 
			this.AllOrderLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.AllOrderLabel.AutoSize = true;
			this.AllOrderLabel.Location = new System.Drawing.Point(22, 112);
			this.AllOrderLabel.Name = "AllOrderLabel";
			this.AllOrderLabel.Size = new System.Drawing.Size(0, 13);
			this.AllOrderLabel.TabIndex = 5;
			// 
			// RecommendedOrderLabel
			// 
			this.RecommendedOrderLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.RecommendedOrderLabel.AutoSize = true;
			this.RecommendedOrderLabel.Location = new System.Drawing.Point(22, 64);
			this.RecommendedOrderLabel.Name = "RecommendedOrderLabel";
			this.RecommendedOrderLabel.Size = new System.Drawing.Size(0, 13);
			this.RecommendedOrderLabel.TabIndex = 4;
			// 
			// WishlistButton
			// 
			this.WishlistButton.Location = new System.Drawing.Point(48, 3);
			this.WishlistButton.Name = "WishlistButton";
			this.WishlistButton.Size = new System.Drawing.Size(187, 41);
			this.WishlistButton.TabIndex = 2;
			this.WishlistButton.Text = "Wishlist";
			this.WishlistButton.UseVisualStyleBackColor = true;
			this.WishlistButton.Click += new System.EventHandler(this.WishlistButton_Click);
			// 
			// RecommendedButton
			// 
			this.RecommendedButton.Location = new System.Drawing.Point(48, 50);
			this.RecommendedButton.Name = "RecommendedButton";
			this.RecommendedButton.Size = new System.Drawing.Size(187, 41);
			this.RecommendedButton.TabIndex = 1;
			this.RecommendedButton.Text = "Recommended";
			this.RecommendedButton.UseVisualStyleBackColor = true;
			this.RecommendedButton.Click += new System.EventHandler(this.RecommendedButton_Click);
			// 
			// AllButton
			// 
			this.AllButton.Location = new System.Drawing.Point(48, 97);
			this.AllButton.Name = "AllButton";
			this.AllButton.Size = new System.Drawing.Size(187, 42);
			this.AllButton.TabIndex = 0;
			this.AllButton.Text = "All";
			this.AllButton.UseVisualStyleBackColor = true;
			this.AllButton.Click += new System.EventHandler(this.AllButton_Click);
			// 
			// WishlistOrderLabel
			// 
			this.WishlistOrderLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.WishlistOrderLabel.AutoSize = true;
			this.WishlistOrderLabel.Location = new System.Drawing.Point(22, 17);
			this.WishlistOrderLabel.Name = "WishlistOrderLabel";
			this.WishlistOrderLabel.Size = new System.Drawing.Size(0, 13);
			this.WishlistOrderLabel.TabIndex = 3;
			// 
			// FilterLabel
			// 
			this.FilterLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.FilterLabel.AutoSize = true;
			this.FilterLabel.Location = new System.Drawing.Point(3, 298);
			this.FilterLabel.Name = "FilterLabel";
			this.FilterLabel.Size = new System.Drawing.Size(29, 13);
			this.FilterLabel.TabIndex = 4;
			this.FilterLabel.Text = "Filter";
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.BackColor = System.Drawing.Color.DarkGray;
			this.tableLayoutPanel1.ColumnCount = 2;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 45F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.LevelOrderCB, 1, 0);
			this.tableLayoutPanel1.Controls.Add(this.LabelCostOrder, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.CostOrderComboBox, 1, 1);
			this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 388);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 2;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(238, 100);
			this.tableLayoutPanel1.TabIndex = 7;
			this.tableLayoutPanel1.Visible = false;
			this.tableLayoutPanel1.CellPaint += new System.Windows.Forms.TableLayoutCellPaintEventHandler(this.tableLayoutPanel1_CellPaint_1);
			// 
			// label1
			// 
			this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(3, 18);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(36, 13);
			this.label1.TabIndex = 3;
			this.label1.Text = "Level:";
			// 
			// LevelOrderCB
			// 
			this.LevelOrderCB.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.LevelOrderCB.Items.AddRange(new object[] {
            "No sorting",
            "From small to high",
            "From high to small "});
			this.LevelOrderCB.Location = new System.Drawing.Point(51, 14);
			this.LevelOrderCB.Name = "LevelOrderCB";
			this.LevelOrderCB.Size = new System.Drawing.Size(180, 21);
			this.LevelOrderCB.TabIndex = 4;
			// 
			// LabelCostOrder
			// 
			this.LabelCostOrder.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.LabelCostOrder.AutoSize = true;
			this.LabelCostOrder.Location = new System.Drawing.Point(3, 68);
			this.LabelCostOrder.Name = "LabelCostOrder";
			this.LabelCostOrder.Size = new System.Drawing.Size(31, 13);
			this.LabelCostOrder.TabIndex = 5;
			this.LabelCostOrder.Text = "Cost:";
			// 
			// CostOrderComboBox
			// 
			this.CostOrderComboBox.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.CostOrderComboBox.FormattingEnabled = true;
			this.CostOrderComboBox.Location = new System.Drawing.Point(51, 64);
			this.CostOrderComboBox.Name = "CostOrderComboBox";
			this.CostOrderComboBox.Size = new System.Drawing.Size(180, 21);
			this.CostOrderComboBox.TabIndex = 6;
			// 
			// FilterTablePanel
			// 
			this.FilterTablePanel.BackColor = System.Drawing.Color.DarkGray;
			this.FilterTablePanel.ColumnCount = 2;
			this.FilterTablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 45F));
			this.FilterTablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.FilterTablePanel.Controls.Add(this.CostRangeEdit, 1, 0);
			this.FilterTablePanel.Controls.Add(this.CostFilterLabel, 0, 0);
			this.FilterTablePanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.FilterTablePanel.Location = new System.Drawing.Point(3, 318);
			this.FilterTablePanel.Name = "FilterTablePanel";
			this.FilterTablePanel.RowCount = 1;
			this.FilterTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.FilterTablePanel.Size = new System.Drawing.Size(238, 44);
			this.FilterTablePanel.TabIndex = 5;
			this.FilterTablePanel.CellPaint += new System.Windows.Forms.TableLayoutCellPaintEventHandler(this.FilterTablePanel_CellPaint);
			// 
			// CostFilterLabel
			// 
			this.CostFilterLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.CostFilterLabel.AutoSize = true;
			this.CostFilterLabel.Location = new System.Drawing.Point(3, 15);
			this.CostFilterLabel.Name = "CostFilterLabel";
			this.CostFilterLabel.Size = new System.Drawing.Size(31, 13);
			this.CostFilterLabel.TabIndex = 0;
			this.CostFilterLabel.Text = "Cost:";
			// 
			// OrderLabel
			// 
			this.OrderLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.OrderLabel.AutoSize = true;
			this.OrderLabel.Location = new System.Drawing.Point(3, 368);
			this.OrderLabel.Name = "OrderLabel";
			this.OrderLabel.Size = new System.Drawing.Size(33, 13);
			this.OrderLabel.TabIndex = 8;
			this.OrderLabel.Text = "Order";
			this.OrderLabel.Visible = false;
			// 
			// notifyIcon
			// 
			this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
			this.notifyIcon.Text = "SteamgiftsBot";
			this.notifyIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon_MouseDoubleClick);
			// 
			// CostRangeEdit
			// 
			this.CostRangeEdit.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.CostRangeEdit.Location = new System.Drawing.Point(48, 10);
			this.CostRangeEdit.Name = "CostRangeEdit";
			this.CostRangeEdit.Size = new System.Drawing.Size(187, 23);
			this.CostRangeEdit.TabIndex = 1;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.DimGray;
			this.ClientSize = new System.Drawing.Size(784, 561);
			this.Controls.Add(this.MainTablePanel);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MinimumSize = new System.Drawing.Size(800, 600);
			this.Name = "MainForm";
			this.Text = "SteamgiftsBot";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
			this.Load += new System.EventHandler(this.MainForm_Load);
			this.Resize += new System.EventHandler(this.MainForm_Resize);
			this.RightLayoutPanel.ResumeLayout(false);
			this.RightLayoutPanel.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.RefreshPictureBox)).EndInit();
			this.MainTablePanel.ResumeLayout(false);
			this.LeftTablePanel.ResumeLayout(false);
			this.LeftTablePanel.PerformLayout();
			this.ProfileTablePanel.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.AvatarPictureBox)).EndInit();
			this.ProfileInfoTablePanel.ResumeLayout(false);
			this.ProfileInfoTablePanel.PerformLayout();
			this.OrderTablePanel.ResumeLayout(false);
			this.OrderTablePanel.PerformLayout();
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			this.FilterTablePanel.ResumeLayout(false);
			this.FilterTablePanel.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.TableLayoutPanel RightLayoutPanel;
		private System.Windows.Forms.TableLayoutPanel MainTablePanel;
		private System.Windows.Forms.Label QueueLabel;
		private System.Windows.Forms.Button StartBotBtn;
		private System.Windows.Forms.TableLayoutPanel LeftTablePanel;
		private System.Windows.Forms.TableLayoutPanel ProfileTablePanel;
		private System.Windows.Forms.PictureBox AvatarPictureBox;
		private System.Windows.Forms.Label BotSettingsLabel;
		private System.Windows.Forms.Label GiveawaysOrderLabel;
		private System.Windows.Forms.TableLayoutPanel OrderTablePanel;
		private System.Windows.Forms.Label FilterLabel;
		private System.Windows.Forms.Button WishlistButton;
		private System.Windows.Forms.Button RecommendedButton;
		private System.Windows.Forms.Button AllButton;
		private System.Windows.Forms.Label WishlistOrderLabel;
		private System.Windows.Forms.Label AllOrderLabel;
		private System.Windows.Forms.Label RecommendedOrderLabel;
		private System.Windows.Forms.TableLayoutPanel ProfileInfoTablePanel;
		private System.Windows.Forms.Label LevelLabel;
		private System.Windows.Forms.Label PointsLabel;
		private System.Windows.Forms.TextBox ProfileNameTextEdit;
		private System.Windows.Forms.NotifyIcon notifyIcon;
		private System.Windows.Forms.PictureBox RefreshPictureBox;
		private System.Windows.Forms.Button ApplyFilterBtn;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox LevelOrderCB;
		private System.Windows.Forms.TableLayoutPanel FilterTablePanel;
		private RangeEdit CostRangeEdit;
		private System.Windows.Forms.Label CostFilterLabel;
		private System.Windows.Forms.Label OrderLabel;
		private System.Windows.Forms.Label LabelCostOrder;
		private System.Windows.Forms.ComboBox CostOrderComboBox;
	}
}

