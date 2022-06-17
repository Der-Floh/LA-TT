using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LA_TT
{
    public partial class AskForSyncForm : Form
    {
        public AskForSyncForm()
        {
            InitializeComponent();
            DontShowCheckBox.Visible = false;
        }
        public AskForSyncForm(bool showAgainBox)
        {
            InitializeComponent();
            DontShowCheckBox.Visible = showAgainBox;
        }

        private void YesButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Yes;
        }

        private void NoButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.No;
        }

        private void DontShowCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            YesButton.Enabled = !DontShowCheckBox.Checked;
            UserSettings.askForSync = !DontShowCheckBox.Checked;
            if (DontShowCheckBox.Checked)
            {
                UserSettings.sync = false;
            }
            else
            {
                UserSettings.sync = true;
            }
            UserSettings.Save();
        }
    }
}
