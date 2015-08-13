using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using W10DebloatingTool.i18n;

namespace W10DebloatingTool
{
    public partial class PrivacyForm : Form, ITranslatable
    {
        public PrivacyForm()
        {
            InitializeComponent();
        }

        public void LoadTranslation()
        {
            IStrings strings = Internationalization.Strings;

            this.adsId.Text = strings.UseAdsId;
            this.accessLang.Text = strings.AllowSitesToAccessMyLanguage;
        }

        public List<string> Collect()
        {
            List<string> res = new List<string>();
            if (adsId.Checked) res.Add("use_ads_id");
            if (accessLang.Checked) res.Add("access_lang");
            return res;
        } 
    }
}
