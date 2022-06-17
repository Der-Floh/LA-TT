namespace LA_TT
{
    partial class UserSettingsForm
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
            this.CancelButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.PreferAttackCheckBox = new System.Windows.Forms.CheckBox();
            this.PreferDefenseCheckBox = new System.Windows.Forms.CheckBox();
            this.AttackMultiplicatorNumericBox = new System.Windows.Forms.NumericUpDown();
            this.AttackMultiplicatorLabel = new System.Windows.Forms.Label();
            this.DefenseMultiplicatorLabel = new System.Windows.Forms.Label();
            this.DefenseMultiplicatorNumericBox = new System.Windows.Forms.NumericUpDown();
            this.AskForSyncCheckBox = new System.Windows.Forms.CheckBox();
            this.SaveYourCardsCheckBox = new System.Windows.Forms.CheckBox();
            this.ComboStatYourCheckBox = new System.Windows.Forms.CheckBox();
            this.SkipDownloadCheckBox = new System.Windows.Forms.CheckBox();
            this.WikiUrlTextBox = new System.Windows.Forms.TextBox();
            this.WikiUrlLabel = new System.Windows.Forms.Label();
            this.EditWikiUrlButton = new System.Windows.Forms.Button();
            this.ResetToDefaultButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.AttackMultiplicatorNumericBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DefenseMultiplicatorNumericBox)).BeginInit();
            this.SuspendLayout();
            // 
            // CancelButton
            // 
            this.CancelButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CancelButton.Location = new System.Drawing.Point(685, 398);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(103, 40);
            this.CancelButton.TabIndex = 0;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SaveButton.Location = new System.Drawing.Point(576, 398);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(103, 40);
            this.SaveButton.TabIndex = 1;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // PreferAttackCheckBox
            // 
            this.PreferAttackCheckBox.AutoSize = true;
            this.PreferAttackCheckBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PreferAttackCheckBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.PreferAttackCheckBox.Location = new System.Drawing.Point(499, 86);
            this.PreferAttackCheckBox.Name = "PreferAttackCheckBox";
            this.PreferAttackCheckBox.Size = new System.Drawing.Size(213, 25);
            this.PreferAttackCheckBox.TabIndex = 2;
            this.PreferAttackCheckBox.Text = "Prefer Attack over Defense";
            this.PreferAttackCheckBox.UseVisualStyleBackColor = true;
            this.PreferAttackCheckBox.CheckedChanged += new System.EventHandler(this.PreferAttackCheckBox_CheckedChanged);
            // 
            // PreferDefenseCheckBox
            // 
            this.PreferDefenseCheckBox.AutoSize = true;
            this.PreferDefenseCheckBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PreferDefenseCheckBox.Location = new System.Drawing.Point(499, 183);
            this.PreferDefenseCheckBox.Name = "PreferDefenseCheckBox";
            this.PreferDefenseCheckBox.Size = new System.Drawing.Size(213, 25);
            this.PreferDefenseCheckBox.TabIndex = 3;
            this.PreferDefenseCheckBox.Text = "Prefer Defense over Attack";
            this.PreferDefenseCheckBox.UseVisualStyleBackColor = true;
            this.PreferDefenseCheckBox.CheckedChanged += new System.EventHandler(this.PreferDefenseCheckBox_CheckedChanged);
            // 
            // AttackMultiplicatorNumericBox
            // 
            this.AttackMultiplicatorNumericBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AttackMultiplicatorNumericBox.Location = new System.Drawing.Point(654, 119);
            this.AttackMultiplicatorNumericBox.Name = "AttackMultiplicatorNumericBox";
            this.AttackMultiplicatorNumericBox.Size = new System.Drawing.Size(120, 29);
            this.AttackMultiplicatorNumericBox.TabIndex = 4;
            // 
            // AttackMultiplicatorLabel
            // 
            this.AttackMultiplicatorLabel.AutoSize = true;
            this.AttackMultiplicatorLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AttackMultiplicatorLabel.Location = new System.Drawing.Point(568, 119);
            this.AttackMultiplicatorLabel.Name = "AttackMultiplicatorLabel";
            this.AttackMultiplicatorLabel.Size = new System.Drawing.Size(80, 21);
            this.AttackMultiplicatorLabel.TabIndex = 5;
            this.AttackMultiplicatorLabel.Text = "Multiplier:";
            // 
            // DefenseMultiplicatorLabel
            // 
            this.DefenseMultiplicatorLabel.AutoSize = true;
            this.DefenseMultiplicatorLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DefenseMultiplicatorLabel.Location = new System.Drawing.Point(568, 216);
            this.DefenseMultiplicatorLabel.Name = "DefenseMultiplicatorLabel";
            this.DefenseMultiplicatorLabel.Size = new System.Drawing.Size(80, 21);
            this.DefenseMultiplicatorLabel.TabIndex = 6;
            this.DefenseMultiplicatorLabel.Text = "Multiplier:";
            // 
            // DefenseMultiplicatorNumericBox
            // 
            this.DefenseMultiplicatorNumericBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DefenseMultiplicatorNumericBox.Location = new System.Drawing.Point(654, 214);
            this.DefenseMultiplicatorNumericBox.Name = "DefenseMultiplicatorNumericBox";
            this.DefenseMultiplicatorNumericBox.Size = new System.Drawing.Size(120, 29);
            this.DefenseMultiplicatorNumericBox.TabIndex = 7;
            // 
            // AskForSyncCheckBox
            // 
            this.AskForSyncCheckBox.AutoSize = true;
            this.AskForSyncCheckBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AskForSyncCheckBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.AskForSyncCheckBox.Location = new System.Drawing.Point(48, 85);
            this.AskForSyncCheckBox.Name = "AskForSyncCheckBox";
            this.AskForSyncCheckBox.Size = new System.Drawing.Size(174, 25);
            this.AskForSyncCheckBox.TabIndex = 8;
            this.AskForSyncCheckBox.Text = "On Start ask for Sync";
            this.AskForSyncCheckBox.UseVisualStyleBackColor = true;
            this.AskForSyncCheckBox.CheckedChanged += new System.EventHandler(this.AskForSyncCheckBox_CheckedChanged);
            // 
            // SaveYourCardsCheckBox
            // 
            this.SaveYourCardsCheckBox.AutoSize = true;
            this.SaveYourCardsCheckBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SaveYourCardsCheckBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.SaveYourCardsCheckBox.Location = new System.Drawing.Point(48, 136);
            this.SaveYourCardsCheckBox.Name = "SaveYourCardsCheckBox";
            this.SaveYourCardsCheckBox.Size = new System.Drawing.Size(177, 25);
            this.SaveYourCardsCheckBox.TabIndex = 9;
            this.SaveYourCardsCheckBox.Text = "Only save your Cards";
            this.SaveYourCardsCheckBox.UseVisualStyleBackColor = true;
            this.SaveYourCardsCheckBox.CheckedChanged += new System.EventHandler(this.SaveYourCardsCheckBox_CheckedChanged);
            // 
            // ComboStatYourCheckBox
            // 
            this.ComboStatYourCheckBox.AutoSize = true;
            this.ComboStatYourCheckBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ComboStatYourCheckBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ComboStatYourCheckBox.Location = new System.Drawing.Point(48, 190);
            this.ComboStatYourCheckBox.Name = "ComboStatYourCheckBox";
            this.ComboStatYourCheckBox.Size = new System.Drawing.Size(335, 25);
            this.ComboStatYourCheckBox.TabIndex = 10;
            this.ComboStatYourCheckBox.Text = "Use your Cards for Best Combos Calculation";
            this.ComboStatYourCheckBox.UseVisualStyleBackColor = true;
            this.ComboStatYourCheckBox.CheckedChanged += new System.EventHandler(this.ComboStatYourCheckBox_CheckedChanged);
            // 
            // SkipDownloadCheckBox
            // 
            this.SkipDownloadCheckBox.AutoSize = true;
            this.SkipDownloadCheckBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SkipDownloadCheckBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.SkipDownloadCheckBox.Location = new System.Drawing.Point(48, 245);
            this.SkipDownloadCheckBox.Name = "SkipDownloadCheckBox";
            this.SkipDownloadCheckBox.Size = new System.Drawing.Size(267, 25);
            this.SkipDownloadCheckBox.TabIndex = 11;
            this.SkipDownloadCheckBox.Text = "Skip download if file already exists";
            this.SkipDownloadCheckBox.UseVisualStyleBackColor = true;
            this.SkipDownloadCheckBox.CheckedChanged += new System.EventHandler(this.SkipDownloadCheckBox_CheckedChanged);
            // 
            // WikiUrlTextBox
            // 
            this.WikiUrlTextBox.Location = new System.Drawing.Point(129, 322);
            this.WikiUrlTextBox.Name = "WikiUrlTextBox";
            this.WikiUrlTextBox.ReadOnly = true;
            this.WikiUrlTextBox.Size = new System.Drawing.Size(443, 23);
            this.WikiUrlTextBox.TabIndex = 12;
            this.WikiUrlTextBox.TextChanged += new System.EventHandler(this.WikiUrlTextBox_TextChanged);
            // 
            // WikiUrlLabel
            // 
            this.WikiUrlLabel.AutoSize = true;
            this.WikiUrlLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.WikiUrlLabel.Location = new System.Drawing.Point(129, 304);
            this.WikiUrlLabel.Name = "WikiUrlLabel";
            this.WikiUrlLabel.Size = new System.Drawing.Size(48, 15);
            this.WikiUrlLabel.TabIndex = 13;
            this.WikiUrlLabel.Text = "Wiki Url";
            // 
            // EditWikiUrlButton
            // 
            this.EditWikiUrlButton.Location = new System.Drawing.Point(48, 321);
            this.EditWikiUrlButton.Name = "EditWikiUrlButton";
            this.EditWikiUrlButton.Size = new System.Drawing.Size(75, 23);
            this.EditWikiUrlButton.TabIndex = 14;
            this.EditWikiUrlButton.Text = "Edit";
            this.EditWikiUrlButton.UseVisualStyleBackColor = true;
            this.EditWikiUrlButton.Click += new System.EventHandler(this.EditWikiUrlButton_Click);
            // 
            // ResetToDefaultButton
            // 
            this.ResetToDefaultButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ResetToDefaultButton.Location = new System.Drawing.Point(12, 398);
            this.ResetToDefaultButton.Name = "ResetToDefaultButton";
            this.ResetToDefaultButton.Size = new System.Drawing.Size(165, 40);
            this.ResetToDefaultButton.TabIndex = 15;
            this.ResetToDefaultButton.Text = "Reset to Default";
            this.ResetToDefaultButton.UseVisualStyleBackColor = true;
            this.ResetToDefaultButton.Click += new System.EventHandler(this.ResetToDefaultButton_Click);
            // 
            // UserSettingsForm
            // 
            this.AcceptButton = this.SaveButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CancelButton;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ResetToDefaultButton);
            this.Controls.Add(this.EditWikiUrlButton);
            this.Controls.Add(this.WikiUrlLabel);
            this.Controls.Add(this.WikiUrlTextBox);
            this.Controls.Add(this.SkipDownloadCheckBox);
            this.Controls.Add(this.ComboStatYourCheckBox);
            this.Controls.Add(this.SaveYourCardsCheckBox);
            this.Controls.Add(this.AskForSyncCheckBox);
            this.Controls.Add(this.DefenseMultiplicatorNumericBox);
            this.Controls.Add(this.DefenseMultiplicatorLabel);
            this.Controls.Add(this.AttackMultiplicatorLabel);
            this.Controls.Add(this.AttackMultiplicatorNumericBox);
            this.Controls.Add(this.PreferDefenseCheckBox);
            this.Controls.Add(this.PreferAttackCheckBox);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.CancelButton);
            this.Name = "UserSettingsForm";
            this.Text = "Settings";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.UserSettingsForm_FormClosing);
            this.Load += new System.EventHandler(this.UserSettings_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AttackMultiplicatorNumericBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DefenseMultiplicatorNumericBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button CancelButton;
        private Button SaveButton;
        private CheckBox PreferAttackCheckBox;
        private CheckBox PreferDefenseCheckBox;
        private NumericUpDown AttackMultiplicatorNumericBox;
        private Label AttackMultiplicatorLabel;
        private Label DefenseMultiplicatorLabel;
        private NumericUpDown DefenseMultiplicatorNumericBox;
        private CheckBox AskForSyncCheckBox;
        private CheckBox SaveYourCardsCheckBox;
        private CheckBox ComboStatYourCheckBox;
        private CheckBox SkipDownloadCheckBox;
        private TextBox WikiUrlTextBox;
        private Label WikiUrlLabel;
        private Button EditWikiUrlButton;
        private Button ResetToDefaultButton;
    }
}