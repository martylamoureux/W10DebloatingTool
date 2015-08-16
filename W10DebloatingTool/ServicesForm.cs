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
    public partial class ServicesForm : Form
    {
        public ServicesForm()
        {
            InitializeComponent();
        }

        private void ServicesForm_Load(object sender, EventArgs e)
        {
            checkAll.FlatAppearance.MouseOverBackColor = ControlPaint.Light(ControlPaint.Dark(BackColor));
            checkAll.FlatAppearance.MouseDownBackColor = ControlPaint.Light(ControlPaint.Dark(BackColor));
            uncheckAll.FlatAppearance.MouseOverBackColor = ControlPaint.Light(ControlPaint.Dark(BackColor));
            uncheckAll.FlatAppearance.MouseDownBackColor = ControlPaint.Light(ControlPaint.Dark(BackColor));
        }

        public void LoadTranslation()
        {
            IStrings strings = Internationalization.Strings;

            this.checkAll.Text = strings.CheckAll;
            this.uncheckAll.Text = strings.UncheckAll;

            smartscreen.Text = strings.DisableSmartScreen;
            phone.Text = strings.DisablePhoneServices;
            biometric.Text = strings.DisableBiometricSystem;
            disableTracking.Text = strings.DisableTrackingServices;
            trackingServers.Text = strings.BlockTrackingServers;
            disableAdvancedTracking.Text = strings.DisableAdvancedTracking;

            this.toolTip.ToolTipTitle = strings.Help;
            this.toolTip.SetToolTip(this.smartscreen, strings.SmartScreenTip);
        }

        public List<string> Collect()
        {
            List<string> res = new List<string>();
            if (smartscreen.Checked) res.Add("smartscreen");
            if (phone.Checked) res.Add("phone_services");
            if (biometric.Checked) res.Add("biometric");
            if (disableTracking.Checked) res.Add("disable_tracking");
            if (trackingServers.Checked) res.Add("tracking_servers");
            if (disableAdvancedTracking.Checked) res.Add("disable_advanced_tracking");
            return res;
        }

        private void checkAll_Click(object sender, EventArgs e)
        {
            foreach (CheckBox ctl in Controls.OfType<CheckBox>().Where(c => c.Visible && c.Enabled))
                ctl.Checked = true;
        }

        private void uncheckAll_Click(object sender, EventArgs e)
        {
            foreach (CheckBox ctl in Controls.OfType<CheckBox>().Where(c => c.Visible && c.Enabled))
                ctl.Checked = false;
        }
    }
}
