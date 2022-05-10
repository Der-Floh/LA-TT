namespace LA_TT
{
    public partial class MainForm : Form
    {
        private bool finishedCardsInit;
        private bool finishedLoadForm;
        public MainForm()
        {
            InitializeComponent();
            Cards.Init();
            Cards.OnFinishedInit += OnFinishedInitCards;
        }

        private void addCardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddCardForm addCardForm = new AddCardForm();
            if (addCardForm.ShowDialog() == DialogResult.OK)
            {
                if (addCardForm.ComboCardCheckBox.Checked)
                {
                    CCard ccard = new CCard();
                    ccard.name = addCardForm.NameTextBox.Text;
                    ccard.level = (byte)addCardForm.LevelNumericBox.Value;
                    ccard.attack = (byte)addCardForm.AttackNumericBox.Value;
                    ccard.defense = (byte)addCardForm.DefenseNumericBox.Value;
                    ccard.image = addCardForm.ImagePictureBox.Image;
                    Cards.AddCCard(ccard);
                }
                else
                {
                    FCard fcard = new FCard();
                    fcard.name = addCardForm.NameTextBox.Text;
                    fcard.level = (byte)addCardForm.LevelNumericBox.Value;
                    fcard.attack = (byte)addCardForm.AttackNumericBox.Value;
                    fcard.defense = (byte)addCardForm.DefenseNumericBox.Value;
                    fcard.image = addCardForm.ImagePictureBox.Image;
                    Cards.AddFCard(fcard);
                }
            }
            addCardForm.Dispose();
        }

        private void saveAllCardsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cards.WriteCCards(false, 1);
            Cards.WriteCCards(false, 2);
            Cards.WriteCCards(false, 3);
            Cards.WriteCCards(false, 4);
            Cards.WriteCCards(false, 5);
        }

        private void saveAllFFCardsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Cards.WriteFCards();
        }

        private void UpdateYourCards()
        {
            if (Cards._ycards == null)
            {
                OwnedCardsListBox.Items.Add("Empty");
                return;
            }

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
            OwnedCardsListBox.SelectedIndex = 0;
        }
        private void UpdateYourCCards()
        {
            if (Cards._yccards == null)
            {
                OwnedCardsListBox.Items.Add("Empty");
                return;
            }

            OwnedCardsListBox.Items.Clear();
            foreach (CCard card in Cards._yccards)
            {
                OwnedCardsListBox.Items.Add(card.name + "; " + card.rarity + "; C");
            }
            OwnedCardsListBox.SelectedIndex = 0;
        }
        private void UpdateYourFCards()
        {
            if (Cards._yfcards == null)
            {
                OwnedCardsListBox.Items.Add("Empty");
                return;
            }

            OwnedCardsListBox.Items.Clear();
            foreach (FCard card in Cards._yfcards)
            {
                OwnedCardsListBox.Items.Add(card.name + "; " + card.rarity + "; F");
            }
            OwnedCardsListBox.SelectedIndex = 0;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            CardAttackTextBox.BackColor = Color.FromArgb(255, 102, 0);
            CardDefenseTextBox.BackColor = Color.FromArgb(101, 204, 255);
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
                    case 0: Cards._ycards = Cards._ycards.OrderBy(c => c.name).ToList(); break;
                    case 1: Cards._ycards = Cards._ycards.OrderBy(c => c.attack).ToList(); break;
                    case 2: Cards._ycards = Cards._ycards.OrderBy(c => c.defense).ToList(); break;
                    case 3: Cards._ycards = Cards._ycards.OrderBy(c => c.attack + c.defense).ToList(); break;
                    case 4: Cards._ycards = Cards._ycards.OrderBy(c => c.rarity).ToList(); break;
                    case 5: Cards._yccards = Cards._yccards.OrderBy(c => c.comboCards.Length).ToList(); break;
                }
            }
            else if (OwnedCardsOrderComboBox.SelectedIndex == 1)
            {
                switch (OwnedCardsSortComboBox.SelectedIndex)
                {
                    case 0: Cards._ycards = Cards._ycards.OrderByDescending(c => c.name).ToList(); break;
                    case 1: Cards._ycards = Cards._ycards.OrderByDescending(c => c.attack).ToList(); break;
                    case 2: Cards._ycards = Cards._ycards.OrderByDescending(c => c.defense).ToList(); break;
                    case 3: Cards._ycards = Cards._ycards.OrderByDescending(c => c.attack + c.defense).ToList(); break;
                    case 4: Cards._ycards = Cards._ycards.OrderByDescending(c => c.rarity).ToList(); break;
                    case 5: Cards._ycards = Cards._ycards.OrderByDescending(c => c.name).ToList(); break;
                }
            }
            UpdateYourCards();
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
    }
}