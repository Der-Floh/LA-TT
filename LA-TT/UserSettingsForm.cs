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
    public partial class UserSettingsForm : Form
    {
        private bool changed
        {
            get { return changed; }
            set
            {
                SaveButton.Enabled = value;
            }
        }
        public UserSettingsForm()
        {
            InitializeComponent();
        }

        private void SetControlsToSettings()
        {
            AskForSyncCheckBox.Checked = UserSettings.askForSync;
            SaveYourCardsCheckBox.Checked = UserSettings.saveYourCards;
            ComboStatYourCheckBox.Checked = UserSettings.comboSatsYour;
            SkipDownloadCheckBox.Checked = UserSettings.skipDownload;
            DeleteAfterDownloadCheckBox.Checked = UserSettings.deleteAfterDownload;
            PreferAttackCheckBox.Checked = UserSettings.preferAttack;
            PreferDefenseCheckBox.Checked = UserSettings.preferDefense;
            AttackMultiplicatorNumericBox.Value = UserSettings.attackMultiplier;
            DefenseMultiplicatorNumericBox.Value = UserSettings.defenseMultiplier;
            WikiUrlTextBox.Text = UserSettings.wikiUrl;

            changed = false;
        }

        private void UserSettings_Load(object sender, EventArgs e)
        {
            string path = AppDomain.CurrentDomain.BaseDirectory + AppDomain.CurrentDomain.FriendlyName;
            path = path.Replace(@"\", "/");
            path = path.Replace("//", "/") + ".exe";
            Icon = Icon.ExtractAssociatedIcon(path);
            if (!UserSettings.settingsWindowLocation.IsEmpty)
            {
                Location = UserSettings.settingsWindowLocation;
            }
            else
            {
                Form mainForm = Application.OpenForms[0];
                StartPosition = FormStartPosition.Manual;
                Location = new Point((mainForm.Location.X + mainForm.Size.Width / 2) - Size.Width / 2, (mainForm.Location.Y + mainForm.Size.Height / 2) - Size.Height / 2);
            }
            Size = UserSettings.settingsWindowSize;

            ToolTip toolTip = new ToolTip();
            toolTip.AutoPopDelay = 10000;
            toolTip.InitialDelay = 1000;
            toolTip.ReshowDelay = 500;
            toolTip.ShowAlways = true;
            
            toolTip.SetToolTip(AskForSyncCheckBox, "Specifies wether the app asks, on startup,\nif you want to sync Cards with the Wiki");
            toolTip.SetToolTip(SaveYourCardsCheckBox, "Specifies wether the save Cards Action saves\nonly your Cards or also Cards synced with the wiki");
            toolTip.SetToolTip(ComboStatYourCheckBox, "Specifies wether the Calculation of the Combo-Sum\nis based only on your Cards or also on Cards synced with the Wiki");
            toolTip.SetToolTip(SkipDownloadCheckBox, "Specifes wether the Download of Cards from the Wiki\nis skipped if it's still accessable by the program");
            toolTip.SetToolTip(DeleteAfterDownloadCheckBox, "Specifies wether the, for the download needed,\nhtml files get deleted when not needed anymore");
            toolTip.SetToolTip(PreferAttackCheckBox, "Specifies if you prefer the Attack stat");
            toolTip.SetToolTip(AttackMultiplicatorNumericBox, "Specifies the weight of the Attack stat");
            toolTip.SetToolTip(PreferDefenseCheckBox, "Specifies if you prefer the Defense stat");
            toolTip.SetToolTip(DefenseMultiplicatorNumericBox, "Specifies the weight of the Defense stat");
            toolTip.SetToolTip(WikiUrlTextBox, "Speciefies the Wiki Url which is use to sync existing Cards with");

            SetControlsToSettings();
        }

        private void UserSettingsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            UserSettings.settingsWindowLocation = Location;
            UserSettings.settingsWindowSize = Size;
            UserSettings.Save();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void PreferAttackCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (PreferAttackCheckBox.Checked)
            {
                AttackMultiplicatorLabel.Visible = true;
                AttackMultiplicatorNumericBox.Visible = true;

                PreferDefenseCheckBox.Checked = false;
                DefenseMultiplicatorLabel.Visible = false;
                DefenseMultiplicatorNumericBox.Visible = false;
            }
            else
            {
                AttackMultiplicatorNumericBox.Value = 1;
                AttackMultiplicatorLabel.Visible = false;
                AttackMultiplicatorNumericBox.Visible = false;
            }
            changed = true;
        }

        private void PreferDefenseCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (PreferDefenseCheckBox.Checked)
            {
                DefenseMultiplicatorLabel.Visible = true;
                DefenseMultiplicatorNumericBox.Visible = true;

                PreferAttackCheckBox.Checked = false;
                AttackMultiplicatorLabel.Visible = false;
                AttackMultiplicatorNumericBox.Visible = false;
            }
            else
            {
                DefenseMultiplicatorNumericBox.Value = 1;
                DefenseMultiplicatorLabel.Visible = false;
                DefenseMultiplicatorNumericBox.Visible = false;
            }
            changed = true;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            UserSettings.askForSync = AskForSyncCheckBox.Checked;
            UserSettings.saveYourCards = SaveYourCardsCheckBox.Checked;
            UserSettings.comboSatsYour = ComboStatYourCheckBox.Checked;
            UserSettings.skipDownload = SkipDownloadCheckBox.Checked;
            UserSettings.deleteAfterDownload = DeleteAfterDownloadCheckBox.Checked;
            UserSettings.preferAttack = PreferAttackCheckBox.Checked;
            UserSettings.preferDefense = PreferDefenseCheckBox.Checked;
            UserSettings.attackMultiplier = (int)AttackMultiplicatorNumericBox.Value;
            UserSettings.defenseMultiplier = (int)DefenseMultiplicatorNumericBox.Value;
            UserSettings.wikiUrl = WikiUrlTextBox.Text;
            UserSettings.Save();
            changed = false;
            EditWikiUrlButton.Enabled = true;
            WikiUrlTextBox.ReadOnly = true;
        }

        private void AskForSyncCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            changed = true;
        }

        private void SaveYourCardsCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            changed = true;
        }

        private void ComboStatYourCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            changed = true;
        }

        private void SkipDownloadCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (SkipDownloadCheckBox.Checked)
                DeleteAfterDownloadCheckBox.Checked = false;
            changed = true;
        }

        private void EditWikiUrlButton_Click(object sender, EventArgs e)
        {
            EditWikiUrlButton.Enabled = false;
            WikiUrlTextBox.ReadOnly = false;
        }

        private void WikiUrlTextBox_TextChanged(object sender, EventArgs e)
        {
            changed = true;
        }

        private void ResetToDefaultButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("You are about to reset the Settings.\n\nAre you sure you want to continue?", "Reset Settings", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                UserSettings.ResetToDefault();
                UserSettings.Save();
                SetControlsToSettings();
            }
        }

        private void DeleteAfterDownloadCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (DeleteAfterDownloadCheckBox.Checked)
                SkipDownloadCheckBox.Checked = false;
            changed = true;
        }
    }
}
