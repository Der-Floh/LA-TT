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
    public partial class AddCardForm : Form
    {
        public AddCardForm()
        {
            InitializeComponent();
        }

        private void RarityNumericBox_ValueChanged(object sender, EventArgs e)
        {
            switch (RarityNumericBox.Value)
            {
                case 1: CardPictureBox.Image = LA_TT.Properties.Resources.CardB; break;
                case 2: CardPictureBox.Image = LA_TT.Properties.Resources.CardS; break;
                case 3: CardPictureBox.Image = LA_TT.Properties.Resources.CardG; break;
                case 4: CardPictureBox.Image = LA_TT.Properties.Resources.CardD; break; //Image.FromFile("Resources/CardD.png");;
            }
        }

        private void ComboCardCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (ComboCardCheckBox.Checked)
            {
                CFPictureBox.Image = LA_TT.Properties.Resources.C;
            }
            else
            {
                CFPictureBox.Image = LA_TT.Properties.Resources.F;
            }
        }
    }
}
