namespace LA_TT
{
    partial class LoadingForm
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
            this.BottomLoadingBar = new System.Windows.Forms.ProgressBar();
            this.TopLoadingBar = new System.Windows.Forms.ProgressBar();
            this.TopLoadingBarLabel = new System.Windows.Forms.Label();
            this.BottomLoadingBarLabel = new System.Windows.Forms.Label();
            this.HeaderLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BottomLoadingBar
            // 
            this.BottomLoadingBar.Location = new System.Drawing.Point(38, 159);
            this.BottomLoadingBar.Name = "BottomLoadingBar";
            this.BottomLoadingBar.Size = new System.Drawing.Size(381, 23);
            this.BottomLoadingBar.TabIndex = 0;
            // 
            // TopLoadingBar
            // 
            this.TopLoadingBar.Location = new System.Drawing.Point(38, 93);
            this.TopLoadingBar.Name = "TopLoadingBar";
            this.TopLoadingBar.Size = new System.Drawing.Size(381, 23);
            this.TopLoadingBar.TabIndex = 1;
            // 
            // TopLoadingBarLabel
            // 
            this.TopLoadingBarLabel.AutoSize = true;
            this.TopLoadingBarLabel.Location = new System.Drawing.Point(38, 75);
            this.TopLoadingBarLabel.Name = "TopLoadingBarLabel";
            this.TopLoadingBarLabel.Size = new System.Drawing.Size(38, 15);
            this.TopLoadingBarLabel.TabIndex = 2;
            this.TopLoadingBarLabel.Text = "label1";
            // 
            // BottomLoadingBarLabel
            // 
            this.BottomLoadingBarLabel.AutoSize = true;
            this.BottomLoadingBarLabel.Location = new System.Drawing.Point(38, 141);
            this.BottomLoadingBarLabel.Name = "BottomLoadingBarLabel";
            this.BottomLoadingBarLabel.Size = new System.Drawing.Size(38, 15);
            this.BottomLoadingBarLabel.TabIndex = 3;
            this.BottomLoadingBarLabel.Text = "label2";
            // 
            // HeaderLabel
            // 
            this.HeaderLabel.AutoSize = true;
            this.HeaderLabel.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.HeaderLabel.Location = new System.Drawing.Point(12, 9);
            this.HeaderLabel.Name = "HeaderLabel";
            this.HeaderLabel.Size = new System.Drawing.Size(220, 28);
            this.HeaderLabel.TabIndex = 4;
            this.HeaderLabel.Text = "Syncing Cards with Wiki";
            this.HeaderLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LoadingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 215);
            this.Controls.Add(this.HeaderLabel);
            this.Controls.Add(this.BottomLoadingBarLabel);
            this.Controls.Add(this.TopLoadingBarLabel);
            this.Controls.Add(this.TopLoadingBar);
            this.Controls.Add(this.BottomLoadingBar);
            this.MaximumSize = new System.Drawing.Size(488, 254);
            this.MinimumSize = new System.Drawing.Size(488, 254);
            this.Name = "LoadingForm";
            this.Text = "LoadingForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public ProgressBar BottomLoadingBar;
        public ProgressBar TopLoadingBar;
        public Label TopLoadingBarLabel;
        public Label BottomLoadingBarLabel;
        public Label HeaderLabel;
    }
}