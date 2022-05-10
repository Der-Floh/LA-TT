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
        public CCard comboCard1 { get; set; }
        public CCard ComboCard2 { get; set; }
    }
}
