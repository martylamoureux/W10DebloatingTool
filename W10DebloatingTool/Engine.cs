using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Management.Automation;
using System.Text;
using Microsoft.Win32;

namespace W10DebloatingTool
{
    public class Engine
    {
        private string[] tags;
        private readonly bool saveLogs;

        public Engine(string[] tags, bool saveLogs)
        {
            this.tags = tags;
            this.saveLogs = saveLogs;
        }

        public void Run()
        {
            foreach (string tag in tags)
                RunTag(tag);
        }

        public void RunTag(string tag)
        {
            switch (tag)
            {
                case "remove_cortana":
                    break;
                case "remove_oneDrive":
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
                    EditLocalMachineRegistry(Registry.LocalMachine,
                        @"SOFTWARE\Policies\Microsoft\Windows\Personalization", "NoLockScreen", 1);
                    break;
            }
        }

        public void RunPowershell(string script)
        {
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

        public bool EditLocalMachineRegistry(RegistryKey baseRegistryKey, string key, string subkey, object value)
        {
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
    }
}
