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

            this.checkAll.Text = strings.CheckAll;
            this.uncheckAll.Text = strings.UncheckAll;

            this.adsId.Text = strings.UseAdsId;
            this.accessLang.Text = strings.AllowSitesToAccessMyLanguage;
            this.blockLocalization.Text = strings.BlockLocalization;
            this.blockDevices.Text = strings.BlockDevices;
            this.preventCortana.Text = strings.PreventCortana;
            this.preventSync.Text = strings.PreventSync;
            this.disableDefender.Text = strings.DisableDefender;
            this.disableCloudProtection.Text = strings.DisableCloudProtection;
            this.disableSamples.Text = strings.DisableSamples;
            this.disableAutoUpdate.Text = strings.DisableAutoUpdate;
            this.allowDifferedUpdates.Text = strings.AllowDifferedUpdate;
            this.disableUpdateSharing.Text = strings.DisableUpdateSharing;
            this.preventKeyboard.Text = strings.PreventKeyboard;
        }

        public List<string> Collect()
        {
            List<string> res = new List<string>();
            if (adsId.Checked) res.Add("use_ads_id");
            if (accessLang.Checked) res.Add("access_lang");
            if (blockLocalization.Checked) res.Add("block_localization");
            if (blockDevices.Checked) res.Add("block_devices");
            if (preventCortana.Checked) res.Add("prevent_cortana");
            if (preventSync.Checked) res.Add("prevent_sync");
            if (disableDefender.Checked) res.Add("disable_defender");
            if (disableCloudProtection.Checked) res.Add("disable_cloud_protection");
            if (disableSamples.Checked) res.Add("disable_samples");
            if (disableAutoUpdate.Checked) res.Add("disable_auto_update");
            if (allowDifferedUpdates.Checked) res.Add("allow_differed_updates");
            if (disableUpdateSharing.Checked) res.Add("disable_update_sharing");
            if (preventKeyboard.Checked) res.Add("prevent_keyboard");
            return res;
        }

        private void selectAllApps_Click(object sender, EventArgs e)
        {
            foreach (CheckBox ctl in Controls.OfType<CheckBox>().Where(c => c.Visible && c.Enabled))
                ctl.Checked = true;
        }

        private void unselectAllApps_Click(object sender, EventArgs e)
        {
            foreach (CheckBox ctl in Controls.OfType<CheckBox>().Where(c => c.Visible && c.Enabled))
                ctl.Checked = false;
        }

        private void PrivacyForm_Load(object sender, EventArgs e)
        {
            checkAll.FlatAppearance.MouseOverBackColor = ControlPaint.Light(ControlPaint.Dark(BackColor));
            checkAll.FlatAppearance.MouseDownBackColor = ControlPaint.Light(ControlPaint.Dark(BackColor));
            uncheckAll.FlatAppearance.MouseOverBackColor = ControlPaint.Light(ControlPaint.Dark(BackColor));
            uncheckAll.FlatAppearance.MouseDownBackColor = ControlPaint.Light(ControlPaint.Dark(BackColor));
        }
    }
}
