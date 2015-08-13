using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using W10DebloatingTool.i18n;

namespace W10DebloatingTool
{
    public partial class InfoForm : Form
    {
        public InfoForm()
        {
            InitializeComponent();

            IStrings strings = Internationalization.Strings;
            this.button1.Text = strings.Close;
            this.Text = strings.Informations;
            this.titleLabel.Text = Application.ProductName;
            string[] ver = Application.ProductVersion.Split('.');
            this.versionLabel.Text = string.Format(strings.Version, ver[0] + '.' + ver[1] + '.' + ver[2]);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("http://twitter.com/W4ReLL");
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("http://twitter.com/martylamoureux");
        }
    }
}
