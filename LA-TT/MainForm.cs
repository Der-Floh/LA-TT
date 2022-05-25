using System.Net;

namespace LA_TT
{
    public partial class MainForm : Form
    {
        private bool finishedCardsInit;
        private bool finishedLoadForm;
        public MainForm()
        {
            AppDomain.CurrentDomain.ProcessExit += OnProcessExit;
            InitializeComponent();
            Cards.OnFinishedInit += OnFinishedInitCards;
            Cards.Init();

            HtmlHandler htmlHandler = new HtmlHandler();
            //htmlHandler.DownloadWikiPageHTML();
        }

        

        private void addCardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddCardForm addCardForm = new AddCardForm();
            DialogResult result = addCardForm.ShowDialog();
            /*
            if (result == DialogResult.OK || (addCardForm.LeftWindowOpenCheckBox.Checked && result == DialogResult.None))//not using leave open box make new invisible one
            {
                if (addCardForm.ComboCardCheckBox.Checked)
                {
                    //! CONTINUE
                    CCard ccard = new CCard();
                    ccard.name = addCardForm.NameTextBox.Text;
                    ccard.level = (byte)addCardForm.LevelNumericBox.Value;
                    ccard.attack = (byte)addCardForm.AttackNumericBox.Value;
                    ccard.defense = (byte)addCardForm.DefenseNumericBox.Value;
                    ccard.rarity = (byte)addCardForm.RarityNumericBox.Value;
                    ccard.image = addCardForm.ImagePictureBox.Image;

                    FCard fcard = Cards.GetFCard(addCardForm.CombosToCardTextBox.Text);

                    if (fcard == null)
                    {
                        CCard cfcard = Cards.GetCCard(addCardForm.CombosToCardTextBox.Text);
                        try
                        {
                            ccard.combos.Add(Cards.GetCCard(addCardForm.CombosWithTextBox.Text), cfcard);
                        }
                        catch (Exception) { }
                    }
                    else
                    {
                        ccard.combos.Add(Cards.GetCCard(addCardForm.CombosWithTextBox.Text), fcard);
                    }

                    Cards.AddCCard(ccard);
                }
                else
                {
                    FCard fcard = new FCard();
                    fcard.name = addCardForm.NameTextBox.Text;
                    fcard.level = (byte)addCardForm.LevelNumericBox.Value;
                    fcard.attack = (byte)addCardForm.AttackNumericBox.Value;
                    fcard.defense = (byte)addCardForm.DefenseNumericBox.Value;
                    fcard.rarity = (byte)addCardForm.RarityNumericBox.Value;
                    fcard.image = addCardForm.ImagePictureBox.Image;

                    try
                    {
                        fcard.comboCards.Add(Cards.GetCCard(addCardForm.CombosWithTextBox.Text), Cards.GetCCard(addCardForm.CombosToCardTextBox.Text));
                    }
                    catch (Exception) { }
                    
                    Cards.AddFCard(fcard);
                }
            }
            */
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
            if (Cards._ycards == null)
                return;

            string cardType = "C";
            OwnedCardsListBox.Items.Clear();
            foreach (Card card in Cards._ycards)
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
            //CalcComboRarity();
            Cards._ycards = Cards._ycards.OrderBy(c => c.name).ToList();
            UpdateYourCards();
            //MessageBox.Show("Form Init Finished");
        }

        private void SortYourCards()
        {
            if (!finishedCardsInit) return;

            if (OwnedCardsOrderComboBox.SelectedIndex == 0)
            {
                switch (OwnedCardsSortComboBox.SelectedIndex)
                {
                    case 0: Cards._ycards = Cards._ycards.OrderBy(c => c.name).ToList();
                        UpdateYourCards(); break;
                    case 1: Cards._ycards = Cards._ycards.OrderBy(c => c.attack).ToList();
                        UpdateYourCards(); break;
                    case 2: Cards._ycards = Cards._ycards.OrderBy(c => c.defense).ToList(); 
                        UpdateYourCards(); break;
                    case 3: Cards._ycards = Cards._ycards.OrderBy(c => c.attack * 2 + c.defense).ToList(); 
                        UpdateYourCards(); break;
                    case 4: Cards._ycards = Cards._ycards.OrderBy(c => c.rarity).ToList(); 
                        UpdateYourCards(); break;
                    case 5: Cards._yccards = Cards._yccards.OrderBy(c => c.combos.Count).ToList(); 
                        UpdateYourCCards(); break;
                    case 6: CalcComboStatsSum();
                        Cards._yccards = Cards._yccards.OrderBy(c => c.comboStatSum).ToList();
                        UpdateYourCCards(); break;
                }
            }
            else if (OwnedCardsOrderComboBox.SelectedIndex == 1)
            {
                switch (OwnedCardsSortComboBox.SelectedIndex)
                {
                    case 0: Cards._ycards = Cards._ycards.OrderByDescending(c => c.name).ToList(); 
                        UpdateYourCards(); break;
                    case 1: Cards._ycards = Cards._ycards.OrderByDescending(c => c.attack).ToList(); 
                        UpdateYourCards(); break;
                    case 2: Cards._ycards = Cards._ycards.OrderByDescending(c => c.defense).ToList(); 
                        UpdateYourCards(); break;
                    case 3: Cards._ycards = Cards._ycards.OrderByDescending(c => c.attack * 2 + c.defense).ToList(); 
                        UpdateYourCards(); break;
                    case 4: Cards._ycards = Cards._ycards.OrderByDescending(c => c.rarity).ToList(); 
                        UpdateYourCards(); break;
                    case 5: Cards._yccards = Cards._yccards.OrderByDescending(c => c.combos.Count).ToList(); 
                        UpdateYourFCards(); break;
                    case 6:
                        CalcComboStatsSum();
                        Cards._yccards = Cards._yccards.OrderByDescending(c => c.comboStatSum).ToList();
                        UpdateYourCCards(); break;
                }
            }
            UpdateYourCards();
        }

        private void CalcComboStatsSum()
        {
            foreach (CCard ccard in Cards._ycards)
            {
                foreach (CCombo combo in ccard.combos)
                {
                    FCard fcResult;
                    if (combo.card3Rarity != 0)
                    {
                        fcResult = Cards.GetFCard(combo.card3Name);
                    }
                    else
                    {
                        fcResult = Cards.GetFCard(combo.card3Name, combo.card3Rarity);
                    }
                    if (fcResult != null)
                    {
                        ccard.comboStatSum += fcResult.attack + fcResult.defense;
                    }
                }
            }
        }
        private void CalcComboRarity()
        {
            foreach (CCard ccard in Cards._ycards)
            {
                foreach (CCombo combo in ccard.combos)
                {
                    CCard ccCombo= Cards.GetCCard(combo.ccard2Name);
                    if (ccCombo != null)
                    {
                        combo.card3Rarity = ccCombo.rarity;
                    }

                    FCard fcResult = Cards.GetFCard(combo.card3Name);
                    if (fcResult != null)
                    {
                        combo.card3Rarity = fcResult.rarity;
                    }
                }
            }
            foreach (FCard fcard in Cards._ycards)
            {
                foreach (FCombo combo in fcard.comboCards)
                {
                    CCard ccCombo1 = Cards.GetCCard(combo.ccard1Name);
                    if (ccCombo1 != null)
                    {
                        combo.ccard1Rarity = ccCombo1.rarity;
                    }

                    CCard ccCombo2 = Cards.GetCCard(combo.ccard2Name);
                    if (ccCombo2 != null)
                    {
                        combo.ccard2Rarity = ccCombo2.rarity;
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
                CCard ccard = Cards.GetCCard(cardname, byte.Parse(cardrarity));
                CardLevelTextBox.Text = ccard.level.ToString();
                CardAttackTextBox.Text = ccard.attack.ToString();
                CardDefenseTextBox.Text = ccard.defense.ToString();
                CardNameTextBox.Text = ccard.name;
            }
            else
            {
                FCard fcard = Cards.GetFCard(cardname, byte.Parse(cardrarity));
                CardLevelTextBox.Text = fcard.level.ToString();
                CardAttackTextBox.Text = fcard.attack.ToString();
                CardDefenseTextBox.Text = fcard.defense.ToString();
                CardNameTextBox.Text = fcard.name;
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
        }
    }
}