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
            // 
            // PreferAttackCheckBox
            // 
            this.PreferAttackCheckBox.AutoSize = true;
            this.PreferAttackCheckBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PreferAttackCheckBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.PreferAttackCheckBox.Location = new System.Drawing.Point(55, 147);
            this.PreferAttackCheckBox.Name = "PreferAttackCheckBox";
            this.PreferAttackCheckBox.Size = new System.Drawing.Size(213, 25);
            this.PreferAttackCheckBox.TabIndex = 2;
            this.PreferAttackCheckBox.Text = "Prefer Attack over Defense";
            this.PreferAttackCheckBox.UseVisualStyleBackColor = true;
            // 
            // PreferDefenseCheckBox
            // 
            this.PreferDefenseCheckBox.AutoSize = true;
            this.PreferDefenseCheckBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PreferDefenseCheckBox.Location = new System.Drawing.Point(55, 244);
            this.PreferDefenseCheckBox.Name = "PreferDefenseCheckBox";
            this.PreferDefenseCheckBox.Size = new System.Drawing.Size(213, 25);
            this.PreferDefenseCheckBox.TabIndex = 3;
            this.PreferDefenseCheckBox.Text = "Prefer Defense over Attack";
            this.PreferDefenseCheckBox.UseVisualStyleBackColor = true;
            // 
            // AttackMultiplicatorNumericBox
            // 
            this.AttackMultiplicatorNumericBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AttackMultiplicatorNumericBox.Location = new System.Drawing.Point(231, 178);
            this.AttackMultiplicatorNumericBox.Name = "AttackMultiplicatorNumericBox";
            this.AttackMultiplicatorNumericBox.Size = new System.Drawing.Size(120, 29);
            this.AttackMultiplicatorNumericBox.TabIndex = 4;
            // 
            // AttackMultiplicatorLabel
            // 
            this.AttackMultiplicatorLabel.AutoSize = true;
            this.AttackMultiplicatorLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AttackMultiplicatorLabel.Location = new System.Drawing.Point(124, 180);
            this.AttackMultiplicatorLabel.Name = "AttackMultiplicatorLabel";
            this.AttackMultiplicatorLabel.Size = new System.Drawing.Size(101, 21);
            this.AttackMultiplicatorLabel.TabIndex = 5;
            this.AttackMultiplicatorLabel.Text = "Multiplicator:";
            // 
            // DefenseMultiplicatorLabel
            // 
            this.DefenseMultiplicatorLabel.AutoSize = true;
            this.DefenseMultiplicatorLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DefenseMultiplicatorLabel.Location = new System.Drawing.Point(124, 277);
            this.DefenseMultiplicatorLabel.Name = "DefenseMultiplicatorLabel";
            this.DefenseMultiplicatorLabel.Size = new System.Drawing.Size(101, 21);
            this.DefenseMultiplicatorLabel.TabIndex = 6;
            this.DefenseMultiplicatorLabel.Text = "Multiplicator:";
            // 
            // DefenseMultiplicatorNumericBox
            // 
            this.DefenseMultiplicatorNumericBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DefenseMultiplicatorNumericBox.Location = new System.Drawing.Point(231, 275);
            this.DefenseMultiplicatorNumericBox.Name = "DefenseMultiplicatorNumericBox";
            this.DefenseMultiplicatorNumericBox.Size = new System.Drawing.Size(120, 29);
            this.DefenseMultiplicatorNumericBox.TabIndex = 7;
            // 
            // UserSettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
    }
}