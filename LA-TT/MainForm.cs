using System.Net;

namespace LA_TT
{
    public partial class MainForm : Form
    {
        private bool finishedCardsInit;
        private bool finishedLoadForm;
        private bool updateOnlyCCards;
        private bool updateOnlyFCards;
        private bool currentCardC;
        private CCard currentCCard;
        private FCard currentFCard;
        public MainForm()
        {
            AppDomain.CurrentDomain.ProcessExit += OnProcessExit;
            InitializeComponent();
            Cards.OnFinishedInit += OnFinishedInitCards;
            Cards.Init();

            if (MessageBox.Show("Do you want to sync all Cards with the Wiki?", "Sync Cards", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                HtmlHandler htmlHandler = new HtmlHandler();
                htmlHandler.Sync(true);
            }
        }

        

        private void addCardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddCardForm addCardForm = new AddCardForm();
            DialogResult result = addCardForm.ShowDialog();
            if (result == DialogResult.OK)
            {
                SortYourCards();
            }
        }

        private void saveAllCardsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Cards._ccardsB.Count != 0) Cards.WriteCCards(false, 1);
            if (Cards._ccardsS.Count != 0) Cards.WriteCCards(false, 2);
            if (Cards._ccardsG.Count != 0) Cards.WriteCCards(false, 3);
            if (Cards._ccardsD.Count != 0) Cards.WriteCCards(false, 4);
            if (Cards._ccardsO.Count != 0) Cards.WriteCCards(false, 5);
        }

        private void saveAllFFCardsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Cards._fcardsB.Count != 0) Cards.WriteFCards(false, 1);
            if (Cards._fcardsS.Count != 0) Cards.WriteFCards(false, 2);
            if (Cards._fcardsG.Count != 0) Cards.WriteFCards(false, 3);
            if (Cards._fcardsD.Count != 0) Cards.WriteFCards(false, 4);
            if (Cards._fcardsO.Count != 0) Cards.WriteFCards(false, 5);
        }

        private void UpdateYourCards()
        {
            if (Cards._ycardsFiltered == null)
                return;

            int curIndex = OwnedCardsListBox.SelectedIndex;
            string cardType = "C";
            OwnedCardsListBox.Items.Clear();
            foreach (Card card in Cards._ycardsFiltered)
            {
                if (cardType == "C" && card.GetType() == typeof(FCard))
                {
                    cardType = "F";
                }
                else if (cardType == "F" && card.GetType() == typeof(CCard))
                {
                    cardType = "C";
                }
                OwnedCardsListBox.Items.Add(card.name+"; "+card.rarity+"; "+cardType);
            }
            if (OwnedCardsListBox.Items.Count != 0)
                OwnedCardsListBox.SelectedIndex = 0;
        }
        private void UpdateYourCCards()
        {
            if (Cards._yccards == null)
                return;

            OwnedCardsListBox.Items.Clear();
            foreach (Card card in Cards._yccards)
            {
                OwnedCardsListBox.Items.Add(card.name + "; " + card.rarity + "; C");
            }

            Cards._yfcards = Cards._yfcards.OrderBy(c => c.name).ToList();
            foreach (Card card in Cards._yfcards)
            {
                OwnedCardsListBox.Items.Add(card.name + "; " + card.rarity + "; F");
            }
            if (OwnedCardsListBox.Items.Count != 0)
                OwnedCardsListBox.SelectedIndex = 0;
        }
        private void UpdateYourFCards()
        {
            if (Cards._yfcards == null)
                return;

            OwnedCardsListBox.Items.Clear();
            foreach (Card card in Cards._yfcards)
            {
                OwnedCardsListBox.Items.Add(card.name + "; " + card.rarity + "; F");
            }

            Cards._yccards = Cards._yccards.OrderBy(c => c.name).ToList();
            foreach (Card card in Cards._yccards)
            {
                OwnedCardsListBox.Items.Add(card.name + "; " + card.rarity + "; C");
            }
            if (OwnedCardsListBox.Items.Count != 0)
                OwnedCardsListBox.SelectedIndex = 0;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            CardAttackTextBox.BackColor = Color.FromArgb(255, 102, 0);
            CardDefenseTextBox.BackColor = Color.FromArgb(0, 101, 204);
            OwnedCardsSortComboBox.SelectedIndex = 0;
            OwnedCardsOrderComboBox.SelectedIndex = 0;
            FilterComboBox.SelectedIndex = 0;
            OperatorComboBox.SelectedIndex = 0;
        }
        private void MainForm_Shown(object sender, EventArgs e)
        {
            finishedLoadForm = true;
            if (finishedCardsInit)
                UpdateYourCards();
        }

        private void OnFinishedInitCards(object sender, EventArgs e)
        {
            finishedCardsInit = true;
            CalcComboRarity();
            Cards._ycards = Cards._ycards.OrderBy(c => c.name).ToList();
            UpdateYourCards();
        }

        private void SortYourCards()
        {
            if (!finishedCardsInit) return;

            if (OwnedCardsOrderComboBox.SelectedIndex == 0)
            {
                switch (OwnedCardsSortComboBox.SelectedIndex)
                {
                    case 0: Cards._ycards = Cards._ycards.OrderBy(c => c.name).ToList();
                        //UpdateYourCards(); break;
                        updateOnlyCCards = false;
                        updateOnlyFCards = false; break;
                    case 1: Cards._ycards = Cards._ycards.OrderBy(c => c.attack).ToList();
                        //UpdateYourCards(); break;
                        updateOnlyCCards = false;
                        updateOnlyFCards = false; break;
                    case 2: Cards._ycards = Cards._ycards.OrderBy(c => c.defense).ToList();
                        //UpdateYourCards(); break;
                        updateOnlyCCards = false;
                        updateOnlyFCards = false; break;
                    case 3: Cards._ycards = Cards._ycards.OrderBy(c => c.attack * 2 + c.defense).ToList();
                        //UpdateYourCards(); break;
                        updateOnlyCCards = false;
                        updateOnlyFCards = false; break;
                    case 4: Cards._ycards = Cards._ycards.OrderBy(c => c.rarity).ToList();
                        //UpdateYourCards(); break;
                        updateOnlyCCards = false;
                        updateOnlyFCards = false; break;
                    case 6: Cards._yccards = Cards._yccards.OrderBy(c => c.combos.Count).ToList();
                        //UpdateYourCCards(); break;
                        updateOnlyCCards = true;
                        updateOnlyFCards = false; break;
                    case 7:
                        CalcComboRarity();
                        CalcComboStatsSum();
                        Cards._yccards = Cards._yccards.OrderBy(c => c.comboStatSum).ToList();
                        //UpdateYourCCards(); break;
                        updateOnlyCCards = true;
                        updateOnlyFCards = false; break;
                }
            }
            else if (OwnedCardsOrderComboBox.SelectedIndex == 1)
            {
                switch (OwnedCardsSortComboBox.SelectedIndex)
                {
                    case 0: Cards._ycards = Cards._ycards.OrderByDescending(c => c.name).ToList();
                        //UpdateYourCards(); break;
                        updateOnlyCCards = false;
                        updateOnlyFCards = false; break;
                    case 1: Cards._ycards = Cards._ycards.OrderByDescending(c => c.attack).ToList();
                        //UpdateYourCards(); break;
                        updateOnlyCCards = false;
                        updateOnlyFCards = false; break;
                    case 2: Cards._ycards = Cards._ycards.OrderByDescending(c => c.defense).ToList();
                        //UpdateYourCards(); break;
                        updateOnlyCCards = false;
                        updateOnlyFCards = false; break;
                    case 3: Cards._ycards = Cards._ycards.OrderByDescending(c => c.attack * 2 + c.defense).ToList();
                        //UpdateYourCards(); break;
                        updateOnlyCCards = false;
                        updateOnlyFCards = false; break;
                    case 4: Cards._ycards = Cards._ycards.OrderByDescending(c => c.rarity).ToList();
                        //UpdateYourCards(); break;
                        updateOnlyCCards = false;
                        updateOnlyFCards = false; break;
                    case 6: Cards._yccards = Cards._yccards.OrderByDescending(c => c.combos.Count).ToList();
                        //UpdateYourCCards(); break;
                        updateOnlyCCards = true;
                        updateOnlyFCards = false; break;
                    case 7:
                        CalcComboRarity();
                        CalcComboStatsSum();
                        Cards._yccards = Cards._yccards.OrderByDescending(c => c.comboStatSum).ToList();
                        //UpdateYourCCards(); break;
                        updateOnlyCCards = true;
                        updateOnlyFCards = false; break;
                }
            }
            //UpdateYourCards();
            SetFilters();
        }

        private void CalcComboStatsSum()
        {
            foreach (CCard ccard in Cards._yccards)
            {
                foreach (CCombo combo in ccard.combos)
                {
                    FCard fcResult;
                    if (combo.card3Rarity != 0)
                    {
                        fcResult = Cards.GetFCard(combo.card3Name, true);
                    }
                    else
                    {
                        fcResult = Cards.GetFCard(combo.card3Name, combo.card3Rarity, true);
                    }
                    if (fcResult != null)
                    {
                        ccard.comboStatSum += fcResult.attack + fcResult.defense;
                        Cards.UpdateCCard(ccard, false);
                    }
                }
            }
        }
        private void CalcComboRarity()
        {
            foreach (CCard ccard in Cards._yccards)
            {
                foreach (CCombo combo in ccard.combos)
                {
                    CCard ccCombo= Cards.GetCCard(combo.ccard2Name, true);
                    if (ccCombo != null)
                    {
                        combo.ccard2Rarity = ccCombo.rarity;
                        Cards.UpdateCCard(ccCombo, false);
                    }

                    FCard fcResult = Cards.GetFCard(combo.card3Name, true);
                    if (fcResult != null)
                    {
                        combo.card3Rarity = fcResult.rarity;
                        Cards.UpdateFCard(fcResult, false);
                    }
                }
            }
            foreach (FCard fcard in Cards._yfcards)
            {
                foreach (FCombo combo in fcard.comboCards)
                {
                    CCard ccCombo1 = Cards.GetCCard(combo.ccard1Name, true);
                    if (ccCombo1 != null)
                    {
                        combo.ccard1Rarity = ccCombo1.rarity;
                        Cards.UpdateCCard(ccCombo1, false);
                    }

                    CCard ccCombo2 = Cards.GetCCard(combo.ccard2Name, true);
                    if (ccCombo2 != null)
                    {
                        combo.ccard2Rarity = ccCombo2.rarity;
                        Cards.UpdateCCard(ccCombo2, false);
                    }
                }
            }
        }

        private void OwnedCardsSortComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SortYourCards();
        }

        private void OwnedCardsOrderComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SortYourCards();
        }

        private void RefreshYourCardsButton_Click(object sender, EventArgs e)
        {
            UpdateYourCards();
        }

        private void OwnedCardsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string cardText = OwnedCardsListBox.Text;
            
            string cardname = cardText.Substring(0, cardText.IndexOf(';')).Trim();
            cardText = cardText.Substring(cardText.IndexOf(';') + 1, cardText.Length - 1 - cardText.IndexOf(';'));
            string cardrarity = cardText.Substring(0, cardText.IndexOf(';')).Trim();
            cardText = cardText.Substring(cardText.IndexOf(';') + 1, cardText.Length - 1 - cardText.IndexOf(';'));
            string cardtype = cardText.Trim();

            if (cardtype == "C")
            {
                CCard ccard = Cards.GetCCard(cardname, byte.Parse(cardrarity), true);
                CardLevelTextBox.Text = ccard.level.ToString();
                CardAttackTextBox.Text = ccard.attack.ToString();
                CardDefenseTextBox.Text = ccard.defense.ToString();
                CardNameTextBox.Text = ccard.name;
                CFPictureBox.Image = Properties.Resources.C;
                switch (ccard.rarity)
                {
                    case 1: CardPictureBox.Image = Properties.Resources.CardB; break;
                    case 2: CardPictureBox.Image = Properties.Resources.CardS; break;
                    case 3: CardPictureBox.Image = Properties.Resources.CardG; break;
                    case 4: CardPictureBox.Image = Properties.Resources.CardD; break;
                }
                currentCardC = true;
                currentCCard = ccard;
                currentFCard = new FCard();
            }
            else
            {
                FCard fcard = Cards.GetFCard(cardname, byte.Parse(cardrarity), true);
                CardLevelTextBox.Text = fcard.level.ToString();
                CardAttackTextBox.Text = fcard.attack.ToString();
                CardDefenseTextBox.Text = fcard.defense.ToString();
                CardNameTextBox.Text = fcard.name;
                CFPictureBox.Image = Properties.Resources.F;
                switch (fcard.rarity)
                {
                    case 1: CardPictureBox.Image = Properties.Resources.CardB; break;
                    case 2: CardPictureBox.Image = Properties.Resources.CardS; break;
                    case 3: CardPictureBox.Image = Properties.Resources.CardG; break;
                    case 4: CardPictureBox.Image = Properties.Resources.CardD; break;
                }
                currentCardC = false;
                currentFCard = fcard;
                currentCCard = new CCard();
            }
        }
        private void OnProcessExit(object sender, EventArgs e)
        {
            Cards.WriteCCards(true, 1);
            Cards.WriteCCards(true, 2);
            Cards.WriteCCards(true, 3);
            Cards.WriteCCards(true, 4);
            Cards.WriteCCards(true, 5);

            Cards.WriteFCards(true, 1);
            Cards.WriteFCards(true, 2);
            Cards.WriteFCards(true, 3);
            Cards.WriteFCards(true, 4);
            Cards.WriteFCards(true, 5);

            Cards.WriteCCards(false, 1);
            Cards.WriteCCards(false, 2);
            Cards.WriteCCards(false, 3);
            Cards.WriteCCards(false, 4);
            Cards.WriteCCards(false, 5);

            Cards.WriteFCards(false, 1);
            Cards.WriteFCards(false, 2);
            Cards.WriteFCards(false, 3);
            Cards.WriteFCards(false, 4);
            Cards.WriteFCards(false, 5);

            Thread.Sleep(2000);
        }

        private void FilterComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (FilterComboBox.SelectedIndex)
            {
                case 0:
                    FilterTextBox.Visible = false;
                    FilterTextBox.Clear();
                    FilterNumericBox.Visible = false;
                    FilterNumericBox.Value = 0;
                    break;
                case 1:
                    FilterTextBox.Visible = true;
                    FilterNumericBox.Visible = false;
                    FilterNumericBox.Value = 0;
                    break;
                case 2:
                    FilterNumericBox.Visible = true;
                    FilterTextBox.Visible = false;
                    FilterTextBox.Clear();
                    break;
                case 3:
                    FilterNumericBox.Visible = true;
                    FilterTextBox.Visible = false;
                    FilterTextBox.Clear();
                    break;
                case 4:
                    FilterNumericBox.Visible = true;
                    FilterTextBox.Visible = false;
                    FilterTextBox.Clear();
                    break;
                case 5:
                    FilterNumericBox.Visible = true;
                    FilterTextBox.Visible = false;
                    FilterTextBox.Clear();
                    break;
            }
        }

        private void SetFilters()
        {
            Cards._ycardsFiltered = Cards._ycards;
            switch (FilterComboBox.SelectedIndex)
            {
                case 1: SetFilterName(FilterTextBox.Text.Trim()); break;
                case 2: SetFilterAttack((byte)FilterNumericBox.Value); break;
                case 3: SetFilterDefense((byte)FilterNumericBox.Value); break;
                case 4: SetFilterRarity((byte)FilterNumericBox.Value); break;
                case 5: SetFilterLevel((byte)FilterNumericBox.Value); break;
            }
            if (updateOnlyCCards)
            {
                UpdateYourCCards();
            }
            else if (updateOnlyFCards)
            {
                UpdateYourFCards();
            }
            else
            {
                UpdateYourCards();
            }
        }

        private void SetFilterName(string name)
        {
            switch (OperatorComboBox.SelectedIndex)
            {
                case 0:  Cards._ycardsFiltered = Cards._ycards.Where(c => c.name.StartsWith(name)).ToList(); break;
                case 1: Cards._ycardsFiltered = Cards._ycards.Where(c => c.name.StartsWith(name)).ToList(); break;
                case 2: Cards._ycardsFiltered = Cards._ycards.Where(c => c.name == name).ToList(); break;
                case 3: Cards._ycardsFiltered = Cards._ycards.Where(c => c.name.EndsWith(name)).ToList(); break;
                case 4: Cards._ycardsFiltered = Cards._ycards.Where(c => c.name.EndsWith(name)).ToList(); break;
            }
        }
        private void SetFilterAttack(byte attack)
        {
            switch (OperatorComboBox.SelectedIndex)
            {
                case 0: Cards._ycardsFiltered = Cards._ycards.Where(c => c.attack < attack).ToList(); break;
                case 1: Cards._ycardsFiltered = Cards._ycards.Where(c => c.attack <= attack).ToList(); break;
                case 2: Cards._ycardsFiltered = Cards._ycards.Where(c => c.attack == attack).ToList(); break;
                case 3: Cards._ycardsFiltered = Cards._ycards.Where(c => c.attack >= attack).ToList(); break;
                case 4: Cards._ycardsFiltered = Cards._ycards.Where(c => c.attack > attack).ToList(); break;
            }
        }
        private void SetFilterDefense(byte defense)
        {
            switch (OperatorComboBox.SelectedIndex)
            {
                case 0: Cards._ycardsFiltered = Cards._ycards.Where(c => c.defense < defense).ToList(); break;
                case 1: Cards._ycardsFiltered = Cards._ycards.Where(c => c.defense <= defense).ToList(); break;
                case 2: Cards._ycardsFiltered = Cards._ycards.Where(c => c.defense == defense).ToList(); break;
                case 3: Cards._ycardsFiltered = Cards._ycards.Where(c => c.defense >= defense).ToList(); break;
                case 4: Cards._ycardsFiltered = Cards._ycards.Where(c => c.defense > defense).ToList(); break;
            }
        }
        private void SetFilterRarity(byte rarity)
        {
            switch (OperatorComboBox.SelectedIndex)
            {
                case 0: Cards._ycardsFiltered = Cards._ycards.Where(c => c.rarity < rarity).ToList(); break;
                case 1: Cards._ycardsFiltered = Cards._ycards.Where(c => c.rarity <= rarity).ToList(); break;
                case 2: Cards._ycardsFiltered = Cards._ycards.Where(c => c.rarity == rarity).ToList(); break;
                case 3: Cards._ycardsFiltered = Cards._ycards.Where(c => c.rarity >= rarity).ToList(); break;
                case 4: Cards._ycardsFiltered = Cards._ycards.Where(c => c.rarity > rarity).ToList(); break;
            }
        }
        private void SetFilterLevel(byte level)
        {
            switch (OperatorComboBox.SelectedIndex)
            {
                case 0: Cards._ycardsFiltered = Cards._ycards.Where(c => c.level < level).ToList(); break;
                case 1: Cards._ycardsFiltered = Cards._ycards.Where(c => c.level <= level).ToList(); break;
                case 2: Cards._ycardsFiltered = Cards._ycards.Where(c => c.level == level).ToList(); break;
                case 3: Cards._ycardsFiltered = Cards._ycards.Where(c => c.level >= level).ToList(); break;
                case 4: Cards._ycardsFiltered = Cards._ycards.Where(c => c.level > level).ToList(); break;
            }
        }

        private void FilterButton_Click(object sender, EventArgs e)
        {
            SortYourCards();
        }

        private void OperatorComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SortYourCards();
        }

        private void EditCardButton_Click(object sender, EventArgs e)
        {
            AddCardForm addCardForm;
            if (currentCardC)
            {
                addCardForm = new AddCardForm(currentCCard, true);
            }
            else
            {
                addCardForm = new AddCardForm(currentFCard, true);
            }
            DialogResult result = addCardForm.ShowDialog();
            if (result == DialogResult.OK)
            {
                SortYourCards();
            }
        }
    }
}