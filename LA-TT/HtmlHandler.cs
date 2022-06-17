using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using HtmlDocument = HtmlAgilityPack.HtmlDocument;
using HtmlNode = HtmlAgilityPack.HtmlNode;

namespace LA_TT
{
    public class HtmlHandler
    {
        HtmlDocument _cardsHtml;
        HtmlDocument _currentCardHtml;
        char currentLetter;
        string skippedCards;
        bool hasSkippedCards;
        float loadingCards;
        float loadingCardsAll;
        string currentCardUrl;
        bool skipDownloadWhenExist;
        LoadingForm loadingForm;
        public void Sync(bool skipIfDownloaded)
        {
            skipDownloadWhenExist = skipIfDownloaded;
            DownloadWikiPageHTML();
        }
        public void Sync(bool skipIfDownloaded, char letter)
        {
            skipDownloadWhenExist = skipIfDownloaded;
            DownloadWikiPageHTML(letter);
        }
        private void DownloadWikiPageHTML()
        {
            Form mainForm = Application.OpenForms[0];
            loadingForm = new LoadingForm();
            loadingForm.Show();
            loadingForm.Location = new Point((mainForm.Location.X + mainForm.Size.Width / 2) - loadingForm.Size.Width / 2, (mainForm.Location.Y + mainForm.Size.Height / 2) - loadingForm.Size.Height / 2);
            loadingForm.HeaderLabel.Refresh();

            for (currentLetter = 'A'; currentLetter <= 'Z'; currentLetter++)
            {
                using (WebClient client = new WebClient())
                {
                    loadingForm.TopLoadingBarLabel.Text = "Loading Cards with Letter: " +currentLetter;
                    loadingForm.TopLoadingBarLabel.Refresh();
                    loadingForm.TopLoadingBar.Refresh();
                    if (!(skipDownloadWhenExist && File.Exists("Resources/Html/Cards" + currentLetter + ".html")))
                    {
                        client.DownloadFile(new Uri(UserSettings.wikiUrl+ "/wiki/Category:Card?from=" + currentLetter), "Resources/Html/Cards" + currentLetter + ".html");
                    }
                    _cardsHtml = new HtmlDocument();
                    _cardsHtml.Load("Resources/Html/Cards" +currentLetter+ ".html");
                }
                FindCards();
                loadingCardsAll += 1;
                loadingForm.TopLoadingBar.Value = (int)Math.Round(loadingCardsAll*100 / 26);
            }
            if (!hasSkippedCards)
            {
                MessageBox.Show("All Cards Synchronized");
            }
            else
            {
                MessageBox.Show("Skipped Cards:\n" + skippedCards);
            }
            SaveCards();

            if (UserSettings.deleteAfterDownload)
            {
                JsonHandler jsonHandler = new JsonHandler();
                jsonHandler.DeleteHtmlFiles();
            }

            loadingForm.Close();
        }

        private void DownloadWikiPageHTML(char letter)
        {
            loadingForm = new LoadingForm();
            loadingForm.Show();
            currentLetter = letter;

            using (WebClient client = new WebClient())
            {
                loadingForm.TopLoadingBarLabel.Text = "Loading Cards with Letter: " + currentLetter;
                loadingForm.TopLoadingBarLabel.Refresh();
                loadingForm.TopLoadingBar.Refresh();
                if (!(skipDownloadWhenExist && File.Exists("Resources/Html/Cards" + currentLetter + ".html")))
                {
                    client.DownloadFile(new Uri(UserSettings.wikiUrl+ "/wiki/Category:Card?from=" + currentLetter), "Resources/Html/Cards" + currentLetter + ".html");
                }
                _cardsHtml = new HtmlDocument();
                _cardsHtml.Load("Resources/Html/Cards" + currentLetter + ".html");
            }
            FindCards();
            loadingCardsAll += 1;
            loadingForm.TopLoadingBar.Value = (int)Math.Round(loadingCardsAll * 100 / 26);

            if (!hasSkippedCards)
            {
                MessageBox.Show("All Cards Synchronized");
            }
            else
            {
                MessageBox.Show("Skipped Cards:\n" + skippedCards);
            }
            SaveCards();

            if (UserSettings.deleteAfterDownload)
            {
                JsonHandler jsonHandler = new JsonHandler();
                jsonHandler.DeleteHtmlFiles();
            }

            loadingForm.Close();
        }

        private void SaveCards()
        {
            Cards.WriteCCards(true, 1);
            Cards.WriteCCards(true, 2);
            Cards.WriteCCards(true, 3);
            Cards.WriteCCards(true, 4);
            Cards.WriteCCards(true, 5);

            Cards.WriteCCards(false, 1);
            Cards.WriteCCards(false, 2);
            Cards.WriteCCards(false, 3);
            Cards.WriteCCards(false, 4);
            Cards.WriteCCards(false, 5);

            Cards.WriteFCards(true, 1);
            Cards.WriteFCards(true, 2);
            Cards.WriteFCards(true, 3);
            Cards.WriteFCards(true, 4);
            Cards.WriteFCards(true, 5);

            Cards.WriteFCards(false, 1);
            Cards.WriteFCards(false, 2);
            Cards.WriteFCards(false, 3);
            Cards.WriteFCards(false, 4);
            Cards.WriteFCards(false, 5);
        }
        private void DownloadCard(string cardUrl, string cardname)
        {
            using (WebClient client = new WebClient())
            {
                try
                {
                    if (!Directory.Exists("Resources/Html/Cards" + currentLetter)) Directory.CreateDirectory("Resources/Html/Cards" + currentLetter);
                    if (!(skipDownloadWhenExist && File.Exists("Resources/Html/Cards" + currentLetter + "/" + cardname + ".html")))
                    {
                        client.DownloadFile(new Uri(UserSettings.wikiUrl + cardUrl), "Resources/Html/Cards" + currentLetter + "/" + cardname + ".html");
                    }
                }
                catch 
                {
                    hasSkippedCards = true;
                    skippedCards += cardname + "\n";
                    return;
                }
                _currentCardHtml = new HtmlDocument();
                _currentCardHtml.Load("Resources/Html/Cards" +currentLetter+ "/" + cardname + ".html");
            }
            HtmlToCard(cardname);
        }

        private void FindCards()
        {
            HtmlNode region = _cardsHtml.DocumentNode.Descendants("div").Where(node => node.Attributes.Count >= 2 && node.Attributes[0].Name == "id" && node.Attributes[0].Value == "mw-content-text").FirstOrDefault();

            var cards = region.Descendants("a").Where(node => node.Attributes.Count == 3);
            List<string> cardNames = new List<string>();

            foreach (HtmlNode cardName in cards)
            {
                if (!cardName.InnerText.Contains(':'))
                    cardNames.Add(cardName.InnerText);
            }

            loadingForm.BottomLoadingBar.Value = 0;
            loadingCards = 0;
            foreach (string cardName in cardNames)
            {
                loadingForm.BottomLoadingBarLabel.Text = "Loading Card: " +cardName;
                loadingForm.BottomLoadingBarLabel.Refresh();
                loadingForm.BottomLoadingBar.Refresh();
                FindCard(cardName);
                loadingCards += 1;
                loadingForm.BottomLoadingBar.Value = (int)Math.Round(loadingCards*100 / cardNames.Count);
            }
        }

        private void FindCard(string cardname)
        {
            HtmlNode node = _cardsHtml.DocumentNode.Descendants().Where(node => node.Attributes.Count >= 2 && node.Attributes[1].Value == cardname).FirstOrDefault();

            currentCardUrl = node.Attributes[0].Value;
            DownloadCard(node.Attributes[0].Value, node.Attributes[1].Value);
        }

        private void HtmlToCard(string cardname)
        {
            HtmlNode region = _currentCardHtml.DocumentNode.Descendants("aside").Where(node => node.Attributes.Count >= 2 && node.Attributes[0].Name == "role" && node.Attributes[0].Value == "region").FirstOrDefault();

            HtmlNode attackNode = region.Descendants("td").Where(node => node.Attributes.Count >= 2 && node.Attributes[1].Name == "data-source" && node.Attributes[1].Value == "attack").FirstOrDefault();
            byte attack = 0;
            byte.TryParse(attackNode.InnerText, out attack);

            HtmlNode defenseNode = region.Descendants("td").Where(node => node.Attributes.Count >= 2 && node.Attributes[1].Name == "data-source" && node.Attributes[1].Value == "defense").FirstOrDefault();
            byte defense = 0;
            byte.TryParse(defenseNode.InnerText, out defense);

            HtmlNode rarityNode = region.Descendants("td").Where(node => node.Attributes.Count >= 2 && node.Attributes[1].Name == "data-source" && node.Attributes[1].Value == "rarity" && node.LastChild.Attributes.Count >= 2 && node.LastChild.Attributes[0].Name == "href").FirstOrDefault();
            byte rarity = 0;
            switch (rarityNode.InnerText.Trim())
            {
                case "Bronze": rarity = 1; break;
                case "Silver": rarity= 2; break;
                case "Gold": rarity = 3; break;
                case "Diamond": rarity = 4; break;
                case "Onyx": rarity = 5; break;
            }

            HtmlNode formNode = region.Descendants("td").Where(node => node.Attributes.Count >= 2 && node.Attributes[1].Name == "data-source" && node.Attributes[1].Value == "form").FirstOrDefault();
            bool comboCard = false;
            if (formNode.InnerText.Trim() == "Combo") comboCard = true;

            List<CCombo> cCombos = new List<CCombo>();
            List<FCombo> fCombos = new List<FCombo>();
            if (comboCard)
            {
                cCombos = GetHtmlCCardCombos();

                CCard card = new CCard();
                card.name = cardname;
                card.rarity = rarity;
                card.attack = attack;
                card.defense = defense;
                card.level = 1;
                card.cardUrl = currentCardUrl;
                if (cCombos != null)
                    card.combos = cCombos;
                
                Cards.AddCCard(card, false);
            }
            else
            {
                fCombos = GetHtmlFCardCombos();

                FCard card = new FCard();
                card.name = cardname;
                card.rarity = rarity;
                card.attack = attack;
                card.defense = defense;
                card.level = 1;
                card.cardUrl = currentCardUrl;
                if (fCombos != null)
                    card.comboCards = fCombos;
               
                Cards.AddFCard(card, false);
            }
        }

        private List<FCombo> GetHtmlFCardCombos()
        {
            HtmlNode region = _currentCardHtml.DocumentNode.Descendants("table").Where(node => node.Attributes.Count >= 2 && node.Attributes[1].Name == "id" && node.Attributes[1].Value == "mw-customcollapsible-recipesTable").FirstOrDefault();

            if (region == null) return null;

            var comboCards = region.Descendants("a").Where(node => node.Attributes.Count >= 2);
            List<FCombo> fCombos = new List<FCombo>();
            FCombo fcombo = new FCombo();
            int i = 0;
            int j = 0;
            foreach (HtmlNode node in comboCards)
            {
                if (i % 2 == 0)
                {
                    fcombo.id = j;
                    fcombo.ccard1Name = node.InnerText;
                }
                else
                {
                    fcombo.id = j;
                    fcombo.ccard2Name = node.InnerText;
                    fCombos.Add(fcombo);
                    fcombo = new FCombo();
                    j++;
                }
                i++;
            }
            return fCombos;
        }

        private List<CCombo> GetHtmlCCardCombos()
        {
            HtmlNode region = _currentCardHtml.DocumentNode.Descendants("table").Where(node => node.Attributes.Count >= 2 && node.Attributes[1].Name == "id" && node.Attributes[1].Value == "mw-customcollapsible-combosTable").FirstOrDefault();

            if (region == null) return null;

            var combos = region.Descendants("td").Where(node => node.ChildNodes[0].Attributes.Count >= 1 /*node.Attributes.Count >= 2*/);
            var combosRarities = region.Descendants("td").Where(node => node.ChildNodes[0].Attributes.Count <= 0).ToList();
            List<CCombo> cCombos = new List<CCombo>();
            CCombo ccombo = new CCombo();
            int i = 0;
            int j = 0;
            foreach (HtmlNode node in combos)
            {
                if (i % 2 == 0)
                {
                    ccombo.id = j;
                    ccombo.ccard2Name = node.InnerText;
                }
                else
                {
                    ccombo.id = j;
                    ccombo.card3Name = node.InnerText;
                    byte rarity = 0;
                    byte.TryParse(combosRarities[j].InnerText.Substring(0, 2).Trim(), out rarity);
                    switch (rarity)
                    {
                        case 1: ccombo.card3Rarity = 1; break;
                        case 6: ccombo.card3Rarity = 2; break;
                        case 24: ccombo.card3Rarity = 3; break;
                        case 48: ccombo.card3Rarity = 4; break;
                    }
                    cCombos.Add(ccombo);
                    ccombo = new CCombo();
                    j++;
                }
                i++;
            }
            return cCombos;
        }

        private void LoadHtml(string filename)
        {
            HtmlDocument document = new HtmlDocument();
            document.Load("Resources/Html/" + filename);
        }
    }
}
