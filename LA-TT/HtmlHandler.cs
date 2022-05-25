﻿using System;
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
        char c;
        public void DownloadWikiPageHTML()
        {
            for (c = 'A'; c <= 'Z'; c++)
            {
                using (WebClient client = new WebClient())
                {
                    client.DownloadFile(new Uri("https://lil-alchemist.fandom.com/wiki/Category:Card?from=" +c), "Resources/Html/Cards" +c+ ".html");
                    _cardsHtml = new HtmlDocument();
                    _cardsHtml.Load("Resources/Html/Cards" +c+ ".html");
                }
                FindCards();
            }
        }
        public void DownloadCard(string cardUrl, string cardname)
        {
            using (WebClient client = new WebClient())
            {
                try
                {
                    client.DownloadFile(new Uri("https://lil-alchemist.fandom.com" + cardUrl), "Resources/Html/Cards" +c+ "/" +cardname + ".html");
                }
                catch 
                {
                    return;
                }
                _currentCardHtml = new HtmlDocument();
                _currentCardHtml.Load("Resources/Html/Cards" +c+ "/" + cardname + ".html");
            }
            HtmlToCard(cardname);
        }

        public void FindCards()
        {
            HtmlNode region = _cardsHtml.DocumentNode.Descendants("div").Where(node => node.Attributes.Count >= 2 && node.Attributes[0].Name == "id" && node.Attributes[0].Value == "mw-content-text").FirstOrDefault();

            var cards = region.Descendants("a").Where(node => node.Attributes.Count == 3);
            List<string> cardNames = new List<string>();

            foreach (HtmlNode cardName in cards)
            {
                if (!cardName.InnerText.Contains(':'))
                    cardNames.Add(cardName.InnerText);
            }

            foreach (string cardName in cardNames)
            {
                FindCard(cardName);
            }
        }

        public void FindCard(string cardname)
        {
            /*
            HtmlNode link = _cardsHtml.DocumentNode.SelectNodes("//link[@class]").FirstOrDefault();
            string tagClass = link.Attributes["class"].Value;
            */
            HtmlNode node = _cardsHtml.DocumentNode.Descendants().Where(node => node.Attributes.Count >= 2 && node.Attributes[1].Value == cardname).FirstOrDefault();

            //MessageBox.Show(tag.Attributes[1].Value);
            DownloadCard(node.Attributes[0].Value, node.Attributes[1].Value);
        }

        public void HtmlToCard(string cardname)
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
                if (cCombos != null)
                    card.combos = cCombos;
                
                Cards.AddCCard(card);
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
                if (fCombos != null)
                    card.comboCards = fCombos;
               
                Cards.AddFCard(card);
            }


            //MessageBox.Show("Attack: " + attack+ "\nDefense: " +defense+ "\nRarity: " +rarity+ "\nComboCard: " +comboCard+ "\n\n" +fCombos.Count);
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