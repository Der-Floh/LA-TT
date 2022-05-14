using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LA_TT
{
    public class CCard : Card
    {
        public Dictionary<Card, Card> comboCards { get; set; }
        public Dictionary<Card, Card> combos { get; set; }

        public CCard()
        {
            comboCards = new Dictionary<Card, Card>();
            combos = new Dictionary<Card, Card>();
        }
    }
}
