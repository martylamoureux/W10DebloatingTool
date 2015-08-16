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
    public partial class ApplicationsForm : Form
    {
        public ApplicationsForm()
        {
            InitializeComponent();
        }

        public void LoadTranslation()
        {
            IStrings strings = Internationalization.Strings;

            this.cortana.Text = strings.RemoveCortana;
            this.oneDrive.Text = strings.RemoveOneDrive;
            this.builder.Text = strings.Remove3DBuilder;
            this.getStarted.Text = strings.RemoveGetStarted;
            this.officeHub.Text = strings.RemoveOfficeHub;
            this.solitaire.Text = strings.RemoveSolitaire;
            this.skype.Text = strings.RemoveSkype;
            this.maps.Text = strings.RemoveMaps;
            this.onenote.Text = strings.RemoveOneNote;
            this.weather.Text = strings.RemoveWeather;
            this.sport.Text = strings.RemoveSport;
            this.finance.Text = strings.RemoveFinance;
            this.news.Text = strings.RemoveNews;
            this.xbox.Text = strings.RemoveXbox;
            this.music.Text = strings.RemoveMusic;
            this.films.Text = strings.RemoveVideo;
            this.photos.Text = strings.RemovePhotos;
            this.camera.Text = strings.RemoveCamera;
            this.alarms.Text = strings.RemoveAlarms;
            this.contacts.Text = strings.RemoveContacts;
            this.mail.Text = strings.RemoveMail;
            this.phoneCompanion.Text = strings.RemovePhoneCompanion;
            this.soundRecord.Text = strings.RemoveSoundRecord;
            this.edge.Text = strings.RemoveEdge;
            this.allMetro.Text = strings.RemoveAllMetroApps;

            this.selectAllApps.Text = strings.SelectAllApps;
            this.unselectAllApps.Text = strings.UnselectAllApps;

            this.toolTip.ToolTipTitle = strings.Help;
            this.toolTip.SetToolTip(this.allMetro, strings.DeleteAllMetroAppsTip);

            DisableControl(edge);
            DisableControl(cortana);
        }

        public List<string> Collect()
        {
            List<string> res = new List<string>();

            if (this.cortana.Checked) res.Add("remove_cortana");
            if (this.oneDrive.Checked) res.Add("remove_oneDrive");
            if (this.builder.Checked) res.Add("remove_builder");
            if (this.getStarted.Checked) res.Add("remove_getStarted");
            if (this.officeHub.Checked) res.Add("remove_officeHub");
            if (this.solitaire.Checked) res.Add("remove_solitaire");
            if (this.skype.Checked) res.Add("remove_skype");
            if (this.maps.Checked) res.Add("remove_maps");
            if (this.onenote.Checked) res.Add("remove_onenote");
            if (this.weather.Checked) res.Add("remove_weather");
            if (this.sport.Checked) res.Add("remove_sport");
            if (this.finance.Checked) res.Add("remove_finance");
            if (this.news.Checked) res.Add("remove_news");
            if (this.xbox.Checked) res.Add("remove_xbox");
            if (this.music.Checked) res.Add("remove_music");
            if (this.films.Checked) res.Add("remove_films");
            if (this.photos.Checked) res.Add("remove_photos");
            if (this.camera.Checked) res.Add("remove_camera");
            if (this.alarms.Checked) res.Add("remove_alarms");
            if (this.contacts.Checked) res.Add("remove_contacts");
            if (this.mail.Checked) res.Add("remove_mail");
            if (this.phoneCompanion.Checked) res.Add("remove_phoneCompanion");
            if (this.soundRecord.Checked) res.Add("remove_soundRecord");
            if (this.edge.Checked) res.Add("remove_edge");

            return res;
        } 

        private void selectAllApps_Click(object sender, EventArgs e)
        {
            this.cortana.Checked = true;
            this.oneDrive.Checked = true;
            this.builder.Checked = true;
            this.getStarted.Checked = true;
            this.officeHub.Checked = true;
            this.solitaire.Checked = true;
            this.skype.Checked = true;
            this.maps.Checked = true;
            this.onenote.Checked = true;
            this.weather.Checked = true;
            this.sport.Checked = true;
            this.finance.Checked = true;
            this.news.Checked = true;
            this.xbox.Checked = true;
            this.music.Checked = true;
            this.films.Checked = true;
            this.photos.Checked = true;
            this.camera.Checked = true;
            this.alarms.Checked = true;
            this.contacts.Checked = true;
            this.mail.Checked = true;
            this.phoneCompanion.Checked = true;
            this.soundRecord.Checked = true;
            this.edge.Checked = true;
        }

        private void unselectAllApps_Click(object sender, EventArgs e)
        {

            this.cortana.Checked = false;
            this.oneDrive.Checked = false;
            this.builder.Checked = false;
            this.getStarted.Checked = false;
            this.officeHub.Checked = false;
            this.solitaire.Checked = false;
            this.skype.Checked = false;
            this.maps.Checked = false;
            this.onenote.Checked = false;
            this.weather.Checked = false;
            this.sport.Checked = false;
            this.finance.Checked = false;
            this.news.Checked = false;
            this.xbox.Checked = false;
            this.music.Checked = false;
            this.films.Checked = false;
            this.photos.Checked = false;
            this.camera.Checked = false;
            this.alarms.Checked = false;
            this.contacts.Checked = false;
            this.mail.Checked = false;
            this.phoneCompanion.Checked = false;
            this.soundRecord.Checked = false;
            this.edge.Checked = false;
        }

        public void DisableControl(CheckBox control)
        {
            control.ForeColor = ControlPaint.Light(BackColor);
            control.Cursor = Cursors.No;
            toolTip.SetToolTip(control, Internationalization.Strings.NotAvailableTip);

            control.CheckedChanged += delegate(object sender, EventArgs args)
            {
                CheckBox ctl = (CheckBox) sender;
                if (ctl.Checked)
                {
                    ctl.Checked = false;
                    Utils.Warning(Internationalization.Strings.NotAvailableTip);
                }
            };
        }
    }
}
