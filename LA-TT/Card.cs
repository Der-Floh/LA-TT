using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LA_TT
{
    public class Card
    {
        public string name { get; set; }
        public byte level { get; set; }
        public byte attack { get; set; }
        public byte defense { get; set; }
        public Image image { get; set; }
        public byte rarity { get; set; }
    }
}
