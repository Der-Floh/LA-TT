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
                CombosWithLabel.Text = "Combos with Card Name";
                CombosToLabel.Text = "Combos to Card Name";
            }
            else
            {
                CFPictureBox.Image = LA_TT.Properties.Resources.F;
                CombosWithLabel.Text = "Combos with Card 1 Name";
                CombosToLabel.Text = "Combos with Card 2 Name";
            }
        }

        private void AddCardForm_Load(object sender, EventArgs e)
        {
            AttackNumericBox.BackColor = Color.FromArgb(255, 102, 0);
            DefenseNumericBox.BackColor = Color.FromArgb(0, 101, 204);
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            if (ComboCardCheckBox.Checked)
            {
                CCard ccard = new CCard();
                ccard.name = NameTextBox.Text;
                ccard.rarity = (byte)RarityNumericBox.Value;

                bool continued = false;
                if (ccard.name == "")
                {
                    MessageBox.Show("Cardname is empty", "Save Card Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    DialogResult = DialogResult.None;
                    return;
                }
                if (Cards.GetCCard(ccard.name, ccard.rarity) != null)
                {
                    MessageBox.Show("Cardname already exists", "Save Card Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    DialogResult = DialogResult.None;
                    return;
                }

                CCard ccard2 = Cards.GetCCard(CombosWithTextBox.Text);
                FCard fcard = Cards.GetFCard(CombosToCardTextBox.Text);

                CCard cfcard = null;
                if (fcard == null)
                {
                    cfcard = Cards.GetCCard(CombosToCardTextBox.Text);
                    if (cfcard == null)
                    {
                        if (MessageBox.Show("Combo Cards do not exist.\n\nAre you sure you want to continue?", "Save Card Error", MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.No)
                        {
                            DialogResult = DialogResult.None;
                            return;
                        }
                        continued = true;

                    }
                    if (!continued)
                    {
                        DialogResult = DialogResult.None;
                    }
                }
                else
                {
                    ccard.combos.Add(ccard2, fcard);
                }

                if (!continued && (ccard2 == null || ccard.combos[ccard2] == null))
                {
                    if (MessageBox.Show("Combo Cards do not exist.\n\nAre you sure you want to continue?", "Save Card Error", MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.No)
                    {
                        DialogResult = DialogResult.None;
                        return;
                    }
                    continued = true;
                }
                DialogResult = DialogResult.OK;
            }
            else
            {
                FCard fcard = new FCard();
                fcard.name = NameTextBox.Text;
                fcard.rarity = (byte)RarityNumericBox.Value;

                if (fcard.name == "")
                {
                    MessageBox.Show("Cardname is empty", "Save Card Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    DialogResult = DialogResult.None;
                    return;
                }
                if (Cards.GetCCard(fcard.name, fcard.rarity) != null)
                {
                    MessageBox.Show("Cardname already exists", "Save Card Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    DialogResult = DialogResult.None;
                    return;
                }

                CCard ccard1 = Cards.GetCCard(CombosWithTextBox.Text);
                CCard ccard2 = Cards.GetCCard(CombosToCardTextBox.Text);

                if (ccard1 == null || ccard2 == null)
                {
                    if (MessageBox.Show("Combo Cards do not exist.\n\nAre you sure you want to continue?", "Save Card Error", MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.No)
                    {
                        DialogResult = DialogResult.None;
                        return;
                    }
                }
                else
                {
                    fcard.comboCards.Add(ccard1, ccard2);
                }
                DialogResult = DialogResult.OK;
            }
            if (LeaveOpenCheckBox.Checked)
            {
                NameTextBox.Text = "";
                CombosWithTextBox.Text = "";
                CombosToCardTextBox.Text = "";
                AttackNumericBox.Value = 0;
                DefenseNumericBox.Value = 0;
                LevelNumericBox.Value = 1;
                RarityNumericBox.Value = 1;
                DialogResult = DialogResult.None;
            }

            AddCard();
        }
        private void AddCard()
        {
            if (ComboCardCheckBox.Checked)
            {
                CCard ccard = new CCard();
                ccard.name = NameTextBox.Text;
                ccard.level = (byte)LevelNumericBox.Value;
                ccard.attack = (byte)AttackNumericBox.Value;
                ccard.defense = (byte)DefenseNumericBox.Value;
                ccard.rarity = (byte)RarityNumericBox.Value;
                ccard.image = ImagePictureBox.Image;

                FCard fcard = Cards.GetFCard(CombosToCardTextBox.Text);

                if (fcard == null)
                {
                    CCard cfcard = Cards.GetCCard(CombosToCardTextBox.Text);
                    try
                    {
                        ccard.combos.Add(Cards.GetCCard(CombosWithTextBox.Text), cfcard);
                    }
                    catch (Exception) { }
                }
                else
                {
                    ccard.combos.Add(Cards.GetCCard(CombosWithTextBox.Text), fcard);
                }

                Cards.AddCCard(ccard);
            }
            else
            {
                FCard fcard = new FCard();
                fcard.name = NameTextBox.Text;
                fcard.level = (byte)LevelNumericBox.Value;
                fcard.attack = (byte)AttackNumericBox.Value;
                fcard.defense = (byte)DefenseNumericBox.Value;
                fcard.rarity = (byte)RarityNumericBox.Value;
                fcard.image = ImagePictureBox.Image;

                try
                {
                    fcard.comboCards.Add(Cards.GetCCard(CombosWithTextBox.Text), Cards.GetCCard(CombosToCardTextBox.Text));
                }
                catch (Exception) { }

                Cards.AddFCard(fcard);
            }
        }
    }
}
