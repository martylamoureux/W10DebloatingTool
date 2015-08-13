using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using W10DebloatingTool.i18n;

namespace W10DebloatingTool
{
    static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Version w10 = new Version(10, 0, 0, 0);
            //if (Environment.OSVersion.Version < w10)
            //{
            //    Utils.Error(Internationalization.Strings.NotWindows10Error);
            //    Application.Exit();
            //    return;
            //}
            Application.Run(new MainForm());
        }
    }
}
