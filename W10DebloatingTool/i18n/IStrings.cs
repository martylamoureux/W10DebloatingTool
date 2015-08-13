using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W10DebloatingTool.i18n
{
    public interface IStrings
    {
        string LetsGo { get; }
        string SaveLogs { get; }
        string ChooseLogsPath { get; }

        string Privacy { get; }
        string UseAdsId { get; }
        string AllowSitesToAccessMyLanguage { get; }

        string Applications { get; }
        string RemoveCortana { get; }
        string RemoveOneDrive { get; }
        string Remove3DBuilder { get; }
        string RemoveGetStarted { get; }
        string RemoveOfficeHub { get; }
        string RemoveSolitaire { get; }
        string RemoveSkype { get; }
        string RemoveMaps { get; }
        string RemoveOneNote { get; }
        string RemoveWeather { get; }
        string RemoveSport { get; }
        string RemoveFinance { get; }
        string RemoveNews { get; }
        string RemoveXbox { get; }
        string RemoveMusic { get; }
        string RemoveVideo { get; }
        string RemovePhotos { get; }
        string RemoveCamera { get; }
        string RemoveAlarms { get; }
        string RemoveContacts { get; }
        string RemoveMail { get; }
        string RemovePhoneCompanion { get; }
        string RemoveSoundRecord { get; }
        string RemoveEdge { get; }
        string RemoveAllMetroApps { get; }
        string SelectAllApps { get; }
        string UnselectAllApps { get; }

        string Services { get; }
        string DisableSmartScreen { get; }
        string DisablePhoneServices { get; }
        string DisableBiometricSystem { get; }
        string DisableDiagTrack { get; }
        string DisableAutoLogger { get; }
        string DisableDmwAppPushService { get; }
        string BlockTrackingServers { get; }
        string EnableGodMode { get; }
        string NoTilesOnStartMenu { get; }
        string SearchBar { get; }
        string DisableIt { get; }
        string AsButton { get; }
        string AsBar { get; }

        string Ergonomy { get; }
        string NoLockscreen { get; }

        string NotWindows10Error { get; }
        string Informations { get; }
        string Version { get; }
        string Close { get; }
        string NothingToDo { get; }
        string ProcessingWillTakeAWhile { get; }
        string RestartComputer { get; }
    }
}
