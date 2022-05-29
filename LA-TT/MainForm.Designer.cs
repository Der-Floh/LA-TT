namespace LA_TT
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.MenuStrip = new System.Windows.Forms.MenuStrip();
            this.fIleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAllCardsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAllFFCardsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshCardsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addCardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DeckListBox = new System.Windows.Forms.ListBox();
            this.DecksComboBox = new System.Windows.Forms.ComboBox();
            this.DecksPanel = new System.Windows.Forms.Panel();
            this.DecksLabel = new System.Windows.Forms.Label();
            this.CardManagerMenuStrip = new System.Windows.Forms.MenuStrip();
            this.yourCardsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deckToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OwnedCardsPanel = new System.Windows.Forms.Panel();
            this.FilterButton = new System.Windows.Forms.Button();
            this.OperatorComboBox = new System.Windows.Forms.ComboBox();
            this.OperatorLabel = new System.Windows.Forms.Label();
            this.FilterNumericBox = new System.Windows.Forms.NumericUpDown();
            this.FilterTextBox = new System.Windows.Forms.TextBox();
            this.FilterLabel = new System.Windows.Forms.Label();
            this.FilterComboBox = new System.Windows.Forms.ComboBox();
            this.RefreshYourCardsButton = new System.Windows.Forms.Button();
            this.OwnedCardsCardImagePanel = new System.Windows.Forms.Panel();
            this.CardLevelTextBox = new System.Windows.Forms.TextBox();
            this.CardDefenseTextBox = new System.Windows.Forms.TextBox();
            this.CardAttackTextBox = new System.Windows.Forms.TextBox();
            this.CardNameTextBox = new System.Windows.Forms.TextBox();
            this.CFPictureBox = new System.Windows.Forms.PictureBox();
            this.CardPictureBox = new System.Windows.Forms.PictureBox();
            this.OwnedCardsHideMaxLevelCheckBox = new System.Windows.Forms.CheckBox();
            this.OwnedCardsInDeckCheckBox = new System.Windows.Forms.CheckBox();
            this.OwnedCardsOrderLabel = new System.Windows.Forms.Label();
            this.OwnedCardsOrderComboBox = new System.Windows.Forms.ComboBox();
            this.OwnedCardsSortLabel = new System.Windows.Forms.Label();
            this.OwnedCardsListBox = new System.Windows.Forms.ListBox();
            this.OwnedCardsSortComboBox = new System.Windows.Forms.ComboBox();
            this.AddToDeckPanel = new System.Windows.Forms.Panel();
            this.RemoveAllToDeckButton = new System.Windows.Forms.Button();
            this.RemoveOneToDeckButton = new System.Windows.Forms.Button();
            this.AddAllToDeckButton = new System.Windows.Forms.Button();
            this.AddOneToDeckButton = new System.Windows.Forms.Button();
            this.MenuStrip.SuspendLayout();
            this.DecksPanel.SuspendLayout();
            this.CardManagerMenuStrip.SuspendLayout();
            this.OwnedCardsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FilterNumericBox)).BeginInit();
            this.OwnedCardsCardImagePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CFPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CardPictureBox)).BeginInit();
            this.AddToDeckPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuStrip
            // 
            this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fIleToolStripMenuItem,
            this.editToolStripMenuItem,
            this.viewToolStripMenuItem});
            this.MenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip.Name = "MenuStrip";
            this.MenuStrip.Size = new System.Drawing.Size(999, 24);
            this.MenuStrip.TabIndex = 0;
            this.MenuStrip.Text = "Menu";
            // 
            // fIleToolStripMenuItem
            // 
            this.fIleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveAllCardsToolStripMenuItem,
            this.saveAllFFCardsToolStripMenuItem});
            this.fIleToolStripMenuItem.Name = "fIleToolStripMenuItem";
            this.fIleToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fIleToolStripMenuItem.Text = "File";
            // 
            // saveAllCardsToolStripMenuItem
            // 
            this.saveAllCardsToolStripMenuItem.Name = "saveAllCardsToolStripMenuItem";
            this.saveAllCardsToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.saveAllCardsToolStripMenuItem.Text = "Save all CC Cards";
            this.saveAllCardsToolStripMenuItem.Click += new System.EventHandler(this.saveAllCardsToolStripMenuItem_Click);
            // 
            // saveAllFFCardsToolStripMenuItem
            // 
            this.saveAllFFCardsToolStripMenuItem.Name = "saveAllFFCardsToolStripMenuItem";
            this.saveAllFFCardsToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.saveAllFFCardsToolStripMenuItem.Text = "Save all FF Cards";
            this.saveAllFFCardsToolStripMenuItem.Click += new System.EventHandler(this.saveAllFFCardsToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.refreshCardsToolStripMenuItem,
            this.addCardToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // refreshCardsToolStripMenuItem
            // 
            this.refreshCardsToolStripMenuItem.Name = "refreshCardsToolStripMenuItem";
            this.refreshCardsToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.refreshCardsToolStripMenuItem.Text = "Refresh Cards";
            // 
            // addCardToolStripMenuItem
            // 
            this.addCardToolStripMenuItem.Name = "addCardToolStripMenuItem";
            this.addCardToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.addCardToolStripMenuItem.Text = "Add Card";
            this.addCardToolStripMenuItem.Click += new System.EventHandler(this.addCardToolStripMenuItem_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // DeckListBox
            // 
            this.DeckListBox.AllowDrop = true;
            this.DeckListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DeckListBox.FormattingEnabled = true;
            this.DeckListBox.ItemHeight = 15;
            this.DeckListBox.Location = new System.Drawing.Point(13, 32);
            this.DeckListBox.Name = "DeckListBox";
            this.DeckListBox.Size = new System.Drawing.Size(198, 304);
            this.DeckListBox.TabIndex = 2;
            // 
            // DecksComboBox
            // 
            this.DecksComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DecksComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DecksComboBox.FormattingEnabled = true;
            this.DecksComboBox.Items.AddRange(new object[] {
            "Deck 1",
            "Deck 2",
            "Deck 3"});
            this.DecksComboBox.Location = new System.Drawing.Point(60, 3);
            this.DecksComboBox.Name = "DecksComboBox";
            this.DecksComboBox.Size = new System.Drawing.Size(151, 23);
            this.DecksComboBox.TabIndex = 3;
            // 
            // DecksPanel
            // 
            this.DecksPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DecksPanel.Controls.Add(this.DecksLabel);
            this.DecksPanel.Controls.Add(this.DeckListBox);
            this.DecksPanel.Controls.Add(this.DecksComboBox);
            this.DecksPanel.Location = new System.Drawing.Point(641, 167);
            this.DecksPanel.Name = "DecksPanel";
            this.DecksPanel.Size = new System.Drawing.Size(346, 350);
            this.DecksPanel.TabIndex = 4;
            // 
            // DecksLabel
            // 
            this.DecksLabel.AutoSize = true;
            this.DecksLabel.Location = new System.Drawing.Point(13, 6);
            this.DecksLabel.Name = "DecksLabel";
            this.DecksLabel.Size = new System.Drawing.Size(41, 15);
            this.DecksLabel.TabIndex = 4;
            this.DecksLabel.Text = "Decks:";
            // 
            // CardManagerMenuStrip
            // 
            this.CardManagerMenuStrip.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.CardManagerMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yourCardsToolStripMenuItem,
            this.deckToolStripMenuItem});
            this.CardManagerMenuStrip.Location = new System.Drawing.Point(0, 573);
            this.CardManagerMenuStrip.Name = "CardManagerMenuStrip";
            this.CardManagerMenuStrip.Size = new System.Drawing.Size(999, 24);
            this.CardManagerMenuStrip.TabIndex = 5;
            this.CardManagerMenuStrip.Text = "Card Manager";
            // 
            // yourCardsToolStripMenuItem
            // 
            this.yourCardsToolStripMenuItem.Name = "yourCardsToolStripMenuItem";
            this.yourCardsToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.yourCardsToolStripMenuItem.Text = "Your Cards";
            // 
            // deckToolStripMenuItem
            // 
            this.deckToolStripMenuItem.Name = "deckToolStripMenuItem";
            this.deckToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.deckToolStripMenuItem.Text = "Your Deck";
            // 
            // OwnedCardsPanel
            // 
            this.OwnedCardsPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.OwnedCardsPanel.Controls.Add(this.FilterButton);
            this.OwnedCardsPanel.Controls.Add(this.OperatorComboBox);
            this.OwnedCardsPanel.Controls.Add(this.OperatorLabel);
            this.OwnedCardsPanel.Controls.Add(this.FilterNumericBox);
            this.OwnedCardsPanel.Controls.Add(this.FilterTextBox);
            this.OwnedCardsPanel.Controls.Add(this.FilterLabel);
            this.OwnedCardsPanel.Controls.Add(this.FilterComboBox);
            this.OwnedCardsPanel.Controls.Add(this.RefreshYourCardsButton);
            this.OwnedCardsPanel.Controls.Add(this.OwnedCardsCardImagePanel);
            this.OwnedCardsPanel.Controls.Add(this.OwnedCardsHideMaxLevelCheckBox);
            this.OwnedCardsPanel.Controls.Add(this.OwnedCardsInDeckCheckBox);
            this.OwnedCardsPanel.Controls.Add(this.OwnedCardsOrderLabel);
            this.OwnedCardsPanel.Controls.Add(this.OwnedCardsOrderComboBox);
            this.OwnedCardsPanel.Controls.Add(this.OwnedCardsSortLabel);
            this.OwnedCardsPanel.Controls.Add(this.OwnedCardsListBox);
            this.OwnedCardsPanel.Controls.Add(this.OwnedCardsSortComboBox);
            this.OwnedCardsPanel.Location = new System.Drawing.Point(12, 124);
            this.OwnedCardsPanel.Name = "OwnedCardsPanel";
            this.OwnedCardsPanel.Size = new System.Drawing.Size(501, 424);
            this.OwnedCardsPanel.TabIndex = 6;
            // 
            // FilterButton
            // 
            this.FilterButton.Location = new System.Drawing.Point(447, 8);
            this.FilterButton.Name = "FilterButton";
            this.FilterButton.Size = new System.Drawing.Size(48, 23);
            this.FilterButton.TabIndex = 15;
            this.FilterButton.Text = "Ok";
            this.FilterButton.UseVisualStyleBackColor = true;
            this.FilterButton.Click += new System.EventHandler(this.FilterButton_Click);
            // 
            // OperatorComboBox
            // 
            this.OperatorComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.OperatorComboBox.FormattingEnabled = true;
            this.OperatorComboBox.Items.AddRange(new object[] {
            "<<",
            "<=",
            "==",
            ">=",
            ">>"});
            this.OperatorComboBox.Location = new System.Drawing.Point(393, 8);
            this.OperatorComboBox.Name = "OperatorComboBox";
            this.OperatorComboBox.Size = new System.Drawing.Size(48, 23);
            this.OperatorComboBox.TabIndex = 14;
            this.OperatorComboBox.SelectedIndexChanged += new System.EventHandler(this.OperatorComboBox_SelectedIndexChanged);
            // 
            // OperatorLabel
            // 
            this.OperatorLabel.AutoSize = true;
            this.OperatorLabel.Location = new System.Drawing.Point(330, 12);
            this.OperatorLabel.Name = "OperatorLabel";
            this.OperatorLabel.Size = new System.Drawing.Size(57, 15);
            this.OperatorLabel.TabIndex = 13;
            this.OperatorLabel.Text = "Operator:";
            // 
            // FilterNumericBox
            // 
            this.FilterNumericBox.Location = new System.Drawing.Point(176, 9);
            this.FilterNumericBox.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.FilterNumericBox.Name = "FilterNumericBox";
            this.FilterNumericBox.Size = new System.Drawing.Size(148, 23);
            this.FilterNumericBox.TabIndex = 12;
            this.FilterNumericBox.Visible = false;
            // 
            // FilterTextBox
            // 
            this.FilterTextBox.Location = new System.Drawing.Point(176, 9);
            this.FilterTextBox.Name = "FilterTextBox";
            this.FilterTextBox.Size = new System.Drawing.Size(148, 23);
            this.FilterTextBox.TabIndex = 11;
            // 
            // FilterLabel
            // 
            this.FilterLabel.AutoSize = true;
            this.FilterLabel.Location = new System.Drawing.Point(9, 12);
            this.FilterLabel.Name = "FilterLabel";
            this.FilterLabel.Size = new System.Drawing.Size(36, 15);
            this.FilterLabel.TabIndex = 10;
            this.FilterLabel.Text = "Filter:";
            // 
            // FilterComboBox
            // 
            this.FilterComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FilterComboBox.FormattingEnabled = true;
            this.FilterComboBox.Items.AddRange(new object[] {
            "None",
            "Name",
            "Attack",
            "Defense",
            "Rarity",
            "Level"});
            this.FilterComboBox.Location = new System.Drawing.Point(51, 9);
            this.FilterComboBox.Name = "FilterComboBox";
            this.FilterComboBox.Size = new System.Drawing.Size(119, 23);
            this.FilterComboBox.TabIndex = 9;
            this.FilterComboBox.SelectedIndexChanged += new System.EventHandler(this.FilterComboBox_SelectedIndexChanged);
            // 
            // RefreshYourCardsButton
            // 
            this.RefreshYourCardsButton.Location = new System.Drawing.Point(273, 356);
            this.RefreshYourCardsButton.Name = "RefreshYourCardsButton";
            this.RefreshYourCardsButton.Size = new System.Drawing.Size(101, 30);
            this.RefreshYourCardsButton.TabIndex = 4;
            this.RefreshYourCardsButton.Text = "Refresh List";
            this.RefreshYourCardsButton.UseVisualStyleBackColor = true;
            this.RefreshYourCardsButton.Click += new System.EventHandler(this.RefreshYourCardsButton_Click);
            // 
            // OwnedCardsCardImagePanel
            // 
            this.OwnedCardsCardImagePanel.Controls.Add(this.CardLevelTextBox);
            this.OwnedCardsCardImagePanel.Controls.Add(this.CardDefenseTextBox);
            this.OwnedCardsCardImagePanel.Controls.Add(this.CardAttackTextBox);
            this.OwnedCardsCardImagePanel.Controls.Add(this.CardNameTextBox);
            this.OwnedCardsCardImagePanel.Controls.Add(this.CFPictureBox);
            this.OwnedCardsCardImagePanel.Controls.Add(this.CardPictureBox);
            this.OwnedCardsCardImagePanel.Location = new System.Drawing.Point(273, 117);
            this.OwnedCardsCardImagePanel.Name = "OwnedCardsCardImagePanel";
            this.OwnedCardsCardImagePanel.Size = new System.Drawing.Size(172, 233);
            this.OwnedCardsCardImagePanel.TabIndex = 8;
            // 
            // CardLevelTextBox
            // 
            this.CardLevelTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CardLevelTextBox.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CardLevelTextBox.Location = new System.Drawing.Point(13, 13);
            this.CardLevelTextBox.Name = "CardLevelTextBox";
            this.CardLevelTextBox.ReadOnly = true;
            this.CardLevelTextBox.Size = new System.Drawing.Size(22, 22);
            this.CardLevelTextBox.TabIndex = 26;
            this.CardLevelTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // CardDefenseTextBox
            // 
            this.CardDefenseTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CardDefenseTextBox.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CardDefenseTextBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.CardDefenseTextBox.Location = new System.Drawing.Point(105, 12);
            this.CardDefenseTextBox.Name = "CardDefenseTextBox";
            this.CardDefenseTextBox.ReadOnly = true;
            this.CardDefenseTextBox.Size = new System.Drawing.Size(55, 25);
            this.CardDefenseTextBox.TabIndex = 25;
            this.CardDefenseTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // CardAttackTextBox
            // 
            this.CardAttackTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CardAttackTextBox.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CardAttackTextBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.CardAttackTextBox.Location = new System.Drawing.Point(44, 12);
            this.CardAttackTextBox.Name = "CardAttackTextBox";
            this.CardAttackTextBox.ReadOnly = true;
            this.CardAttackTextBox.Size = new System.Drawing.Size(55, 25);
            this.CardAttackTextBox.TabIndex = 24;
            this.CardAttackTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // CardNameTextBox
            // 
            this.CardNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CardNameTextBox.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CardNameTextBox.Location = new System.Drawing.Point(24, 204);
            this.CardNameTextBox.Name = "CardNameTextBox";
            this.CardNameTextBox.ReadOnly = true;
            this.CardNameTextBox.Size = new System.Drawing.Size(125, 22);
            this.CardNameTextBox.TabIndex = 23;
            this.CardNameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // CFPictureBox
            // 
            this.CFPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.CFPictureBox.Image = global::LA_TT.Properties.Resources.C;
            this.CFPictureBox.InitialImage = null;
            this.CFPictureBox.Location = new System.Drawing.Point(6, 40);
            this.CFPictureBox.Name = "CFPictureBox";
            this.CFPictureBox.Size = new System.Drawing.Size(20, 20);
            this.CFPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.CFPictureBox.TabIndex = 22;
            this.CFPictureBox.TabStop = false;
            // 
            // CardPictureBox
            // 
            this.CardPictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CardPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.CardPictureBox.Image = global::LA_TT.Properties.Resources.CardB;
            this.CardPictureBox.Location = new System.Drawing.Point(3, 3);
            this.CardPictureBox.Name = "CardPictureBox";
            this.CardPictureBox.Size = new System.Drawing.Size(166, 227);
            this.CardPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.CardPictureBox.TabIndex = 19;
            this.CardPictureBox.TabStop = false;
            // 
            // OwnedCardsHideMaxLevelCheckBox
            // 
            this.OwnedCardsHideMaxLevelCheckBox.AutoSize = true;
            this.OwnedCardsHideMaxLevelCheckBox.Location = new System.Drawing.Point(273, 92);
            this.OwnedCardsHideMaxLevelCheckBox.Name = "OwnedCardsHideMaxLevelCheckBox";
            this.OwnedCardsHideMaxLevelCheckBox.Size = new System.Drawing.Size(114, 19);
            this.OwnedCardsHideMaxLevelCheckBox.TabIndex = 8;
            this.OwnedCardsHideMaxLevelCheckBox.Text = "Hide Max Leveld";
            this.OwnedCardsHideMaxLevelCheckBox.UseVisualStyleBackColor = true;
            // 
            // OwnedCardsInDeckCheckBox
            // 
            this.OwnedCardsInDeckCheckBox.AutoSize = true;
            this.OwnedCardsInDeckCheckBox.Location = new System.Drawing.Point(273, 67);
            this.OwnedCardsInDeckCheckBox.Name = "OwnedCardsInDeckCheckBox";
            this.OwnedCardsInDeckCheckBox.Size = new System.Drawing.Size(125, 19);
            this.OwnedCardsInDeckCheckBox.TabIndex = 7;
            this.OwnedCardsInDeckCheckBox.Text = "Show Only in Deck";
            this.OwnedCardsInDeckCheckBox.UseVisualStyleBackColor = true;
            // 
            // OwnedCardsOrderLabel
            // 
            this.OwnedCardsOrderLabel.AutoSize = true;
            this.OwnedCardsOrderLabel.Location = new System.Drawing.Point(192, 41);
            this.OwnedCardsOrderLabel.Name = "OwnedCardsOrderLabel";
            this.OwnedCardsOrderLabel.Size = new System.Drawing.Size(40, 15);
            this.OwnedCardsOrderLabel.TabIndex = 6;
            this.OwnedCardsOrderLabel.Text = "Order:";
            // 
            // OwnedCardsOrderComboBox
            // 
            this.OwnedCardsOrderComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.OwnedCardsOrderComboBox.FormattingEnabled = true;
            this.OwnedCardsOrderComboBox.Items.AddRange(new object[] {
            "Asscending",
            "Descending"});
            this.OwnedCardsOrderComboBox.Location = new System.Drawing.Point(238, 38);
            this.OwnedCardsOrderComboBox.Name = "OwnedCardsOrderComboBox";
            this.OwnedCardsOrderComboBox.Size = new System.Drawing.Size(160, 23);
            this.OwnedCardsOrderComboBox.TabIndex = 5;
            this.OwnedCardsOrderComboBox.SelectedIndexChanged += new System.EventHandler(this.OwnedCardsOrderComboBox_SelectedIndexChanged);
            // 
            // OwnedCardsSortLabel
            // 
            this.OwnedCardsSortLabel.AutoSize = true;
            this.OwnedCardsSortLabel.Location = new System.Drawing.Point(9, 41);
            this.OwnedCardsSortLabel.Name = "OwnedCardsSortLabel";
            this.OwnedCardsSortLabel.Size = new System.Drawing.Size(31, 15);
            this.OwnedCardsSortLabel.TabIndex = 4;
            this.OwnedCardsSortLabel.Text = "Sort:";
            // 
            // OwnedCardsListBox
            // 
            this.OwnedCardsListBox.AllowDrop = true;
            this.OwnedCardsListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.OwnedCardsListBox.FormattingEnabled = true;
            this.OwnedCardsListBox.ItemHeight = 15;
            this.OwnedCardsListBox.Location = new System.Drawing.Point(9, 67);
            this.OwnedCardsListBox.Name = "OwnedCardsListBox";
            this.OwnedCardsListBox.Size = new System.Drawing.Size(258, 349);
            this.OwnedCardsListBox.TabIndex = 2;
            this.OwnedCardsListBox.SelectedIndexChanged += new System.EventHandler(this.OwnedCardsListBox_SelectedIndexChanged);
            // 
            // OwnedCardsSortComboBox
            // 
            this.OwnedCardsSortComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.OwnedCardsSortComboBox.FormattingEnabled = true;
            this.OwnedCardsSortComboBox.Items.AddRange(new object[] {
            "Name",
            "Attack",
            "Defense",
            "Best Stats",
            "Rarity",
            "Level",
            "Combo Number",
            "Best Combos"});
            this.OwnedCardsSortComboBox.Location = new System.Drawing.Point(46, 38);
            this.OwnedCardsSortComboBox.Name = "OwnedCardsSortComboBox";
            this.OwnedCardsSortComboBox.Size = new System.Drawing.Size(140, 23);
            this.OwnedCardsSortComboBox.TabIndex = 3;
            this.OwnedCardsSortComboBox.SelectedIndexChanged += new System.EventHandler(this.OwnedCardsSortComboBox_SelectedIndexChanged);
            // 
            // AddToDeckPanel
            // 
            this.AddToDeckPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.AddToDeckPanel.Controls.Add(this.RemoveAllToDeckButton);
            this.AddToDeckPanel.Controls.Add(this.RemoveOneToDeckButton);
            this.AddToDeckPanel.Controls.Add(this.AddAllToDeckButton);
            this.AddToDeckPanel.Controls.Add(this.AddOneToDeckButton);
            this.AddToDeckPanel.Location = new System.Drawing.Point(531, 167);
            this.AddToDeckPanel.Name = "AddToDeckPanel";
            this.AddToDeckPanel.Size = new System.Drawing.Size(92, 350);
            this.AddToDeckPanel.TabIndex = 7;
            // 
            // RemoveAllToDeckButton
            // 
            this.RemoveAllToDeckButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RemoveAllToDeckButton.Location = new System.Drawing.Point(19, 183);
            this.RemoveAllToDeckButton.Name = "RemoveAllToDeckButton";
            this.RemoveAllToDeckButton.Size = new System.Drawing.Size(54, 30);
            this.RemoveAllToDeckButton.TabIndex = 3;
            this.RemoveAllToDeckButton.Text = "<-";
            this.RemoveAllToDeckButton.UseVisualStyleBackColor = true;
            // 
            // RemoveOneToDeckButton
            // 
            this.RemoveOneToDeckButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RemoveOneToDeckButton.Location = new System.Drawing.Point(19, 147);
            this.RemoveOneToDeckButton.Name = "RemoveOneToDeckButton";
            this.RemoveOneToDeckButton.Size = new System.Drawing.Size(54, 30);
            this.RemoveOneToDeckButton.TabIndex = 2;
            this.RemoveOneToDeckButton.Text = "<==";
            this.RemoveOneToDeckButton.UseVisualStyleBackColor = true;
            // 
            // AddAllToDeckButton
            // 
            this.AddAllToDeckButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AddAllToDeckButton.Location = new System.Drawing.Point(19, 111);
            this.AddAllToDeckButton.Name = "AddAllToDeckButton";
            this.AddAllToDeckButton.Size = new System.Drawing.Size(54, 30);
            this.AddAllToDeckButton.TabIndex = 1;
            this.AddAllToDeckButton.Text = "==>";
            this.AddAllToDeckButton.UseVisualStyleBackColor = true;
            // 
            // AddOneToDeckButton
            // 
            this.AddOneToDeckButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AddOneToDeckButton.Location = new System.Drawing.Point(19, 75);
            this.AddOneToDeckButton.Name = "AddOneToDeckButton";
            this.AddOneToDeckButton.Size = new System.Drawing.Size(54, 30);
            this.AddOneToDeckButton.TabIndex = 0;
            this.AddOneToDeckButton.Text = "->";
            this.AddOneToDeckButton.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(999, 597);
            this.Controls.Add(this.AddToDeckPanel);
            this.Controls.Add(this.OwnedCardsPanel);
            this.Controls.Add(this.DecksPanel);
            this.Controls.Add(this.MenuStrip);
            this.Controls.Add(this.CardManagerMenuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.MenuStrip;
            this.MinimumSize = new System.Drawing.Size(1015, 636);
            this.Name = "MainForm";
            this.Text = "Little Alchimist - The Tool";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            this.MenuStrip.ResumeLayout(false);
            this.MenuStrip.PerformLayout();
            this.DecksPanel.ResumeLayout(false);
            this.DecksPanel.PerformLayout();
            this.CardManagerMenuStrip.ResumeLayout(false);
            this.CardManagerMenuStrip.PerformLayout();
            this.OwnedCardsPanel.ResumeLayout(false);
            this.OwnedCardsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FilterNumericBox)).EndInit();
            this.OwnedCardsCardImagePanel.ResumeLayout(false);
            this.OwnedCardsCardImagePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CFPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CardPictureBox)).EndInit();
            this.AddToDeckPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip MenuStrip;
        private ToolStripMenuItem fIleToolStripMenuItem;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem refreshCardsToolStripMenuItem;
        private ToolStripMenuItem viewToolStripMenuItem;
        private ListBox DeckListBox;
        private ComboBox DecksComboBox;
        private Panel DecksPanel;
        private MenuStrip CardManagerMenuStrip;
        private ToolStripMenuItem yourCardsToolStripMenuItem;
        private ToolStripMenuItem deckToolStripMenuItem;
        private Label DecksLabel;
        private Panel OwnedCardsPanel;
        private Label OwnedCardsOrderLabel;
        private ComboBox OwnedCardsOrderComboBox;
        private Label OwnedCardsSortLabel;
        private ListBox OwnedCardsListBox;
        private ComboBox OwnedCardsSortComboBox;
        private CheckBox OwnedCardsHideMaxLevelCheckBox;
        private CheckBox OwnedCardsInDeckCheckBox;
        private Panel AddToDeckPanel;
        private Button RemoveAllToDeckButton;
        private Button RemoveOneToDeckButton;
        private Button AddAllToDeckButton;
        private Button AddOneToDeckButton;
        private Panel OwnedCardsCardImagePanel;
        private ToolStripMenuItem addCardToolStripMenuItem;
        private ToolStripMenuItem saveAllCardsToolStripMenuItem;
        private ToolStripMenuItem saveAllFFCardsToolStripMenuItem;
        private Button RefreshYourCardsButton;
        public PictureBox CardPictureBox;
        public PictureBox CFPictureBox;
        public TextBox CardNameTextBox;
        public TextBox CardLevelTextBox;
        public TextBox CardDefenseTextBox;
        public TextBox CardAttackTextBox;
        public TextBox FilterTextBox;
        private Label FilterLabel;
        private ComboBox FilterComboBox;
        public NumericUpDown FilterNumericBox;
        private Label OperatorLabel;
        private ComboBox OperatorComboBox;
        private Button FilterButton;
    }
}