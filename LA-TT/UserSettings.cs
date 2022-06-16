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
        public static int attackMultiplier { get; set; }
        public static int defenseMultiplier { get; set; }

        public static void Init()
        {
            JsonHandler jsonHandler = new JsonHandler();
            settings = jsonHandler.GetSettings();

            if (settings == null)
            {
                settings = new Settings();
                settings.mainWindowLocation = new Point();
                settings.mainWindowSize = new Size();
                settings.addCardWindowLocation = new Point();
                settings.addCardWindowSize = new Size();
                settings.settingsWindowLocation = new Point();
                settings.settingsWindowSize = new Size();

                settings.askForSync = true;
                settings.attackMultiplier = 2;
                settings.defenseMultiplier = 1;
            }
            mainWindowLocation = settings.mainWindowLocation;
            mainWindowSize = settings.mainWindowSize;
            addCardWindowLocation = settings.addCardWindowLocation;
            addCardWindowSize = settings.addCardWindowSize;
            settingsWindowLocation = settings.settingsWindowLocation;
            settingsWindowSize = settings.settingsWindowSize;

            askForSync = settings.askForSync;
            attackMultiplier = settings.attackMultiplier;
            defenseMultiplier = settings.defenseMultiplier;
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
            settings.attackMultiplier = attackMultiplier;
            settings.defenseMultiplier = defenseMultiplier;

            JsonHandler jsonHandler = new JsonHandler();
            jsonHandler.WriteSettings(settings);
        }
    }
}
