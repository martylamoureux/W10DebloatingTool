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

        }

        public void LoadTranslation()
        {
            IStrings strings = Internationalization.Strings;

            smartscreen.Text = strings.DisableSmartScreen;
            phone.Text = strings.DisablePhoneServices;
            biometric.Text = strings.DisableBiometricSystem;
            diagtrack.Text = strings.DisableDiagTrack;
            autologger.Text = strings.DisableAutoLogger;
            dmwapppushservice.Text = strings.DisableDmwAppPushService;
            trackingServers.Text = strings.BlockTrackingServers;
        }

        public List<string> Collect()
        {
            List<string> res = new List<string>();
            if (smartscreen.Checked) res.Add("smartscreen");
            if (phone.Checked) res.Add("phone_services");
            if (biometric.Checked) res.Add("biometric");
            if (diagtrack.Checked) res.Add("diagtrack");
            if (autologger.Checked) res.Add("autologger");
            if (dmwapppushservice.Checked) res.Add("dmwapppushservice");
            if (trackingServers.Checked) res.Add("tracking_servers");
            return res;
        } 
    }
}
