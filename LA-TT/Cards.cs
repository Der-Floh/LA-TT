using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace LA_TT
{
    public static class Cards
    {
        public static List<CCard> _ccardsB;
        public static List<CCard> _ccardsS;
        public static List<CCard> _ccardsG;
        public static List<CCard> _ccardsD;
        public static List<CCard> _ccardsO;

        public static List<CCard> _yccardsB;
        public static List<CCard> _yccardsS;
        public static List<CCard> _yccardsG;
        public static List<CCard> _yccardsD;
        public static List<CCard> _yccardsO;

        public static List<FCard> _fcardsB;
        public static List<FCard> _fcardsS;
        public static List<FCard> _fcardsG;
        public static List<FCard> _fcardsD;
        public static List<FCard> _fcardsO;

        public static List<FCard> _yfcardsB;
        public static List<FCard> _yfcardsS;
        public static List<FCard> _yfcardsG;
        public static List<FCard> _yfcardsD;
        public static List<FCard> _yfcardsO;

        public static List<Card> _ycards;
        public static List<CCard> _yccards;
        public static List<FCard> _yfcards;

        private static bool ccardsBChanged;
        private static bool ccardsSChanged;
        private static bool ccardsGChanged;
        private static bool ccardsDChanged;
        private static bool ccardsOChanged;

        private static bool yccardsBChanged;
        private static bool yccardsSChanged;
        private static bool yccardsGChanged;
        private static bool yccardsDChanged;
        private static bool yccardsOChanged;

        private static bool fcardsBChanged;
        private static bool fcardsSChanged;
        private static bool fcardsGChanged;
        private static bool fcardsDChanged;
        private static bool fcardsOChanged;

        private static bool yfcardsBChanged;
        private static bool yfcardsSChanged;
        private static bool yfcardsGChanged;
        private static bool yfcardsDChanged;
        private static bool yfcardsOChanged;

        private static System.Timers.Timer writeTimer;

        public static EventHandler OnFinishedInit = delegate { };

        public static async void Init()
        {
            JsonHandler jsonHandler = new JsonHandler();

            _ccardsB = await jsonHandler.GetCCards(false, 1);
            if (_ccardsB == null)
                _ccardsB= new List<CCard>();

            _ccardsS = await jsonHandler.GetCCards(false, 2);
            if (_ccardsS == null)
                _ccardsS = new List<CCard>();

            _ccardsG = await jsonHandler.GetCCards(false, 3);
            if (_ccardsG == null)
                _ccardsG = new List<CCard>();

            _ccardsD = await jsonHandler.GetCCards(false, 4);
            if (_ccardsD == null)
                _ccardsD = new List<CCard>();

            _ccardsO = await jsonHandler.GetCCards(false, 5);
            if (_ccardsO == null)
                _ccardsO = new List<CCard>();

            _yccardsB = await jsonHandler.GetCCards(true, 1);
            if (_yccardsB == null)
                _yccardsB = new List<CCard>();

            _yccardsS = await jsonHandler.GetCCards(true, 2);
            if (_yccardsS == null)
                _yccardsS = new List<CCard>();

            _yccardsG = await jsonHandler.GetCCards(true, 3);
            if (_yccardsG == null)
                _yccardsG = new List<CCard>();

            _yccardsD = await jsonHandler.GetCCards(true, 4);
            if (_yccardsD == null)
                _yccardsD = new List<CCard>();

            _yccardsO = await jsonHandler.GetCCards(true, 5);
            if (_yccardsO == null)
                _yccardsO = new List<CCard>();


            _fcardsB = await jsonHandler.GetFCards(false, 1);
            if (_fcardsB == null)
                _fcardsB = new List<FCard>();

            _fcardsS = await jsonHandler.GetFCards(false, 2);
            if (_fcardsS == null)
                _fcardsS = new List<FCard>();

            _fcardsG = await jsonHandler.GetFCards(false, 3);
            if (_fcardsG == null)
                _fcardsG = new List<FCard>();

            _fcardsD = await jsonHandler.GetFCards(false, 4);
            if (_fcardsD == null)
                _fcardsD = new List<FCard>();

            _fcardsO = await jsonHandler.GetFCards(false, 5);
            if (_fcardsO == null)
                _fcardsO = new List<FCard>();

            _yfcardsB = await jsonHandler.GetFCards(true, 1);
            if (_yfcardsB == null)
                _yfcardsB = new List<FCard>();

            _yfcardsS = await jsonHandler.GetFCards(true, 2);
            if (_yfcardsS == null)
                _yfcardsS = new List<FCard>();

            _yfcardsG = await jsonHandler.GetFCards(true, 3);
            if (_yfcardsG == null)
                _yfcardsG = new List<FCard>();

            _yfcardsD = await jsonHandler.GetFCards(true, 4);
            if (_yfcardsD == null)
                _yfcardsD = new List<FCard>();

            _yfcardsO = await jsonHandler.GetFCards(true, 5);
            if (_yfcardsO == null)
                _yfcardsO = new List<FCard>();

            _yccards = new List<CCard>();
            _yccards.AddRange(_ccardsB);
            _yccards.AddRange(_ccardsS);
            _yccards.AddRange(_ccardsG);
            _yccards.AddRange(_ccardsD);
            _yccards.AddRange(_ccardsO);

            _yfcards = new List<FCard>();
            _yfcards.AddRange(_fcardsB);
            _yfcards.AddRange(_fcardsS);
            _yfcards.AddRange(_fcardsG);
            _yfcards.AddRange(_fcardsD);
            _yfcards.AddRange(_fcardsO);

            _ycards = new List<Card>();
            _ycards.AddRange(_yccards);
            _ycards.AddRange(_yfcards);

            writeTimer = new System.Timers.Timer(60000);
            writeTimer.Elapsed += OnTimeedEvent;
            writeTimer.AutoReset = true;

            FinishedInit();
        }

        public static void OnTimeedEvent(Object source, ElapsedEventArgs e)
        {
            if (ccardsBChanged) WriteCCards(false, 1);
            if (ccardsSChanged) WriteCCards(false, 2);
            if (ccardsGChanged) WriteCCards(false, 3);
            if (ccardsDChanged) WriteCCards(false, 4);
            if (ccardsOChanged) WriteCCards(false, 5);

            if (yccardsBChanged) WriteCCards(true, 1);
            if (yccardsSChanged) WriteCCards(true, 2);
            if (yccardsGChanged) WriteCCards(true, 3);
            if (yccardsDChanged) WriteCCards(true, 4);
            if (yccardsOChanged) WriteCCards(true, 5);

            if (fcardsBChanged) WriteFCards(false, 1);
            if (fcardsSChanged) WriteFCards(false, 2);
            if (fcardsGChanged) WriteFCards(false, 3);
            if (fcardsDChanged) WriteFCards(false, 4);
            if (fcardsOChanged) WriteFCards(false, 5);

            if (yfcardsBChanged) WriteFCards(true, 1);
            if (yfcardsSChanged) WriteFCards(true, 2);
            if (yfcardsGChanged) WriteFCards(true, 3);
            if (yfcardsDChanged) WriteFCards(true, 4);
            if (yfcardsOChanged) WriteFCards(true, 5);
        }

        public static CCard GetCCard(string name, byte rarity)
        {
            switch (rarity)
            {
                case 1: return _ccardsB.Find(c => c.name == name);
                case 2: return _ccardsS.Find(c => c.name == name);
                case 3: return _ccardsG.Find(c => c.name == name);
                case 4: return _ccardsD.Find(c => c.name == name);
                case 5: return _ccardsO.Find(c => c.name == name);
            }
            return null;
        }
        public static FCard GetFCard(string name, byte rarity)
        {
            switch (rarity)
            {
                case 1: return _fcardsB.Find(c => c.name == name);
                case 2: return _fcardsS.Find(c => c.name == name);
                case 3: return _fcardsG.Find(c => c.name == name);
                case 4: return _fcardsD.Find(c => c.name == name);
                case 5: return _fcardsO.Find(c => c.name == name);
            }
            return null;
        }

        public static async void AddCCard(CCard ccard)
        {
            switch (ccard.rarity)
            {
                case 1:
                    _ccardsB.Add(ccard);
                    ccardsBChanged = true;
                    break;
                case 2:
                    _ccardsS.Add(ccard);
                    ccardsSChanged = true;
                    break;
                case 3:
                    _ccardsG.Add(ccard);
                    ccardsGChanged = true;
                    break;
                case 4:
                    _ccardsD.Add(ccard);
                    ccardsDChanged = true;
                    break;
                case 5:
                    _ccardsO.Add(ccard);
                    ccardsOChanged = true;
                    break;
            }
        }

        public static async void AddFCard(FCard fcard)
        {
            switch (fcard.rarity)
            {
                case 1:
                    _fcardsB.Add(fcard);
                    ccardsBChanged = true;
                    break;
                case 2:
                    _fcardsS.Add(fcard);
                    ccardsSChanged = true;
                    break;
                case 3:
                    _fcardsG.Add(fcard);
                    ccardsGChanged = true;
                    break;
                case 4:
                    _fcardsD.Add(fcard);
                    ccardsDChanged = true;
                    break;
                case 5:
                    _fcardsO.Add(fcard);
                    ccardsOChanged = true;
                    break;
            }
        }

        public static async void WriteCCards(bool your, byte rarity)
        {
            JsonHandler jsonHandler = new JsonHandler();
            if (your)
            {
                switch (rarity)
                {
                    case 1: await jsonHandler.WriteCCards(_ccardsB, your, rarity); break;
                    case 2: await jsonHandler.WriteCCards(_ccardsS, your, rarity); break;
                    case 3: await jsonHandler.WriteCCards(_ccardsG, your, rarity); break;
                    case 4: await jsonHandler.WriteCCards(_ccardsD, your, rarity); break;
                    case 5: await jsonHandler.WriteCCards(_ccardsO, your, rarity); break;
                }
            }
            else
            {
                switch (rarity)
                {
                    case 1: await jsonHandler.WriteCCards(_yccardsB, your, rarity); break;
                    case 2: await jsonHandler.WriteCCards(_yccardsS, your, rarity); break;
                    case 3: await jsonHandler.WriteCCards(_yccardsG, your, rarity); break;
                    case 4: await jsonHandler.WriteCCards(_yccardsD, your, rarity); break;
                    case 5: await jsonHandler.WriteCCards(_yccardsO, your, rarity); break;
                }
            }
            ccardsBChanged = false;
        }
        public static async void WriteFCards(bool your, byte rarity)
        {
            JsonHandler jsonHandler = new JsonHandler();
            if (your)
            {
                switch (rarity)
                {
                    case 1: await jsonHandler.WriteFCards(_fcardsB, your, rarity); break;
                    case 2: await jsonHandler.WriteFCards(_fcardsS, your, rarity); break;
                    case 3: await jsonHandler.WriteFCards(_fcardsG, your, rarity); break;
                    case 4: await jsonHandler.WriteFCards(_fcardsD, your, rarity); break;
                    case 5: await jsonHandler.WriteFCards(_fcardsO, your, rarity); break;
                }
            }
            else
            {
                switch (rarity)
                {
                    case 1: await jsonHandler.WriteFCards(_yfcardsB, your, rarity); break;
                    case 2: await jsonHandler.WriteFCards(_yfcardsS, your, rarity); break;
                    case 3: await jsonHandler.WriteFCards(_yfcardsG, your, rarity); break;
                    case 4: await jsonHandler.WriteFCards(_yfcardsD, your, rarity); break;
                    case 5: await jsonHandler.WriteFCards(_yfcardsO, your, rarity); break;
                }
            }
            fcardsBChanged = false;
        }

        private static void FinishedInit()
        {
            //MessageBox.Show("Event");
            EventHandler handler = OnFinishedInit;
            if (handler != null)
            {
                //MessageBox.Show("Event != null");
                handler(null, EventArgs.Empty);
            }
        }
    }
}
