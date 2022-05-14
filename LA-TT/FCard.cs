using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LA_TT
{
    public class FCard : Card
    {
        public string special { get; set; }
        public Dictionary<CCard, CCard> comboCards { get; set; }

        public FCard()
        {
            comboCards = new Dictionary<CCard, CCard>();
        }
    }
}
