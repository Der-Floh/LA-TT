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
        private int comboId;
        private List<CCombo> _ccombos;
        private List<FCombo> _fcombos;
        private CCard _ccard;
        private FCard _fcard;

        private byte combosWithRarity;
        private byte combosToRarity;

        private bool combosWithExists;
        private bool combosToExists;
        private bool cardExists;
        private bool cardExisted;
        private bool cardNameEmpty;
        private bool card3FCard;
        private byte oldLevel;
        private int calcedAttack;
        private int calcedDefense;
        public AddCardForm()
        {
            InitializeComponent();
            cardNameEmpty = true;
            comboId = 0;
            _ccard = new CCard();
            _fcard = new FCard();
            _ccombos = new List<CCombo>();
            _fcombos = new List<FCombo>();

            _ccard.rarity = (byte)RarityNumericBox.Value;
            _ccard.level = (byte)LevelNumericBox.Value;

            _fcard.rarity = (byte)RarityNumericBox.Value;
            _ccard.level = (byte)LevelNumericBox.Value;
            UpdateErrorsListBox();
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
            CalcedAttackTextBox.BackColor = Color.FromArgb(255, 102, 0);
            CalcedDefenseTextBox.BackColor = Color.FromArgb(0, 101, 204);
        }
        
        private void OkButton_Click(object sender, EventArgs e)
        {
            AddCard();
            DialogResult = DialogResult.OK;
            if (LeaveOpenCheckBox.Checked)
            {
                NameTextBox.Text = "";
                CombosWithTextBox.Text = "";
                CombosToCardTextBox.Text = "";
                AttackNumericBox.Value = 0;
                DefenseNumericBox.Value = 0;
                LevelNumericBox.Value = 1;
                RarityNumericBox.Value = 1;
                
                cardNameEmpty = true;
                comboId = 0;
                _ccard = new CCard();
                _fcard = new FCard();
                _ccombos = new List<CCombo>();
                _fcombos = new List<FCombo>();

                _ccard.rarity = (byte)RarityNumericBox.Value;
                _ccard.level = (byte)LevelNumericBox.Value;

                _fcard.rarity = (byte)RarityNumericBox.Value;
                _ccard.level = (byte)LevelNumericBox.Value;

                UpdateComboCardsListBox();
                UpdateErrorsListBox();

                DialogResult = DialogResult.None;
            }
        }
        private void AddCard()
        {
            if (ComboCardCheckBox.Checked)
            {
                _ccard.combos = _ccombos;
                _ccard.attack = (byte)calcedAttack;
                _ccard.defense = (byte)calcedDefense;
                if (AddOwnCardCheckBox.Checked)
                {
                    Cards.AddYourCCard(_ccard);
                }
                else
                {
                    Cards.AddCCard(_ccard);
                }
            }
            else
            {
                _fcard.comboCards = _fcombos;
                _fcard.attack = (byte)calcedAttack;
                _fcard.defense = (byte)calcedDefense;
                if (AddOwnCardCheckBox.Checked)
                {
                    Cards.AddYourFCard(_fcard);
                }
                else
                {
                    Cards.AddFCard(_fcard);
                }
            }

            if (InstantSaveCheckBox.Checked)
            {
                if (ComboCardCheckBox.Checked)
                {
                    Cards.WriteCCards(true, _ccard.rarity);
                    Cards.WriteCCards(false, _ccard.rarity);
                }
                else
                {
                    Cards.WriteFCards(true, _fcard.rarity);
                    Cards.WriteFCards(false, _fcard.rarity);
                }
            }
        }

        private void AddComboToComboCardsListBox(CCombo combo)
        {
            ComboCardsListBox.Items.Add(_ccard.name+ " (this) + " +combo.ccard2Name+ " = "+ combo.card3Name);
        }
        private void AddComboToComboCardsListBox(FCombo combo)
        {
            ComboCardsListBox.Items.Add(combo.ccard1Name + " + " + combo.ccard2Name + " = " +_fcard.name+ " (this)");
        }
        private void UpdateComboCardsListBox()
        {
            if (ComboCardCheckBox.Checked)
            {
                ComboCardsListBox.Items.Clear();
                if (_ccombos.Count == 0) return;
                foreach (CCombo combo in _ccombos)
                {
                    ComboCardsListBox.Items.Add(_ccard.name + " (this) + " + combo.ccard2Name + " = " + combo.card3Name);
                }
            }
            else
            {
                ComboCardsListBox.Items.Clear();
                if (_fcombos.Count == 0) return;
                foreach (FCombo combo in _fcombos)
                {
                    ComboCardsListBox.Items.Add(combo.ccard1Name + " + " + combo.ccard2Name + " = " + _fcard.name + " (this)");
                }
            }
        }
        private void UpdateErrorsListBox()
        {
            ErrorsListBox.Items.Clear();
            if (!combosWithExists && ComboCardsListBox.Items.Count == 0)
            {
                string CombosWithText = CombosWithTextBox.Text;
                if (CombosWithText == "") CombosWithText = "empty";
                ErrorsListBox.Items.Add("Combo Card: '" + CombosWithText + "' doesn't exist.");
            }
            if (!combosToExists && ComboCardsListBox.Items.Count == 0)
            {
                string CombosToText = CombosToCardTextBox.Text;
                if (CombosToText == "") CombosToText = "empty";
                ErrorsListBox.Items.Add("Combo Card: '" + CombosToText + "' doesn't exist.");
            }
            if (cardNameEmpty)
            {
                ErrorsListBox.Items.Add("Cardname is empty.");
            }
            if (cardExists)
            {
                string nameText = NameTextBox.Text;
                if (nameText == "") nameText = "empty";
                ErrorsListBox.Items.Add("Cardname: '" + nameText + "' already exists.");
            }
        }

        private void AddComboButton_Click(object sender, EventArgs e)
        {
            if (ComboCardCheckBox.Checked)
            {
                if (cardNameEmpty)
                {
                    MessageBox.Show("Cardname is Empty. Can't add combo to card.", "Save Card Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (cardExists)
                {
                    MessageBox.Show("Cardname already exists. Can't add combo to card: '"+ _ccard.name+ "'", "Save Card Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (!combosWithExists || !combosToExists)
                {
                    if (MessageBox.Show("Combo Cards do not exist.\n\nAre you sure you want to continue?", "Save Card Error", MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.No)
                    {
                        return;
                    }
                }
                CCombo combo = new CCombo();
                combo.id = comboId;
                combo.ccard2Name = CombosWithTextBox.Text;
                combo.card3Name = CombosToCardTextBox.Text;
                combo.card3FCard = card3FCard;
                combo.ccard2Rarity = combosWithRarity;
                combo.card3Rarity = combosToRarity;

                _ccombos.Add(combo);
                AddComboToComboCardsListBox(combo);
            }
            else
            {
                if (cardNameEmpty)
                {
                    MessageBox.Show("Cardname is Empty. Can't add combo to card.", "Save Card Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (cardExists)
                {
                    MessageBox.Show("Cardname already exists. Can't add combo to card: '" + _fcard.name+ "'", "Save Card Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (!combosWithExists || !combosToExists)
                {
                    if (MessageBox.Show("Combo Cards do not exist.\n\nAre you sure you want to continue?", "Save Card Error", MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.No)
                    {
                        return;
                    }
                }
                FCombo combo = new FCombo();
                combo.id = comboId;
                combo.ccard1Name = CombosWithTextBox.Text;
                combo.ccard2Name = CombosToCardTextBox.Text;
                combo.ccard1Rarity = combosWithRarity;
                combo.ccard2Rarity = combosToRarity;

                _fcombos.Add(combo);
                AddComboToComboCardsListBox(combo);
            }
            comboId++;
            CombosWithTextBox.Text = "";
            CombosToCardTextBox.Text = "";
        }

        private void AttackNumericBox_ValueChanged(object sender, EventArgs e)
        {
            if (ComboCardCheckBox.Checked)
            {
                _ccard.attack = (byte)AttackNumericBox.Value;
            }
            else
            {
                _fcard.attack = (byte)AttackNumericBox.Value;
            }
            UpdateValueDisplay();
        }

        private void DefenseNumericBox_ValueChanged(object sender, EventArgs e)
        {
            if (ComboCardCheckBox.Checked)
            {
                _ccard.defense = (byte)DefenseNumericBox.Value;
            }
            else
            {
                _fcard.defense = (byte)DefenseNumericBox.Value;
            }
            UpdateValueDisplay();
        }

        private void LevelNumericBox_ValueChanged(object sender, EventArgs e)
        {
            if (ComboCardCheckBox.Checked)
            {
                _ccard.level = (byte)LevelNumericBox.Value;
            }
            else
            {
                _fcard.level = (byte)LevelNumericBox.Value;
            }
            UpdateValueDisplay();
        }

        private void CalcNewStats()
        {
            if (ComboCardCheckBox.Checked)
            {
                switch (_ccard.rarity)
                {
                    case 1:
                        calcedAttack = _ccard.attack + (_ccard.level - 1);
                        calcedDefense = _ccard.defense + (_ccard.level - 1);
                        break;
                    case 2:
                        calcedAttack = _ccard.attack + (_ccard.level - 1) * 2;
                        calcedDefense = _ccard.defense + (_ccard.level - 1) * 2;
                        break;
                    case 3:
                        calcedAttack = _ccard.attack + (_ccard.level - 1) * 3;
                        calcedDefense = _ccard.defense + (_ccard.level - 1) * 3;
                        break;
                    case 4:
                        calcedAttack = _ccard.attack + (_ccard.level - 1) * 4;
                        calcedDefense = _ccard.defense + (_ccard.level - 1) * 4;
                        break;
                    case 5:
                        calcedAttack = _ccard.attack + (_ccard.level - 1) * 4;
                        calcedDefense = _ccard.defense + (_ccard.level - 1) * 4;
                        break;
                }
            }
            else
            {
                switch (_fcard.rarity)
                {
                    case 1:
                        calcedAttack = _fcard.attack + (_fcard.level - 1);
                        calcedDefense = _fcard.defense + (_fcard.level - 1);
                        break;
                    case 2:
                        calcedAttack = _fcard.attack + (_fcard.level - 1) * 2;
                        calcedDefense = _fcard.defense + (_fcard.level - 1) * 2;
                        break;
                    case 3:
                        calcedAttack = _fcard.attack + (_fcard.level - 1) * 3;
                        calcedDefense = _fcard.defense + (_fcard.level - 1) * 3;
                        break;
                    case 4:
                        calcedAttack = _fcard.attack + (_fcard.level - 1) * 4;
                        calcedDefense = _fcard.defense + (_fcard.level - 1) * 4;
                        break;
                    case 5:
                        calcedAttack = _fcard.attack + (_fcard.level - 1) * 4;
                        calcedDefense = _fcard.defense + (_fcard.level - 1) * 4;
                        break;
                }
            }
        }
        private void RarityNumericBox_ValueChanged(object sender, EventArgs e)
        {
            if (ComboCardCheckBox.Checked)
            {
                _ccard.rarity = (byte)RarityNumericBox.Value;
            }
            else
            {
                _fcard.rarity = (byte)RarityNumericBox.Value;
            }
            switch (RarityNumericBox.Value)
            {
                case 1: CardPictureBox.Image = LA_TT.Properties.Resources.CardB; break;
                case 2: CardPictureBox.Image = LA_TT.Properties.Resources.CardS; break;
                case 3: CardPictureBox.Image = LA_TT.Properties.Resources.CardG; break;
                case 4: CardPictureBox.Image = LA_TT.Properties.Resources.CardD; break;
            }
            UpdateValueDisplay();
        }

        private void NameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (ComboCardCheckBox.Checked)
            {
                _ccard.name = NameTextBox.Text;
                if (_ccard.name == "")
                {
                    cardNameEmpty = true;
                    UpdateErrorsListBox();
                    return;
                }
                cardNameEmpty = false;
                if (Cards.GetCCard(_ccard.name) != null)
                {
                    cardExists = true;
                    FillCardInfos(true);
                    UpdateErrorsListBox();
                    return;
                }
                cardExists = false;
                if (cardExisted)
                {
                    _ccombos = new List<CCombo>();
                    cardExisted = false;
                }
                UpdateErrorsListBox();
                UpdateComboCardsListBox();
            }
            else
            {
                _fcard.name = NameTextBox.Text;
                if (_fcard.name == "")
                {
                    cardNameEmpty = true;
                    UpdateErrorsListBox();
                    return;
                }
                cardNameEmpty = false;
                if (Cards.GetFCard(_fcard.name) != null)
                {
                    cardExists = true;
                    FillCardInfos(false);
                    UpdateErrorsListBox();
                    return;
                }
                cardExists = false;
                if (cardExisted)
                {
                    _fcombos = new List<FCombo>();
                    cardExisted = false;
                }
                UpdateErrorsListBox();
                UpdateComboCardsListBox();
            }
        }

        private void CombosWithTextBox_TextChanged(object sender, EventArgs e)
        {
            if (ComboCardCheckBox.Checked)
            {
                CCard ccard2 = Cards.GetCCard(CombosWithTextBox.Text);
                if (ccard2 == null)
                {
                    combosWithExists = false;
                    UpdateErrorsListBox();
                    return;
                }
                combosWithExists = true;
                combosWithRarity = ccard2.rarity;
            }
            else
            {
                CCard ccard1 = Cards.GetCCard(CombosWithTextBox.Text);
                if (ccard1 == null)
                {
                    combosWithExists = false;
                    UpdateErrorsListBox();
                    return;
                }
                combosWithExists = true;
                combosWithRarity = ccard1.rarity;
            }
        }

        private void CombosToCardTextBox_TextChanged(object sender, EventArgs e)
        {
            if (ComboCardCheckBox.Checked)
            {
                FCard fcard3 = Cards.GetFCard(CombosToCardTextBox.Text);
                if (fcard3 == null)
                {
                    CCard cfcard3 = Cards.GetCCard(CombosToCardTextBox.Text);
                    if (cfcard3 == null)
                    {
                        card3FCard = true;
                        combosToExists = false;
                        UpdateErrorsListBox();
                        return;
                    }
                    card3FCard = false;
                    combosToRarity = cfcard3.rarity;
                }
                else
                {
                    card3FCard = true;
                    combosToRarity = fcard3.rarity;
                }
                combosToExists = true;
            }
            else
            {
                CCard ccard2 = Cards.GetCCard(CombosToCardTextBox.Text);
                if (ccard2 == null)
                {
                    combosToExists = false;
                    UpdateErrorsListBox();
                    return;
                }
                combosToExists = true;
                combosToRarity = ccard2.rarity;
            }
        }

        private void DeleteComboButton_Click(object sender, EventArgs e)
        {
            if (ComboCardsListBox.SelectedIndex == -1) return;
            if (ComboCardCheckBox.Checked)
            {
                CCombo combo = _ccombos.Find(c => c.id == ComboCardsListBox.SelectedIndex);
                if (combo == null)
                {
                    MessageBox.Show("Combo could not be deleted.", "Delete Combo Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                _ccombos.Remove(combo);
                UpdateComboCardsListBox();
            }
            else
            {
                FCombo combo = _fcombos.Find(c => c.id == ComboCardsListBox.SelectedIndex);
                if (combo == null)
                {
                    MessageBox.Show("Combo could not be deleted.", "Delete Combo Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                _fcombos.Remove(combo);
                UpdateComboCardsListBox();
            }
        }

        private void FillCardInfos(bool isccard)
        {
            cardExisted = true;
            if (isccard)
            {
                CCard ccard = Cards.GetCCard(NameTextBox.Text);
                _ccard.name = ccard.name;
                _ccard.rarity = ccard.rarity;
                _ccard.level = ccard.level;
                _ccard.attack = ccard.attack;
                _ccard.defense = ccard.defense;

                _ccombos = ccard.combos;

                ComboCardCheckBox.Checked = true;
            }
            else
            {
                FCard fcard = Cards.GetFCard(NameTextBox.Text);
                _fcard.name = fcard.name;
                _fcard.rarity = fcard.rarity;
                _fcard.level = fcard.level;
                _fcard.attack = fcard.attack;
                _fcard.defense = fcard.defense;

                _fcombos = fcard.comboCards;

                ComboCardCheckBox.Checked = false;
            }
            UpdateValueDisplay();
        }
        private void UpdateValueDisplay()
        {
            if (ComboCardCheckBox.Checked)
            {
                NameTextBox.Text = _ccard.name;
                RarityNumericBox.Value = _ccard.rarity;
                LevelNumericBox.Value = _ccard.level;
                AttackNumericBox.Value = _ccard.attack;
                DefenseNumericBox.Value = _ccard.defense;

                CalcNewStats();
                CalcedAttackTextBox.Text = calcedAttack.ToString();
                CalcedDefenseTextBox.Text = calcedDefense.ToString();
            }
            else
            {
                NameTextBox.Text = _fcard.name;
                RarityNumericBox.Value = _fcard.rarity;
                LevelNumericBox.Value = _fcard.level;
                AttackNumericBox.Value = _fcard.attack;
                DefenseNumericBox.Value = _fcard.defense;

                CalcNewStats();
                CalcedAttackTextBox.Text = calcedAttack.ToString();
                CalcedDefenseTextBox.Text = calcedDefense.ToString();
            }
            UpdateComboCardsListBox();
        }

        private void CFPictureBox_Click(object sender, EventArgs e)
        {
            if (ComboCardCheckBox.Checked)
            {
                ComboCardCheckBox.Checked = false;
            }
            else
            {
                ComboCardCheckBox.Checked = true;
            }
        }
    }
}
