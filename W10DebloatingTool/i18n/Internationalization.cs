using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using W10DebloatingTool.Properties;

namespace W10DebloatingTool.i18n
{
    class Internationalization
    {

        public static Dictionary<string, string> Languages => new Dictionary<string, string>
        {
            {"en", "English" },
            {"fr", "Français" }
        };

        public static IStrings Strings
        {
            get
            {
                if (Settings.Default.Language == "fr")
                    return new StringsFr();
                return new StringsEn();
            }
        }

        public static CultureInfo CurrentCulture
        {
            get
            {
                if (Settings.Default.Language == "fr")
                    return new CultureInfo("fr");
                return new CultureInfo("en");
            }
        }

        public static void SetSystemLanguage()
        {
            CultureInfo currentCulture = Thread.CurrentThread.CurrentCulture;
            if (currentCulture.TwoLetterISOLanguageName == "fr")
                SetLanguage("fr");
            else
                SetLanguage("en");
        }

        public static void SetLanguage(string lang)
        {
            Settings.Default.Language = lang;
            Settings.Default.Save();
        }

        public static string CurrentLanguageCode => Settings.Default.Language;

        public static string CurrentLanguageName => Languages[Settings.Default.Language];
    }
}
