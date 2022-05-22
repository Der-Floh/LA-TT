using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LA_TT
{
    public class CCard : Card
    {
        //public Dictionary<CCard, CCard> comboCards { get; set; }
        //public Dictionary<CCard, Card> combos { get; set; }
        //public List<FCombo> comboCards { get; set; }
        public List<CCombo> combos { get; set; }
        public int comboStatSum { get; set; }

        public CCard()
        {
            //comboCards = new Dictionary<CCard, CCard>();
            //combos = new Dictionary<CCard, Card>();
            //comboCards = new List<FCombo>();
            combos = new List<CCombo>();
        }
    }
}
