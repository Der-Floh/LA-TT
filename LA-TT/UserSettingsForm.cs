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
            Location = UserSettings.settingsWindowLocation;
            Size = UserSettings.settingsWindowSize;

            AskForSyncCheckBox.Checked = UserSettings.askForSync;
            SaveYourCardsCheckBox.Checked = UserSettings.saveYourCards;
            ComboStatYourCheckBox.Checked = UserSettings.comboSatsYour;
            SkipDownloadCheckBox.Checked = UserSettings.skipDownload;
            PreferAttackCheckBox.Checked = UserSettings.preferAttack;
            PreferDefenseCheckBox.Checked = UserSettings.preferDefense;
            AttackMultiplicatorNumericBox.Value = UserSettings.attackMultiplier;
            DefenseMultiplicatorNumericBox.Value = UserSettings.defenseMultiplier;
            WikiUrlTextBox.Text = UserSettings.wikiUrl;

            changed = false;
        }

        private void UserSettings_Load(object sender, EventArgs e)
        {
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
    }
}
