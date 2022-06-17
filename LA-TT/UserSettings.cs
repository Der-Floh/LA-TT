using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace LA_TT
{
    public static class UserSettings
    {
        private static Settings settings;
        public static Point mainWindowLocation { get; set; }
        public static Size mainWindowSize { get; set; }
        public static Point addCardWindowLocation { get; set; }
        public static Size addCardWindowSize { get; set; }
        public static Point settingsWindowLocation { get; set; }
        public static Size settingsWindowSize { get; set; }

        public static bool askForSync { get; set; }
        public static bool sync { get; set; }
        public static bool saveYourCards { get; set; }
        public static bool comboSatsYour { get; set; }
        public static bool skipDownload { get; set; }
        public static bool deleteAfterDownload { get; set; }
        public static bool preferAttack { get; set; }
        public static bool preferDefense { get; set; }
        public static int attackMultiplier { get; set; }
        public static int defenseMultiplier { get; set; }
        public static string wikiUrl { get; set; }

        public static void Init()
        {
            JsonHandler jsonHandler = new JsonHandler();
            settings = jsonHandler.GetSettings();

            if (settings == null)
            {
                settings = GetDefaultSettings();
            }
            SetThisToSettings();
        }

        private static void SetThisToSettings()
        {
            mainWindowLocation = settings.mainWindowLocation;
            mainWindowSize = settings.mainWindowSize;
            addCardWindowLocation = settings.addCardWindowLocation;
            addCardWindowSize = settings.addCardWindowSize;
            settingsWindowLocation = settings.settingsWindowLocation;
            settingsWindowSize = settings.settingsWindowSize;

            askForSync = settings.askForSync;
            sync = settings.sync;
            saveYourCards = settings.saveYourCards;
            comboSatsYour = settings.comboStatsYour;
            skipDownload = settings.skipDownload;
            deleteAfterDownload = settings.deleteAfterDownload;
            preferAttack = settings.preferAttack;
            preferDefense = settings.preferDefense;
            attackMultiplier = settings.attackMultiplier;
            defenseMultiplier = settings.defenseMultiplier;
            wikiUrl = settings.wikiUrl;
        }

        private static Settings GetDefaultSettings()
        {
            Settings defaultSettings = new Settings
            {
                mainWindowLocation = new Point(),
                mainWindowSize = new Size(),
                addCardWindowLocation = new Point(),
                addCardWindowSize = new Size(),
                settingsWindowLocation = new Point(),
                settingsWindowSize = new Size(),

                askForSync = true,
                sync = false,
                saveYourCards = false,
                comboStatsYour = true,
                skipDownload = true,
                deleteAfterDownload = false,
                preferAttack = true,
                preferDefense = false,
                attackMultiplier = 2,
                defenseMultiplier = 1,
                wikiUrl = "https://lil-alchemist.fandom.com",
            };
            return defaultSettings;
        }

        public static void ResetToDefault()
        {
            settings = GetDefaultSettings();
            SetThisToSettings();
        }

        public static void Save()
        {
            settings.mainWindowLocation = mainWindowLocation;
            settings.mainWindowSize = mainWindowSize;
            settings.addCardWindowLocation = addCardWindowLocation;
            settings.addCardWindowSize = addCardWindowSize;
            settings.settingsWindowLocation = settingsWindowLocation;
            settings.settingsWindowSize = settingsWindowSize;

            settings.askForSync = askForSync;
            settings.sync = sync;
            settings.saveYourCards = saveYourCards;
            settings.skipDownload = skipDownload;
            settings.deleteAfterDownload = deleteAfterDownload;
            settings.preferAttack = preferAttack;
            settings.preferDefense = preferDefense;
            settings.attackMultiplier = attackMultiplier;
            settings.defenseMultiplier = defenseMultiplier;
            settings.wikiUrl = wikiUrl;

            JsonHandler jsonHandler = new JsonHandler();
            jsonHandler.WriteSettings(settings);
        }
    }
}
