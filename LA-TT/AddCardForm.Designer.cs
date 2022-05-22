namespace LA_TT
{
    partial class AddCardForm
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
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.CardPanel = new System.Windows.Forms.Panel();
            this.ComboCardCheckBox = new System.Windows.Forms.CheckBox();
            this.RarityLabel = new System.Windows.Forms.Label();
            this.RarityNumericBox = new System.Windows.Forms.NumericUpDown();
            this.CFPictureBox = new System.Windows.Forms.PictureBox();
            this.DefenseLabel = new System.Windows.Forms.Label();
            this.DefenseNumericBox = new System.Windows.Forms.NumericUpDown();
            this.AttackNumericBox = new System.Windows.Forms.NumericUpDown();
            this.BluePictureBox = new System.Windows.Forms.PictureBox();
            this.NameLabel = new System.Windows.Forms.Label();
            this.LevelLabel = new System.Windows.Forms.Label();
            this.AttackLabel = new System.Windows.Forms.Label();
            this.LevelNumericBox = new System.Windows.Forms.NumericUpDown();
            this.OrangePictureBox = new System.Windows.Forms.PictureBox();
            this.ImagePictureBox = new System.Windows.Forms.PictureBox();
            this.CardPictureBox = new System.Windows.Forms.PictureBox();
            this.CombosToLabel = new System.Windows.Forms.Label();
            this.CombosToCardTextBox = new System.Windows.Forms.TextBox();
            this.CombosWithLabel = new System.Windows.Forms.Label();
            this.CombosWithTextBox = new System.Windows.Forms.TextBox();
            this.OkButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.LeaveOpenCheckBox = new System.Windows.Forms.CheckBox();
            this.AddComboButton = new System.Windows.Forms.Button();
            this.ComboCardsListBox = new System.Windows.Forms.ListBox();
            this.ErrorsListBox = new System.Windows.Forms.ListBox();
            this.ErrorsLabel = new System.Windows.Forms.Label();
            this.DeleteComboButton = new System.Windows.Forms.Button();
            this.InstantSaveCheckBox = new System.Windows.Forms.CheckBox();
            this.CardPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RarityNumericBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CFPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DefenseNumericBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AttackNumericBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BluePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LevelNumericBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrangePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImagePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CardPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // NameTextBox
            // 
            this.NameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NameTextBox.Location = new System.Drawing.Point(53, 483);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(303, 23);
            this.NameTextBox.TabIndex = 0;
            this.NameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NameTextBox.TextChanged += new System.EventHandler(this.NameTextBox_TextChanged);
            // 
            // CardPanel
            // 
            this.CardPanel.Controls.Add(this.ComboCardCheckBox);
            this.CardPanel.Controls.Add(this.RarityLabel);
            this.CardPanel.Controls.Add(this.RarityNumericBox);
            this.CardPanel.Controls.Add(this.CFPictureBox);
            this.CardPanel.Controls.Add(this.DefenseLabel);
            this.CardPanel.Controls.Add(this.DefenseNumericBox);
            this.CardPanel.Controls.Add(this.AttackNumericBox);
            this.CardPanel.Controls.Add(this.BluePictureBox);
            this.CardPanel.Controls.Add(this.NameLabel);
            this.CardPanel.Controls.Add(this.LevelLabel);
            this.CardPanel.Controls.Add(this.AttackLabel);
            this.CardPanel.Controls.Add(this.LevelNumericBox);
            this.CardPanel.Controls.Add(this.NameTextBox);
            this.CardPanel.Controls.Add(this.OrangePictureBox);
            this.CardPanel.Controls.Add(this.ImagePictureBox);
            this.CardPanel.Controls.Add(this.CardPictureBox);
            this.CardPanel.Location = new System.Drawing.Point(35, 31);
            this.CardPanel.Name = "CardPanel";
            this.CardPanel.Size = new System.Drawing.Size(405, 562);
            this.CardPanel.TabIndex = 5;
            // 
            // ComboCardCheckBox
            // 
            this.ComboCardCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ComboCardCheckBox.AutoSize = true;
            this.ComboCardCheckBox.Checked = true;
            this.ComboCardCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ComboCardCheckBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ComboCardCheckBox.Location = new System.Drawing.Point(250, 444);
            this.ComboCardCheckBox.Name = "ComboCardCheckBox";
            this.ComboCardCheckBox.Size = new System.Drawing.Size(117, 25);
            this.ComboCardCheckBox.TabIndex = 22;
            this.ComboCardCheckBox.Text = "Combo Card";
            this.ComboCardCheckBox.UseVisualStyleBackColor = true;
            this.ComboCardCheckBox.CheckedChanged += new System.EventHandler(this.ComboCardCheckBox_CheckedChanged);
            // 
            // RarityLabel
            // 
            this.RarityLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.RarityLabel.AutoSize = true;
            this.RarityLabel.BackColor = System.Drawing.Color.Transparent;
            this.RarityLabel.Location = new System.Drawing.Point(44, 424);
            this.RarityLabel.Name = "RarityLabel";
            this.RarityLabel.Size = new System.Drawing.Size(37, 15);
            this.RarityLabel.TabIndex = 21;
            this.RarityLabel.Text = "Rarity";
            // 
            // RarityNumericBox
            // 
            this.RarityNumericBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.RarityNumericBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RarityNumericBox.Location = new System.Drawing.Point(42, 442);
            this.RarityNumericBox.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.RarityNumericBox.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.RarityNumericBox.Name = "RarityNumericBox";
            this.RarityNumericBox.Size = new System.Drawing.Size(44, 29);
            this.RarityNumericBox.TabIndex = 20;
            this.RarityNumericBox.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.RarityNumericBox.ValueChanged += new System.EventHandler(this.RarityNumericBox_ValueChanged);
            // 
            // CFPictureBox
            // 
            this.CFPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.CFPictureBox.Image = global::LA_TT.Properties.Resources.C;
            this.CFPictureBox.InitialImage = null;
            this.CFPictureBox.Location = new System.Drawing.Point(26, 119);
            this.CFPictureBox.Name = "CFPictureBox";
            this.CFPictureBox.Size = new System.Drawing.Size(50, 50);
            this.CFPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.CFPictureBox.TabIndex = 19;
            this.CFPictureBox.TabStop = false;
            // 
            // DefenseLabel
            // 
            this.DefenseLabel.AutoSize = true;
            this.DefenseLabel.BackColor = System.Drawing.Color.Transparent;
            this.DefenseLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DefenseLabel.Location = new System.Drawing.Point(269, 93);
            this.DefenseLabel.Name = "DefenseLabel";
            this.DefenseLabel.Size = new System.Drawing.Size(66, 21);
            this.DefenseLabel.TabIndex = 11;
            this.DefenseLabel.Text = "Defense";
            // 
            // DefenseNumericBox
            // 
            this.DefenseNumericBox.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DefenseNumericBox.Location = new System.Drawing.Point(265, 48);
            this.DefenseNumericBox.Name = "DefenseNumericBox";
            this.DefenseNumericBox.Size = new System.Drawing.Size(79, 34);
            this.DefenseNumericBox.TabIndex = 15;
            this.DefenseNumericBox.ValueChanged += new System.EventHandler(this.DefenseNumericBox_ValueChanged);
            // 
            // AttackNumericBox
            // 
            this.AttackNumericBox.BackColor = System.Drawing.SystemColors.Window;
            this.AttackNumericBox.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AttackNumericBox.Location = new System.Drawing.Point(146, 48);
            this.AttackNumericBox.Name = "AttackNumericBox";
            this.AttackNumericBox.Size = new System.Drawing.Size(79, 34);
            this.AttackNumericBox.TabIndex = 14;
            this.AttackNumericBox.ValueChanged += new System.EventHandler(this.AttackNumericBox_ValueChanged);
            // 
            // BluePictureBox
            // 
            this.BluePictureBox.BackColor = System.Drawing.Color.Transparent;
            this.BluePictureBox.Image = global::LA_TT.Properties.Resources.Blue;
            this.BluePictureBox.Location = new System.Drawing.Point(256, 40);
            this.BluePictureBox.Name = "BluePictureBox";
            this.BluePictureBox.Size = new System.Drawing.Size(100, 50);
            this.BluePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BluePictureBox.TabIndex = 17;
            this.BluePictureBox.TabStop = false;
            // 
            // NameLabel
            // 
            this.NameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.NameLabel.AutoSize = true;
            this.NameLabel.BackColor = System.Drawing.Color.Transparent;
            this.NameLabel.Location = new System.Drawing.Point(53, 509);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(39, 15);
            this.NameLabel.TabIndex = 13;
            this.NameLabel.Text = "Name";
            // 
            // LevelLabel
            // 
            this.LevelLabel.AutoSize = true;
            this.LevelLabel.BackColor = System.Drawing.Color.Transparent;
            this.LevelLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LevelLabel.Location = new System.Drawing.Point(48, 93);
            this.LevelLabel.Name = "LevelLabel";
            this.LevelLabel.Size = new System.Drawing.Size(46, 21);
            this.LevelLabel.TabIndex = 12;
            this.LevelLabel.Text = "Level";
            // 
            // AttackLabel
            // 
            this.AttackLabel.AutoSize = true;
            this.AttackLabel.BackColor = System.Drawing.Color.Transparent;
            this.AttackLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AttackLabel.Location = new System.Drawing.Point(157, 93);
            this.AttackLabel.Name = "AttackLabel";
            this.AttackLabel.Size = new System.Drawing.Size(53, 21);
            this.AttackLabel.TabIndex = 10;
            this.AttackLabel.Text = "Attack";
            // 
            // LevelNumericBox
            // 
            this.LevelNumericBox.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LevelNumericBox.Location = new System.Drawing.Point(36, 29);
            this.LevelNumericBox.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.LevelNumericBox.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.LevelNumericBox.Name = "LevelNumericBox";
            this.LevelNumericBox.Size = new System.Drawing.Size(72, 61);
            this.LevelNumericBox.TabIndex = 8;
            this.LevelNumericBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.LevelNumericBox.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.LevelNumericBox.ValueChanged += new System.EventHandler(this.LevelNumericBox_ValueChanged);
            // 
            // OrangePictureBox
            // 
            this.OrangePictureBox.BackColor = System.Drawing.Color.Transparent;
            this.OrangePictureBox.Image = global::LA_TT.Properties.Resources.Orange;
            this.OrangePictureBox.InitialImage = null;
            this.OrangePictureBox.Location = new System.Drawing.Point(135, 40);
            this.OrangePictureBox.Name = "OrangePictureBox";
            this.OrangePictureBox.Size = new System.Drawing.Size(100, 50);
            this.OrangePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.OrangePictureBox.TabIndex = 16;
            this.OrangePictureBox.TabStop = false;
            // 
            // ImagePictureBox
            // 
            this.ImagePictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ImagePictureBox.BackColor = System.Drawing.Color.Transparent;
            this.ImagePictureBox.Location = new System.Drawing.Point(36, 29);
            this.ImagePictureBox.Name = "ImagePictureBox";
            this.ImagePictureBox.Size = new System.Drawing.Size(339, 448);
            this.ImagePictureBox.TabIndex = 0;
            this.ImagePictureBox.TabStop = false;
            // 
            // CardPictureBox
            // 
            this.CardPictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CardPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.CardPictureBox.Image = global::LA_TT.Properties.Resources.CardB;
            this.CardPictureBox.Location = new System.Drawing.Point(18, 15);
            this.CardPictureBox.Name = "CardPictureBox";
            this.CardPictureBox.Size = new System.Drawing.Size(372, 530);
            this.CardPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.CardPictureBox.TabIndex = 18;
            this.CardPictureBox.TabStop = false;
            // 
            // CombosToLabel
            // 
            this.CombosToLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.CombosToLabel.AutoSize = true;
            this.CombosToLabel.BackColor = System.Drawing.Color.Transparent;
            this.CombosToLabel.Location = new System.Drawing.Point(624, 91);
            this.CombosToLabel.Name = "CombosToLabel";
            this.CombosToLabel.Size = new System.Drawing.Size(129, 15);
            this.CombosToLabel.TabIndex = 26;
            this.CombosToLabel.Text = "Combos to Card Name";
            // 
            // CombosToCardTextBox
            // 
            this.CombosToCardTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.CombosToCardTextBox.Location = new System.Drawing.Point(624, 109);
            this.CombosToCardTextBox.Name = "CombosToCardTextBox";
            this.CombosToCardTextBox.Size = new System.Drawing.Size(144, 23);
            this.CombosToCardTextBox.TabIndex = 25;
            this.CombosToCardTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.CombosToCardTextBox.TextChanged += new System.EventHandler(this.CombosToCardTextBox_TextChanged);
            // 
            // CombosWithLabel
            // 
            this.CombosWithLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.CombosWithLabel.AutoSize = true;
            this.CombosWithLabel.BackColor = System.Drawing.Color.Transparent;
            this.CombosWithLabel.Location = new System.Drawing.Point(460, 91);
            this.CombosWithLabel.Name = "CombosWithLabel";
            this.CombosWithLabel.Size = new System.Drawing.Size(141, 15);
            this.CombosWithLabel.TabIndex = 24;
            this.CombosWithLabel.Text = "Combos with Card Name";
            // 
            // CombosWithTextBox
            // 
            this.CombosWithTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.CombosWithTextBox.Location = new System.Drawing.Point(460, 109);
            this.CombosWithTextBox.Name = "CombosWithTextBox";
            this.CombosWithTextBox.Size = new System.Drawing.Size(144, 23);
            this.CombosWithTextBox.TabIndex = 23;
            this.CombosWithTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.CombosWithTextBox.TextChanged += new System.EventHandler(this.CombosWithTextBox_TextChanged);
            // 
            // OkButton
            // 
            this.OkButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.OkButton.Location = new System.Drawing.Point(587, 618);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(99, 31);
            this.OkButton.TabIndex = 6;
            this.OkButton.Text = "Add";
            this.OkButton.UseVisualStyleBackColor = true;
            this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelButton.Location = new System.Drawing.Point(692, 618);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(99, 31);
            this.CancelButton.TabIndex = 7;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            // 
            // LeaveOpenCheckBox
            // 
            this.LeaveOpenCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.LeaveOpenCheckBox.AutoSize = true;
            this.LeaveOpenCheckBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LeaveOpenCheckBox.Location = new System.Drawing.Point(411, 620);
            this.LeaveOpenCheckBox.Name = "LeaveOpenCheckBox";
            this.LeaveOpenCheckBox.Size = new System.Drawing.Size(170, 25);
            this.LeaveOpenCheckBox.TabIndex = 27;
            this.LeaveOpenCheckBox.Text = "Leave Window open";
            this.LeaveOpenCheckBox.UseVisualStyleBackColor = true;
            // 
            // AddComboButton
            // 
            this.AddComboButton.Location = new System.Drawing.Point(647, 138);
            this.AddComboButton.Name = "AddComboButton";
            this.AddComboButton.Size = new System.Drawing.Size(121, 33);
            this.AddComboButton.TabIndex = 28;
            this.AddComboButton.Text = "Add Combo";
            this.AddComboButton.UseVisualStyleBackColor = true;
            this.AddComboButton.Click += new System.EventHandler(this.AddComboButton_Click);
            // 
            // ComboCardsListBox
            // 
            this.ComboCardsListBox.FormattingEnabled = true;
            this.ComboCardsListBox.ItemHeight = 15;
            this.ComboCardsListBox.Location = new System.Drawing.Point(460, 177);
            this.ComboCardsListBox.Name = "ComboCardsListBox";
            this.ComboCardsListBox.Size = new System.Drawing.Size(308, 289);
            this.ComboCardsListBox.TabIndex = 29;
            // 
            // ErrorsListBox
            // 
            this.ErrorsListBox.ForeColor = System.Drawing.Color.Red;
            this.ErrorsListBox.FormattingEnabled = true;
            this.ErrorsListBox.ItemHeight = 15;
            this.ErrorsListBox.Location = new System.Drawing.Point(460, 503);
            this.ErrorsListBox.Name = "ErrorsListBox";
            this.ErrorsListBox.Size = new System.Drawing.Size(308, 79);
            this.ErrorsListBox.TabIndex = 30;
            // 
            // ErrorsLabel
            // 
            this.ErrorsLabel.AutoSize = true;
            this.ErrorsLabel.Location = new System.Drawing.Point(460, 485);
            this.ErrorsLabel.Name = "ErrorsLabel";
            this.ErrorsLabel.Size = new System.Drawing.Size(37, 15);
            this.ErrorsLabel.TabIndex = 31;
            this.ErrorsLabel.Text = "Errors";
            // 
            // DeleteComboButton
            // 
            this.DeleteComboButton.Location = new System.Drawing.Point(608, 138);
            this.DeleteComboButton.Name = "DeleteComboButton";
            this.DeleteComboButton.Size = new System.Drawing.Size(33, 33);
            this.DeleteComboButton.TabIndex = 32;
            this.DeleteComboButton.Text = "X";
            this.DeleteComboButton.UseVisualStyleBackColor = true;
            this.DeleteComboButton.Click += new System.EventHandler(this.DeleteComboButton_Click);
            // 
            // InstantSaveCheckBox
            // 
            this.InstantSaveCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.InstantSaveCheckBox.AutoSize = true;
            this.InstantSaveCheckBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.InstantSaveCheckBox.Location = new System.Drawing.Point(292, 618);
            this.InstantSaveCheckBox.Name = "InstantSaveCheckBox";
            this.InstantSaveCheckBox.Size = new System.Drawing.Size(113, 25);
            this.InstantSaveCheckBox.TabIndex = 33;
            this.InstantSaveCheckBox.Text = "Instant Save";
            this.InstantSaveCheckBox.UseVisualStyleBackColor = true;
            // 
            // AddCardForm
            // 
            this.AcceptButton = this.OkButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 661);
            this.Controls.Add(this.InstantSaveCheckBox);
            this.Controls.Add(this.DeleteComboButton);
            this.Controls.Add(this.ErrorsLabel);
            this.Controls.Add(this.ErrorsListBox);
            this.Controls.Add(this.ComboCardsListBox);
            this.Controls.Add(this.AddComboButton);
            this.Controls.Add(this.CombosToLabel);
            this.Controls.Add(this.LeaveOpenCheckBox);
            this.Controls.Add(this.CombosToCardTextBox);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.CombosWithLabel);
            this.Controls.Add(this.CombosWithTextBox);
            this.Controls.Add(this.OkButton);
            this.Controls.Add(this.CardPanel);
            this.MinimumSize = new System.Drawing.Size(700, 700);
            this.Name = "AddCardForm";
            this.ShowInTaskbar = false;
            this.Text = "Little Alchemist - Add Card";
            this.Load += new System.EventHandler(this.AddCardForm_Load);
            this.CardPanel.ResumeLayout(false);
            this.CardPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RarityNumericBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CFPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DefenseNumericBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AttackNumericBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BluePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LevelNumericBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrangePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImagePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CardPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Panel CardPanel;
        private Button OkButton;
        private Button CancelButton;
        private Label NameLabel;
        private Label LevelLabel;
        private Label DefenseLabel;
        private Label AttackLabel;
        public PictureBox ImagePictureBox;
        public TextBox NameTextBox;
        public NumericUpDown LevelNumericBox;
        public NumericUpDown DefenseNumericBox;
        public NumericUpDown AttackNumericBox;
        public PictureBox CardPictureBox;
        public PictureBox CFPictureBox;
        public PictureBox OrangePictureBox;
        public PictureBox BluePictureBox;
        private Label RarityLabel;
        public NumericUpDown RarityNumericBox;
        public CheckBox ComboCardCheckBox;
        private Label CombosWithLabel;
        public TextBox CombosWithTextBox;
        private Label CombosToLabel;
        public TextBox CombosToCardTextBox;
        public CheckBox LeaveOpenCheckBox;
        public Button AddComboButton;
        public ListBox ComboCardsListBox;
        private Label ErrorsLabel;
        public ListBox ErrorsListBox;
        public Button DeleteComboButton;
        public CheckBox InstantSaveCheckBox;
    }
}