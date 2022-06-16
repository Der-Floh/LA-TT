﻿using System;
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
        public UserSettingsForm()
        {
            InitializeComponent();
        }

        private void UserSettings_Load(object sender, EventArgs e)
        {
            Location = UserSettings.settingsWindowLocation;
            Size = UserSettings.settingsWindowSize;
        }

        private void UserSettingsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            UserSettings.settingsWindowLocation = Location;
            UserSettings.settingsWindowSize = Size;
            UserSettings.Save();
        }
    }
}
