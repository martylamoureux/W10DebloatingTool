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

            LoadTranslation();

            this.languagesCombo.DataSource = new BindingSource(Internationalization.Languages, null);
            this.languagesCombo.ValueMember = "Key";
            this.languagesCombo.DisplayMember = "Value";
            this.languagesCombo.SelectedValue = Internationalization.CurrentLanguageCode;
        }

        public void LoadTranslation()
        {
            IStrings strings = Internationalization.Strings;
            this.button1.Text = strings.Close;
            this.Text = strings.Informations;
            this.aboutText.Text = strings.AboutText;

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

        private void languagesCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.languagesCombo.SelectedValue is string)
            {
                string lang = this.languagesCombo.SelectedValue.ToString();
                Internationalization.SetLanguage(lang);
                LoadTranslation();
            }
        }

        private void InfoForm_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("http://www.apache.org/licenses/LICENSE-2.0.html");
        }
    }
}
