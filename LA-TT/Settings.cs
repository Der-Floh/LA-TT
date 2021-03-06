using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LA_TT
{
    public class Settings
    {
        public Point mainWindowLocation { get; set; }
        public Size mainWindowSize { get; set; }
        public Point addCardWindowLocation { get; set; }
        public Size addCardWindowSize { get; set; }
        public Point settingsWindowLocation { get; set; }
        public Size settingsWindowSize { get; set; }

        public bool askForSync { get; set; }
        public bool sync { get; set; }
        public bool saveYourCards { get; set; }
        public bool comboStatsYour { get; set; }
        public bool skipDownload { get; set; }
        public bool deleteAfterDownload { get; set; }
        public bool preferAttack { get; set; }
        public bool preferDefense { get; set; }
        public int attackMultiplier { get; set; }
        public int defenseMultiplier { get; set; }
        public string wikiUrl { get; set; }
    }
}
