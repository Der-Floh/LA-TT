namespace LA_TT
{
    partial class AskForSyncForm
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
            this.NoButton = new System.Windows.Forms.Button();
            this.YesButton = new System.Windows.Forms.Button();
            this.DontShowCheckBox = new System.Windows.Forms.CheckBox();
            this.SyncTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // NoButton
            // 
            this.NoButton.Location = new System.Drawing.Point(304, 149);
            this.NoButton.Name = "NoButton";
            this.NoButton.Size = new System.Drawing.Size(75, 23);
            this.NoButton.TabIndex = 1;
            this.NoButton.Text = "No";
            this.NoButton.UseVisualStyleBackColor = true;
            this.NoButton.Click += new System.EventHandler(this.NoButton_Click);
            // 
            // YesButton
            // 
            this.YesButton.Location = new System.Drawing.Point(223, 149);
            this.YesButton.Name = "YesButton";
            this.YesButton.Size = new System.Drawing.Size(75, 23);
            this.YesButton.TabIndex = 2;
            this.YesButton.Text = "Yes";
            this.YesButton.UseVisualStyleBackColor = true;
            this.YesButton.Click += new System.EventHandler(this.YesButton_Click);
            // 
            // DontShowCheckBox
            // 
            this.DontShowCheckBox.AutoSize = true;
            this.DontShowCheckBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DontShowCheckBox.Location = new System.Drawing.Point(12, 147);
            this.DontShowCheckBox.Name = "DontShowCheckBox";
            this.DontShowCheckBox.Size = new System.Drawing.Size(179, 25);
            this.DontShowCheckBox.TabIndex = 3;
            this.DontShowCheckBox.Text = "Don\'t show this again";
            this.DontShowCheckBox.UseVisualStyleBackColor = true;
            this.DontShowCheckBox.CheckedChanged += new System.EventHandler(this.DontShowCheckBox_CheckedChanged);
            // 
            // SyncTextBox
            // 
            this.SyncTextBox.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SyncTextBox.Location = new System.Drawing.Point(12, 33);
            this.SyncTextBox.Multiline = true;
            this.SyncTextBox.Name = "SyncTextBox";
            this.SyncTextBox.ReadOnly = true;
            this.SyncTextBox.Size = new System.Drawing.Size(367, 73);
            this.SyncTextBox.TabIndex = 4;
            this.SyncTextBox.Text = "Do you want to sync all \r\nCards with the Wiki?";
            this.SyncTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // AskForSyncForm
            // 
            this.AcceptButton = this.YesButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.NoButton;
            this.ClientSize = new System.Drawing.Size(391, 184);
            this.Controls.Add(this.SyncTextBox);
            this.Controls.Add(this.DontShowCheckBox);
            this.Controls.Add(this.YesButton);
            this.Controls.Add(this.NoButton);
            this.Name = "AskForSyncForm";
            this.Text = "Sync";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button NoButton;
        private Button YesButton;
        private CheckBox DontShowCheckBox;
        private TextBox SyncTextBox;
    }
}