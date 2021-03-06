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
        public static List<Card> _ycardsFiltered;
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

        public static bool writing;

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

            //Change _ccards to _yccards
            _yccards = new List<CCard>();
            _yccards.AddRange(_yccardsB);
            _yccards.AddRange(_yccardsS);
            _yccards.AddRange(_yccardsG);
            _yccards.AddRange(_yccardsD);
            _yccards.AddRange(_yccardsO);

            _yfcards = new List<FCard>();
            _yfcards.AddRange(_yfcardsB);
            _yfcards.AddRange(_yfcardsS);
            _yfcards.AddRange(_yfcardsG);
            _yfcards.AddRange(_yfcardsD);
            _yfcards.AddRange(_yfcardsO);

            _ycards = new List<Card>();
            _ycards.AddRange(_yccards);
            _ycards.AddRange(_yfcards);

            _ycardsFiltered = new List<Card>();
            _ycardsFiltered = _ycards;

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

        public static CCard GetCCard(string name, byte rarity, bool your)
        {
            if (!your)
            {
                switch (rarity)
                {
                    case 1: return _ccardsB.Find(c => c.name == name);
                    case 2: return _ccardsS.Find(c => c.name == name);
                    case 3: return _ccardsG.Find(c => c.name == name);
                    case 4: return _ccardsD.Find(c => c.name == name);
                    case 5: return _ccardsO.Find(c => c.name == name);
                }
            }
            else
            {
                switch (rarity)
                {
                    case 1: return _yccardsB.Find(c => c.name == name);
                    case 2: return _yccardsS.Find(c => c.name == name);
                    case 3: return _yccardsG.Find(c => c.name == name);
                    case 4: return _yccardsD.Find(c => c.name == name);
                    case 5: return _yccardsO.Find(c => c.name == name);
                }
            }
            return null;
        }
        public static CCard GetCCard(string name, bool your)
        {
            CCard ccard = null;
            if (!your)
            {
                ccard = _ccardsB.Find(c => c.name == name);
                if (ccard != null) return ccard;
                ccard = _ccardsS.Find(c => c.name == name);
                if (ccard != null) return ccard;
                ccard = _ccardsG.Find(c => c.name == name);
                if (ccard != null) return ccard;
                ccard = _ccardsD.Find(c => c.name == name);
                if (ccard != null) return ccard;
                ccard = _ccardsO.Find(c => c.name == name);
                if (ccard != null) return ccard;
            }
            else
            {
                ccard = _yccardsB.Find(c => c.name == name);
                if (ccard != null) return ccard;
                ccard = _yccardsS.Find(c => c.name == name);
                if (ccard != null) return ccard;
                ccard = _yccardsG.Find(c => c.name == name);
                if (ccard != null) return ccard;
                ccard = _yccardsD.Find(c => c.name == name);
                if (ccard != null) return ccard;
                ccard = _yccardsO.Find(c => c.name == name);
                if (ccard != null) return ccard;
            }
            return null;
        }
        public static FCard GetFCard(string name, byte rarity, bool your)
        {
            if (!your)
            {
                switch (rarity)
                {
                    case 1: return _fcardsB.Find(c => c.name == name);
                    case 2: return _fcardsS.Find(c => c.name == name);
                    case 3: return _fcardsG.Find(c => c.name == name);
                    case 4: return _fcardsD.Find(c => c.name == name);
                    case 5: return _fcardsO.Find(c => c.name == name);
                }
            }
            else
            {
                switch (rarity)
                {
                    case 1: return _yfcardsB.Find(c => c.name == name);
                    case 2: return _yfcardsS.Find(c => c.name == name);
                    case 3: return _yfcardsG.Find(c => c.name == name);
                    case 4: return _yfcardsD.Find(c => c.name == name);
                    case 5: return _yfcardsO.Find(c => c.name == name);
                }
            }
            return null;
        }
        public static FCard GetFCard(string name, bool your)
        {
            FCard fcard = null;
            if (!your)
            {
                fcard = _fcardsB.Find(c => c.name == name);
                if (fcard != null) return fcard;
                fcard = _fcardsS.Find(c => c.name == name);
                if (fcard != null) return fcard;
                fcard = _fcardsG.Find(c => c.name == name);
                if (fcard != null) return fcard;
                fcard = _fcardsD.Find(c => c.name == name);
                if (fcard != null) return fcard;
                fcard = _fcardsO.Find(c => c.name == name);
                if (fcard != null) return fcard;
            }
            else
            {
                fcard = _yfcardsB.Find(c => c.name == name);
                if (fcard != null) return fcard;
                fcard = _yfcardsS.Find(c => c.name == name);
                if (fcard != null) return fcard;
                fcard = _yfcardsG.Find(c => c.name == name);
                if (fcard != null) return fcard;
                fcard = _yfcardsD.Find(c => c.name == name);
                if (fcard != null) return fcard;
                fcard = _yfcardsO.Find(c => c.name == name);
                if (fcard != null) return fcard;
            }
            return null;
        }

        public static async void AddCCard(CCard ccard, bool your)
        {
            if (!your)
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
            else
            {
                switch (ccard.rarity)
                {
                    case 1:
                        _yccardsB.Add(ccard);
                        yccardsBChanged = true;
                        break;
                    case 2:
                        _yccardsS.Add(ccard);
                        yccardsSChanged = true;
                        break;
                    case 3:
                        _yccardsG.Add(ccard);
                        yccardsGChanged = true;
                        break;
                    case 4:
                        _yccardsD.Add(ccard);
                        yccardsDChanged = true;
                        break;
                    case 5:
                        _yccardsO.Add(ccard);
                        yccardsOChanged = true;
                        break;
                }
                _yccards.Add(ccard);
                _ycards.Add(ccard);
            }
        }

        public static async void AddFCard(FCard fcard, bool your)
        {
            if (!your)
            {
                switch (fcard.rarity)
                {
                    case 1:
                        _fcardsB.Add(fcard);
                        fcardsBChanged = true;
                        break;
                    case 2:
                        _fcardsS.Add(fcard);
                        fcardsSChanged = true;
                        break;
                    case 3:
                        _fcardsG.Add(fcard);
                        fcardsGChanged = true;
                        break;
                    case 4:
                        _fcardsD.Add(fcard);
                        fcardsDChanged = true;
                        break;
                    case 5:
                        _fcardsO.Add(fcard);
                        fcardsOChanged = true;
                        break;
                }
            }
            else
            {
                switch (fcard.rarity)
                {
                    case 1:
                        _yfcardsB.Add(fcard);
                        yfcardsBChanged = true;
                        break;
                    case 2:
                        _yfcardsS.Add(fcard);
                        yfcardsSChanged = true;
                        break;
                    case 3:
                        _yfcardsG.Add(fcard);
                        yfcardsGChanged = true;
                        break;
                    case 4:
                        _yfcardsD.Add(fcard);
                        yfcardsDChanged = true;
                        break;
                    case 5:
                        _yfcardsO.Add(fcard);
                        yfcardsOChanged = true;
                        break;
                }
                _yfcards.Add(fcard);
                _ycards.Add(fcard);
            }
        }

        public static async Task WriteCCards(bool your, byte rarity)
        {
            JsonHandler jsonHandler = new JsonHandler();
            if (!your)
            {
                switch (rarity)
                {
                    case 1: if (ccardsBChanged && _ccardsB.Count != 0)
                        {
                            _ccardsB = _ccardsB.OrderBy(c => c.name).ToList();
                            await jsonHandler.WriteCCards(_ccardsB, your, rarity);
                            ccardsBChanged = false;
                        }
                        break;
                    case 2: if (ccardsSChanged && _ccardsS.Count != 0)
                        {
                            _ccardsS = _ccardsS.OrderBy(c => c.name).ToList();
                            await jsonHandler.WriteCCards(_ccardsS, your, rarity);
                            ccardsSChanged = false;
                        }
                        break;
                    case 3: if (ccardsGChanged && _ccardsG.Count != 0) 
                        {
                            _ccardsG = _ccardsG.OrderBy(c => c.name).ToList();
                            await jsonHandler.WriteCCards(_ccardsG, your, rarity); 
                            ccardsGChanged = false;
                        }
                        break;
                    case 4: if (ccardsDChanged && _ccardsD.Count != 0) 
                        {
                            _ccardsD = _ccardsD.OrderBy(c => c.name).ToList();
                            await jsonHandler.WriteCCards(_ccardsD, your, rarity); 
                            ccardsDChanged = false;
                        }
                        break;
                    case 5: if (ccardsOChanged && _ccardsO.Count != 0) 
                        {
                            _ccardsO = _ccardsO.OrderBy(c => c.name).ToList();
                            await jsonHandler.WriteCCards(_ccardsO, your, rarity); 
                            ccardsOChanged = false;
                        }
                        break;
                }
            }
            else
            {
                switch (rarity)
                {
                    case 1: if (yccardsBChanged && _yccardsB.Count != 0)
                        {
                            _yccardsB = _yccardsB.OrderBy(c => c.name).ToList();
                            await jsonHandler.WriteCCards(_yccardsB, your, rarity);
                            yccardsBChanged = false;
                        }
                        break;
                    case 2: if (yccardsSChanged && _yccardsS.Count != 0) 
                        {
                            _yccardsS = _yccardsS.OrderBy(c => c.name).ToList();
                            await jsonHandler.WriteCCards(_yccardsS, your, rarity);
                            yccardsSChanged = false;
                        }
                        break;
                    case 3: if (yccardsGChanged && _yccardsG.Count != 0) 
                        {
                            _yccardsG = _yccardsG.OrderBy(c => c.name).ToList();
                            await jsonHandler.WriteCCards(_yccardsG, your, rarity);
                            yccardsGChanged = false;
                        }
                        break;
                    case 4: if (yccardsDChanged && _yccardsD.Count != 0) 
                        {
                            _yccardsD = _yccardsD.OrderBy(c => c.name).ToList();
                            await jsonHandler.WriteCCards(_yccardsD, your, rarity);
                            yccardsDChanged = false;
                        }
                        break;
                    case 5: if (yccardsOChanged && _yccardsO.Count != 0) 
                        {
                            _yccardsO = _yccardsO.OrderBy(c => c.name).ToList();
                            await jsonHandler.WriteCCards(_yccardsO, your, rarity);
                            yccardsOChanged = false;
                        }
                        break;
                }
            }
        }
        public static async Task WriteFCards(bool your, byte rarity)
        {
            JsonHandler jsonHandler = new JsonHandler();
            if (!your)
            {
                switch (rarity)
                {
                    case 1: if (fcardsBChanged && _fcardsB.Count != 0)
                        {
                            _fcardsB = _fcardsB.OrderBy(c => c.name).ToList();
                            await jsonHandler.WriteFCards(_fcardsB, your, rarity);
                            fcardsBChanged = false;
                        }
                        break;
                    case 2: if (fcardsSChanged && _fcardsS.Count != 0) 
                        {
                            _fcardsS = _fcardsS.OrderBy(c => c.name).ToList();
                            await jsonHandler.WriteFCards(_fcardsS, your, rarity);
                            fcardsSChanged = false;
                        }
                        break;
                    case 3: if (fcardsDChanged && _fcardsG.Count != 0) 
                        {
                            _fcardsG = _fcardsG.OrderBy(c => c.name).ToList();
                            await jsonHandler.WriteFCards(_fcardsG, your, rarity);
                            fcardsGChanged = false;
                        }
                        break;
                    case 4: if (fcardsGChanged && _fcardsD.Count != 0) 
                        {
                            _fcardsD = _fcardsD.OrderBy(c => c.name).ToList();
                            await jsonHandler.WriteFCards(_fcardsD, your, rarity);
                            fcardsDChanged = false;
                        }
                        break;
                    case 5: if (fcardsOChanged && _fcardsO.Count != 0) 
                        {
                            _fcardsO = _fcardsO.OrderBy(c => c.name).ToList();
                            await jsonHandler.WriteFCards(_fcardsO, your, rarity);
                            fcardsOChanged = false;
                        }
                        break;
                }
            }
            else
            {
                switch (rarity)
                {
                    case 1: if (yfcardsBChanged && _yfcardsB.Count != 0) 
                        {
                            _yfcardsB = _yfcardsB.OrderBy(c => c.name).ToList();
                            await jsonHandler.WriteFCards(_yfcardsB, your, rarity);
                            yfcardsBChanged = false;
                        }
                        break;
                    case 2: if (yfcardsSChanged && _yfcardsS.Count != 0) 
                        {
                            _yfcardsS = _yfcardsS.OrderBy(c => c.name).ToList();
                            await jsonHandler.WriteFCards(_yfcardsS, your, rarity);
                            yfcardsSChanged = false;
                        }
                        break;
                    case 3: if (yfcardsGChanged && _yfcardsG.Count != 0) 
                        {
                            _yfcardsG = _yfcardsG.OrderBy(c => c.name).ToList();
                            await jsonHandler.WriteFCards(_yfcardsG, your, rarity);
                            yfcardsGChanged = false;
                        }
                        break;
                    case 4: if (yfcardsDChanged && _yfcardsD.Count != 0) 
                        {
                            _yfcardsD = _yfcardsD.OrderBy(c => c.name).ToList();
                            await jsonHandler.WriteFCards(_yfcardsD, your, rarity);
                            yfcardsDChanged = false;
                        }
                        break;
                    case 5: if (yfcardsOChanged && _yfcardsO.Count != 0) 
                        {
                            _yfcardsO = _yfcardsO.OrderBy(c => c.name).ToList();
                            await jsonHandler.WriteFCards(_yfcardsO, your, rarity);
                            yfcardsOChanged = false;
                        }
                        break;
                }
            }
        }

        public static void UpdateCCard(CCard ccard, bool your)
        {
            if (!your)
            {
                switch (ccard.rarity)
                {
                    case 1:
                        if (_ccardsB.Remove(_ccardsB.Find(c => c.name == ccard.name)))
                        {
                            _ccardsB.Add(ccard);
                            ccardsBChanged = true;
                        }
                        break;
                    case 2:
                        if (_ccardsS.Remove(_ccardsS.Find(c => c.name == ccard.name)))
                        {
                            _ccardsS.Add(ccard);
                            ccardsSChanged = true;
                        }
                        break;
                    case 3:
                        if (_ccardsG.Remove(_ccardsG.Find(c => c.name == ccard.name)))
                        {
                            _ccardsG.Add(ccard);
                            ccardsGChanged = true;
                        }
                        break;
                    case 4:
                        if (_ccardsD.Remove(_ccardsD.Find(c => c.name == ccard.name)))
                        {
                            _ccardsD.Add(ccard);
                            ccardsDChanged = true;
                        }
                        break;
                    case 5:
                        if (_ccardsO.Remove(_ccardsO.Find(c => c.name == ccard.name)))
                        {
                            _ccardsO.Add(ccard);
                            ccardsOChanged = true;
                        }
                        break;
                }
            }
            else
            {
                switch (ccard.rarity)
                {
                    case 1:
                        if (_yccardsB.Remove(_yccardsB.Find(c => c.name == ccard.name)))
                        {
                            _yccardsB.Add(ccard);
                            yccardsBChanged = true;
                        }
                        break;
                    case 2:
                        if (_yccardsS.Remove(_yccardsS.Find(c => c.name == ccard.name)))
                        {
                            _yccardsS.Add(ccard);
                            yccardsSChanged = true;
                        }
                        break;
                    case 3:
                        if (_yccardsG.Remove(_yccardsG.Find(c => c.name == ccard.name)))
                        {
                            _yccardsG.Add(ccard);
                            yccardsGChanged = true;
                        }
                        break;
                    case 4:
                        if (_yccardsD.Remove(_yccardsD.Find(c => c.name == ccard.name)))
                        {
                            _yccardsD.Add(ccard);
                            yccardsDChanged = true;
                        }
                        break;
                    case 5:
                        if (_yccardsO.Remove(_yccardsO.Find(c => c.name == ccard.name)))
                        {
                            _yccardsO.Add(ccard);
                            yccardsOChanged = true;
                        }
                        break;
                }
            }
        }

        public static void UpdateFCard(FCard fcard, bool your)
        {
            if (!your)
            {
                switch (fcard.rarity)
                {
                    case 1:
                        if (_fcardsB.Remove(_fcardsB.Find(c => c.name == fcard.name)))
                        {
                            _fcardsB.Add(fcard);
                            fcardsBChanged = true;
                        }
                        break;
                    case 2:
                        if (_fcardsS.Remove(_fcardsS.Find(c => c.name == fcard.name)))
                        {
                            _fcardsS.Add(fcard);
                            fcardsSChanged = true;
                        }
                        break;
                    case 3:
                        if (_fcardsG.Remove(_fcardsG.Find(c => c.name == fcard.name)))
                        {
                            _fcardsG.Add(fcard);
                            fcardsGChanged = true;
                        }
                        break;
                    case 4:
                        if (_fcardsD.Remove(_fcardsD.Find(c => c.name == fcard.name)))
                        {
                            _fcardsD.Add(fcard);
                            fcardsDChanged = true;
                        }
                        break;
                    case 5:
                        if (_fcardsO.Remove(_fcardsO.Find(c => c.name == fcard.name)))
                        {
                            _fcardsO.Add(fcard);
                            fcardsOChanged = true;
                        }
                        break;
                }
            }
            else
            {
                switch (fcard.rarity)
                {
                    case 1:
                        if (_yfcardsB.Remove(_yfcardsB.Find(c => c.name == fcard.name)))
                        {
                            _yfcardsB.Add(fcard);
                            yfcardsBChanged = true;
                        }
                        break;
                    case 2:
                        if (_yfcardsS.Remove(_yfcardsS.Find(c => c.name == fcard.name)))
                        {
                            _yfcardsS.Add(fcard);
                            yfcardsSChanged = true;
                        }
                        break;
                    case 3:
                        if (_yfcardsG.Remove(_yfcardsG.Find(c => c.name == fcard.name)))
                        {
                            _yfcardsG.Add(fcard);
                            yfcardsGChanged = true;
                        }
                        break;
                    case 4:
                        if (_yfcardsD.Remove(_yfcardsD.Find(c => c.name == fcard.name)))
                        {
                            _yfcardsD.Add(fcard);
                            yfcardsDChanged = true;
                        }
                        break;
                    case 5:
                        if (_yfcardsO.Remove(_yfcardsO.Find(c => c.name == fcard.name)))
                        {
                            _yfcardsO.Add(fcard);
                            yfcardsOChanged = true;
                        }
                        break;
                }
            }
        }

        private static void FinishedInit()
        {
            EventHandler handler = OnFinishedInit;
            if (handler != null)
            {
                handler(null, EventArgs.Empty);
            }
        }
    }
}
