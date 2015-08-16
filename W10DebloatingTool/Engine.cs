using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Management.Automation;
using System.Text;
using System.Windows.Forms;
using Microsoft.Win32;
using W10DebloatingTool.i18n;

namespace W10DebloatingTool
{
    public class Engine
    {
        private string[] tags;
        private readonly bool saveLogs;
        private DateTime executionTime = DateTime.Now;

        private StringBuilder log = new StringBuilder();

        public Engine(string[] tags, bool saveLogs)
        {
            this.tags = tags;
            this.saveLogs = saveLogs;
        }

        protected void WriteLog(string text)
        {
            if (!saveLogs)
                return;
            log.AppendLine(string.Format("[{0} {1}] {2}", DateTime.Now.ToShortDateString(),
                DateTime.Now.ToLongTimeString(), text));
        }

        protected void FlushLog()
        {
            if (!saveLogs)
                return;
            string filename = string.Format("W10DT_{0}_{1}.txt", DateTime.Now.ToShortDateString().Replace('/', '-'),
                DateTime.Now.ToLongTimeString().Replace(':', '-'));
            System.IO.File.WriteAllText(System.IO.Path.Combine(Properties.Settings.Default.LogsPath, filename), log.ToString());
            log.Clear();
        }

        public void Run(Form parent)
        {
            if (tags.Length == 0)
                return;
            executionTime = DateTime.Now;
            WriteLog("== Started execution");
            foreach (string tag in tags)
                RunTag(tag);
            WriteLog("== Finished execution");
            FlushLog();
        }

        public void RunTag(string tag)
        {
            WriteLog("==== Running " + tag);
            switch (tag)
            {
                case "remove_cortana":
                    EditRegistry(Registry.LocalMachine,
                        @"SOFTWARE\Policies\Microsoft\Windows\Windows Search", "AlowCortana", 0);
                    break;
                case "remove_oneDrive":
                    RunBatch("@echo off cls set x86=\"%SYSTEMROOT%\\System32\\OneDriveSetup.exe\" set x64=\"%SYSTEMROOT%\\SysWOW64\\OneDriveSetup.exe\" echo Closing OneDrive process. echo. taskkill /f /im OneDrive.exe > NUL 2>&1 ping 127.0.0.1 -n 5 > NUL 2>&1 echo Uninstalling OneDrive. echo. if exist %x64% ( %x64% /uninstall ) else ( %x86% /uninstall ) ping 127.0.0.1 -n 5 > NUL 2>&1 echo Removing OneDrive leftovers. echo. rd \"%USERPROFILE%\\OneDrive\" /Q /S > NUL 2>&1 rd \"C:\\OneDriveTemp\" /Q /S > NUL 2>&1 rd \"%LOCALAPPDATA%\\Microsoft\\OneDrive\" /Q /S > NUL 2>&1 rd \"%PROGRAMDATA%\\Microsoft OneDrive\" /Q /S > NUL 2>&1 echo Removeing OneDrive from the Explorer Side Panel. echo. REG DELETE \"HKEY_CLASSES_ROOT\\CLSID\\{018D5C66-4533-4307-9B53-224DE2ED1FE6}\" /f > NUL 2>&1 REG DELETE \"HKEY_CLASSES_ROOT\\Wow6432Node\\CLSID\\{018D5C66-4533-4307-9B53-224DE2ED1FE6}\" /f > NUL 2>&1");
                    break;
                case "remove_builder":
                    RemoveMetroApp("Microsoft.3DBuilder");
                    break;
                case "remove_getStarted":
                    RemoveMetroApp("Microsoft.Getstarted");
                    break;
                case "remove_officeHub":
                    RemoveMetroApp("Microsoft.MicrosoftOfficeHub");
                    break;
                case "remove_solitaire":
                    RemoveMetroApp("Microsoft.MicrosoftSolitaireCollection");
                    break;
                case "remove_skype":
                    RemoveMetroApp("Microsoft.SkypeApp");
                    break;
                case "remove_maps":
                    RemoveMetroApp("Microsoft.WindowsMaps");
                    break;
                case "remove_onenote":
                    RemoveMetroApp("Microsoft.Office.OneNote");
                    break;
                case "remove_weather":
                    RemoveMetroApp("Microsoft.BingWeather");
                    break;
                case "remove_sport":
                    RemoveMetroApp("Microsoft.BingSports");
                    break;
                case "remove_finance":
                    RemoveMetroApp("Microsoft.BingFinance");
                    break;
                case "remove_news":
                    RemoveMetroApp("Microsoft.BingNews");
                    break;
                case "remove_xbox":
                    RemoveMetroApp("Microsoft.XboxApp");
                    break;
                case "remove_music":
                    RemoveMetroApp("Microsoft.ZuneMusic");
                    break;
                case "remove_films":
                    RemoveMetroApp("Microsoft.ZuneVideo");
                    break;
                case "remove_photos":
                    RemoveMetroApp("Microsoft.Windows.Photos");
                    break;
                case "remove_camera":
                    RemoveMetroApp("Microsoft.WindowsCamera");
                    break;
                case "remove_alarms":
                    RemoveMetroApp("Microsoft.WindowsAlarms");
                    break;
                case "remove_contacts":
                    RemoveMetroApp("Microsoft.People");
                    break;
                case "remove_mail":
                    RunPowershell("Get-AppxPackage *communi* | Remove-AppxPackage");
                    break;
                case "remove_phoneCompanion":
                    RemoveMetroApp("Microsoft.WindowsPhone");
                    break;
                case "remove_soundRecord":
                    RemoveMetroApp("Microsoft.WindowsSoundRecorder");
                    break;
                case "remove_edge":
                    RunPowershell("Get-AppxPackage | Remove-AppxPackage");
                    break;
                case "no_lockscreen":
                    EditRegistry(Registry.LocalMachine,
                        @"SOFTWARE\Policies\Microsoft\Windows\Personalization", "NoLockScreen", 1);
                    break;
                case "use_ads_id":
                    EditRegistry(Registry.CurrentUser,
                        @"SOFTWARE\Microsoft\Windows\CurrentVersion\AdvertisingInfo", "Enabled", 0);
                    break;
                case "access_lang":
                    EditRegistry(Registry.CurrentUser,
                        @"Control Panel\International\User Profile", "HttpAcceptLanguageOptOut", 1);
                    break;
                case "godmode":
                    // TODO

                    break;
                case "tiles_start":
                    // TODO

                    break;
                case "searchbar_disabled":
                    EditRegistry(Registry.CurrentUser,
                        @"SOFTWARE\Microsoft\Windows\CurrentVersion\Search", "SearchboxTaskbarMode", 0);
                    break;
                case "searchbar_button":
                    EditRegistry(Registry.CurrentUser,
                        @"SOFTWARE\Microsoft\Windows\CurrentVersion\Search", "SearchboxTaskbarMode", 1);
                    break;
                case "searchbar_bar":
                    EditRegistry(Registry.CurrentUser,
                        @"SOFTWARE\Microsoft\Windows\CurrentVersion\Search", "SearchboxTaskbarMode", 2);
                    break;
                case "smartscreen":
                    EditRegistry(Registry.LocalMachine,
                        @"SOFTWARE\Policies\Microsoft\Windows\System", "EnableSmartScreen", 0);
                    EditRegistry(Registry.CurrentUser,
                        @"SOFTWARE\Microsoft\Windows\CurrentVersion\AppHost", "EnableWebContentEvaluation", 0);
                    break;
                case "phone_services":
                    EditRegistry(Registry.LocalMachine,
                        @"SYSTEM\CurrentControlSet\Services\TapiSrv", "Start", 4);
                    break;
                case "biometric":
                    EditRegistry(Registry.LocalMachine,
                        @"SYSTEM\CurrentControlSet\Services\WbioSrvc", "Start", 4);
                    break;
                case "diagtrack":
                    RunPowershell("sc delete DiagTrack");
                    break;
                case "autologger":
                    RunPowershell("echo \"\" > C:\\ProgramData\\Microsoft\\Diagnosis\\ETLLogs\\AutoLogger\\AutoLogger-Diagtrack-Listener.etl");
                    break;
                case "dmwapppushservice":
                    RunPowershell("sc delete dmwappushservice");
                    break;
                case "tracking_servers":
                    AppendLine(@"C:\Windows\System32\drivers\etc\hosts", "");
                    AppendLine(@"C:\Windows\System32\drivers\etc\hosts", "# W10 Debloating Tool - " + Internationalization.Strings.BlockTrackingServers);
                    AppendLine(@"C:\Windows\System32\drivers\etc\hosts", "");
                    AppendLine(@"C:\Windows\System32\drivers\etc\hosts", "127.0.0.1 vortex.data.microsoft.com");
                    AppendLine(@"C:\Windows\System32\drivers\etc\hosts", "127.0.0.1 vortex-win.data.microsoft.com");
                    AppendLine(@"C:\Windows\System32\drivers\etc\hosts", "127.0.0.1 telecommand.telemetry.microsoft.com");
                    AppendLine(@"C:\Windows\System32\drivers\etc\hosts", "127.0.0.1 telecommand.telemetry.microsoft.com.nsatc.net");
                    AppendLine(@"C:\Windows\System32\drivers\etc\hosts", "127.0.0.1 oca.telemetry.microsoft.com");
                    AppendLine(@"C:\Windows\System32\drivers\etc\hosts", "127.0.0.1 oca.telemetry.microsoft.com.nsatc.net");
                    AppendLine(@"C:\Windows\System32\drivers\etc\hosts", "127.0.0.1 sqm.telemetry.microsoft.com");
                    AppendLine(@"C:\Windows\System32\drivers\etc\hosts", "127.0.0.1 sqm.telemetry.microsoft.com.nsatc.net");
                    AppendLine(@"C:\Windows\System32\drivers\etc\hosts", "127.0.0.1 watson.telemetry.microsoft.com");
                    AppendLine(@"C:\Windows\System32\drivers\etc\hosts", "127.0.0.1 watson.telemetry.microsoft.com.nsatc.net");
                    AppendLine(@"C:\Windows\System32\drivers\etc\hosts", "127.0.0.1 redir.metaservices.microsoft.com");
                    AppendLine(@"C:\Windows\System32\drivers\etc\hosts", "127.0.0.1 choice.microsoft.com");
                    AppendLine(@"C:\Windows\System32\drivers\etc\hosts", "127.0.0.1 choice.microsoft.com.nsatc.net");
                    AppendLine(@"C:\Windows\System32\drivers\etc\hosts", "127.0.0.1 df.telemetry.microsoft.com");
                    AppendLine(@"C:\Windows\System32\drivers\etc\hosts", "127.0.0.1 reports.wes.df.telemetry.microsoft.com");
                    AppendLine(@"C:\Windows\System32\drivers\etc\hosts", "127.0.0.1 wes.df.telemetry.microsoft.com");
                    AppendLine(@"C:\Windows\System32\drivers\etc\hosts", "127.0.0.1 services.wes.df.telemetry.microsoft.com");
                    AppendLine(@"C:\Windows\System32\drivers\etc\hosts", "127.0.0.1 sqm.df.telemetry.microsoft.com");
                    AppendLine(@"C:\Windows\System32\drivers\etc\hosts", "127.0.0.1 telemetry.microsoft.com");
                    AppendLine(@"C:\Windows\System32\drivers\etc\hosts", "127.0.0.1 watson.ppe.telemetry.microsoft.com");
                    AppendLine(@"C:\Windows\System32\drivers\etc\hosts", "127.0.0.1 telemetry.appex.bing.net");
                    AppendLine(@"C:\Windows\System32\drivers\etc\hosts", "127.0.0.1 telemetry.urs.microsoft.com");
                    AppendLine(@"C:\Windows\System32\drivers\etc\hosts", "127.0.0.1 telemetry.appex.bing.net:443");
                    AppendLine(@"C:\Windows\System32\drivers\etc\hosts", "127.0.0.1 settings-sandbox.data.microsoft.com");
                    AppendLine(@"C:\Windows\System32\drivers\etc\hosts", "127.0.0.1 vortex-sandbox.data.microsoft.com");
                    AppendLine(@"C:\Windows\System32\drivers\etc\hosts", "127.0.0.1 survey.watson.microsoft.com");
                    AppendLine(@"C:\Windows\System32\drivers\etc\hosts", "127.0.0.1 watson.live.com");
                    AppendLine(@"C:\Windows\System32\drivers\etc\hosts", "127.0.0.1 watson.microsoft.com");
                    AppendLine(@"C:\Windows\System32\drivers\etc\hosts", "127.0.0.1 statsfe2.ws.microsoft.com");
                    AppendLine(@"C:\Windows\System32\drivers\etc\hosts", "127.0.0.1 corpext.msitadfs.glbdns2.microsoft.com");
                    AppendLine(@"C:\Windows\System32\drivers\etc\hosts", "127.0.0.1 compatexchange.cloudapp.net");
                    AppendLine(@"C:\Windows\System32\drivers\etc\hosts", "127.0.0.1 cs1.wpc.v0cdn.net");
                    AppendLine(@"C:\Windows\System32\drivers\etc\hosts", "127.0.0.1 a-0001.a-msedge.net");
                    AppendLine(@"C:\Windows\System32\drivers\etc\hosts", "127.0.0.1 statsfe2.update.microsoft.com.akadns.net");
                    AppendLine(@"C:\Windows\System32\drivers\etc\hosts", "127.0.0.1 sls.update.microsoft.com.akadns.net");
                    AppendLine(@"C:\Windows\System32\drivers\etc\hosts", "127.0.0.1 fe2.update.microsoft.com.akadns.net");
                    AppendLine(@"C:\Windows\System32\drivers\etc\hosts", "127.0.0.1 diagnostics.support.microsoft.com");
                    AppendLine(@"C:\Windows\System32\drivers\etc\hosts", "127.0.0.1 corp.sts.microsoft.com");
                    AppendLine(@"C:\Windows\System32\drivers\etc\hosts", "127.0.0.1 statsfe1.ws.microsoft.com");
                    AppendLine(@"C:\Windows\System32\drivers\etc\hosts", "127.0.0.1 pre.footprintpredict.com");
                    AppendLine(@"C:\Windows\System32\drivers\etc\hosts", "127.0.0.1 i1.services.social.microsoft.com");
                    AppendLine(@"C:\Windows\System32\drivers\etc\hosts", "127.0.0.1 i1.services.social.microsoft.com.nsatc.net");
                    AppendLine(@"C:\Windows\System32\drivers\etc\hosts", "127.0.0.1 feedback.windows.com");
                    AppendLine(@"C:\Windows\System32\drivers\etc\hosts", "127.0.0.1 feedback.microsoft-hohm.com");
                    AppendLine(@"C:\Windows\System32\drivers\etc\hosts", "127.0.0.1 feedback.search.microsoft.com");
                    AppendLine(@"C:\Windows\System32\drivers\etc\hosts", "127.0.0.1 fe2.update.microsoft.com.akadns.net");
                    AppendLine(@"C:\Windows\System32\drivers\etc\hosts", " ");
                    AppendLine(@"C:\Windows\System32\drivers\etc\hosts", "127.0.0.1 cs1.wpc.v0cdn.net");
                    AppendLine(@"C:\Windows\System32\drivers\etc\hosts", "127.0.0.1 ");
                    AppendLine(@"C:\Windows\System32\drivers\etc\hosts", "127.0.0.1 rad.msn.com");
                    AppendLine(@"C:\Windows\System32\drivers\etc\hosts", "127.0.0.1 preview.msn.com");
                    AppendLine(@"C:\Windows\System32\drivers\etc\hosts", "127.0.0.1 ad.doubleclick.net");
                    AppendLine(@"C:\Windows\System32\drivers\etc\hosts", "127.0.0.1 ads.msn.com");
                    AppendLine(@"C:\Windows\System32\drivers\etc\hosts", "127.0.0.1 ads1.msads.net");
                    AppendLine(@"C:\Windows\System32\drivers\etc\hosts", " ");
                    AppendLine(@"C:\Windows\System32\drivers\etc\hosts", "127.0.0.1 ads1.msn.com");
                    AppendLine(@"C:\Windows\System32\drivers\etc\hosts", "127.0.0.1 a.ads1.msn.com");
                    AppendLine(@"C:\Windows\System32\drivers\etc\hosts", "127.0.0.1 a.ads2.msn.com");
                    AppendLine(@"C:\Windows\System32\drivers\etc\hosts", "127.0.0.1 adnexus.net");
                    AppendLine(@"C:\Windows\System32\drivers\etc\hosts", "127.0.0.1 adnxs.com");
                    AppendLine(@"C:\Windows\System32\drivers\etc\hosts", "127.0.0.1 az361816.vo.msecnd.net");
                    AppendLine(@"C:\Windows\System32\drivers\etc\hosts", "127.0.0.1 az512334.vo.msecnd.net");
                    break;
                case "block_localization":
                    EditRegistry(Registry.CurrentUser,
                        @"Control Panel\International\User Profile", "HttpAcceptLanguageOptOut", 1);
                    EditRegistry(Registry.LocalMachine,
                        @"SYSTEM\ControlSet001\Services\lfsvc\Service\Configuration", "Status", 0);
                    EditRegistry(Registry.LocalMachine,
                        @"SYSTEM\CurrentControlSet\Services\lfsvc\Service\Configuration", "Status", 0);
                    break;
                case "block_devices":
                    RegistryKey openSubKey = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\DeviceAccess\Global");
                    if (openSubKey != null)
                    {
                        foreach (string key in openSubKey.GetSubKeyNames())
                        {
                            EditRegistry(Registry.CurrentUser,
                                        @"SOFTWARE\Microsoft\Windows\CurrentVersion\DeviceAccess\Global\" + key, "Value", "Deny");
                        }
                    }
                    break;
                case "prevent_cortana":
                    EditRegistry(Registry.CurrentUser,
                        @"SOFTWARE\Microsoft\InputPersonalization", "RestrictImplicitTextCollectiondword", 1);
                    EditRegistry(Registry.CurrentUser,
                        @"SOFTWARE\Microsoft\InputPersonalization", "RestrictImplicitInkCollection", 1);
                    EditRegistry(Registry.CurrentUser,
                        @"SOFTWARE\Microsoft\InputPersonalization\TrainedDataStore", "HarvestContacts", 0);
                    EditRegistry(Registry.CurrentUser,
                        @"SOFTWARE\Microsoft\Personalization\Settings", "AcceptedPrivacyPolicy", 0);
                    break;
                case "prevent_sync":
                    EditRegistry(Registry.CurrentUser,
                        @"SOFTWARE\Microsoft\Windows\CurrentVersion\DeviceAccess\Global\LooselyCoupled", "Value", "Deny");
                    break;
                case "disable_defender":
                    EditRegistry(Registry.LocalMachine,
                        @"SOFTWARE\Microsoft\Windows Defender\Real-Time Protection", "DisableRealtimeMonitoring", 1);
                    break;
                case "disable_cloud_protection":
                    EditRegistry(Registry.LocalMachine,
                        @"SOFTWARE\Microsoft\Windows Defender\Spynet", "SpyNetReporting", 0);
                    break;
                case "disable_samples":
                    EditRegistry(Registry.LocalMachine,
                        @"SOFTWARE\Microsoft\Windows Defender\Spynet", "SubmitSamplesConsent", 0);
                    break;
                case "disable_auto_updates":
                    EditRegistry(Registry.LocalMachine,
                        @"SOFTWARE\Microsoft\WindowsUpdate\UX\Settings", "UxOption", 0);
                    break;
                case "allow_differed_updates":
                    EditRegistry(Registry.LocalMachine,
                        @"SOFTWARE\Microsoft\WindowsUpdate\UX\Settings", "DeferUpgrade", 1);
                    break;
                case "disable_update_sharing":
                    EditRegistry(Registry.LocalMachine,
                        @"SOFTWARE\Microsoft\Windows\CurrentVersion\DeliveryOptimization\Config", "DODownloadMode", 0);
                    break;
                case "prevent_keyboard":
                    EditRegistry(Registry.CurrentUser,
                        @"SOFTWARE\Microsoft\Input\TIPC", "Enabled", 0);
                    break;
                case "disabled_advanced_tracking":
                    RunBatch("sc config diagtrack start=disabled");
                    RunBatch("sc config dmwappushservice start=disabled");
                    RunBatch("sc config RetailDemo start=disabled");
                    RunBatch("schtasks /change /TN \"\\Microsoft\\Windows\\Application Experience\\Microsoft Compatibility Appraiser\" /DISABLE");
                    RunBatch("schtasks /change /TN \"\\Microsoft\\Windows\\Application Experience\\ProgramDataUpdater\" /DISABLE");
                    RunBatch("schtasks /change /TN \"\\Microsoft\\Windows\\Customer Experience Improvement Program\\Consolidator\" /DISABLE");
                    RunBatch("schtasks /change /TN \"\\Microsoft\\Windows\\Customer Experience Improvement Program\\KernelCeipTask\" /DISABLE");
                    RunBatch("schtasks /change /TN \"\\Microsoft\\Windows\\Customer Experience Improvement Program\\UsbCeip\" /DISABLE");
                    break;
            }
            WriteLog("==== Finished " + tag);
        }

        public void RunPowershell(string script)
        {
            WriteLog("Running  PowerShell script : " + script);
            StringBuilder outputBuilder = new StringBuilder();
            using (PowerShell shell = PowerShell.Create())
            {
                shell.AddScript(script);
                shell.Invoke();

                Collection<PSObject> output = shell.Invoke();

                foreach (PSObject outputItem in output)
                {
                    if (outputItem != null)
                    {
                        outputBuilder.AppendLine(output.ToString());
                    }
                }
            }
        }

        public void RemoveMetroApp(string name)
        {
            string cmd = "Get-AppxPackage -AllUsers -Name " + name + " | Remove-AppxPackage";
            RunPowershell(cmd);
        }

        public bool EditRegistry(RegistryKey baseRegistryKey, string key, string subkey, object value)
        {
            WriteLog("Editing Registry Key : " + baseRegistryKey.Name + @"\" + key + "::" + subkey + "=" + value);
            try
            {
                RegistryKey sk = baseRegistryKey.CreateSubKey(key);
                sk.SetValue(subkey, value);

                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public void RunBatch(string script)
        {
            string filename = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "w10dt.bat");

            File.WriteAllText(filename, script);
            Process proc = new Process { StartInfo = { FileName = filename, WindowStyle = ProcessWindowStyle.Minimized } };
            proc.Start();
            proc.WaitForExit(1000 * 60);
            File.Delete(filename);
        }

        public void AppendLine(string filename, string text)
        {
            File.AppendAllLines(filename, new[] {text});
        }
    }
}
