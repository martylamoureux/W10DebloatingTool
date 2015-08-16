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
    public partial class ErgonomyForm : Form
    {
        public ErgonomyForm()
        {
            InitializeComponent();
        }

        public void LoadTranslation()
        {
            IStrings strings = Internationalization.Strings;

            this.checkAll.Text = strings.CheckAll;
            this.uncheckAll.Text = strings.UncheckAll;

            this.lockscreen.Text = strings.NoLockscreen;
            this.godmode.Text = strings.EnableGodMode;
            this.tilesStart.Text = strings.NoTilesOnStartMenu;
            this.searchBar.Text = strings.SearchBar;
            
            searchBarCombo.Items.Clear();
            searchBarCombo.Items.Add(strings.DisableIt);
            searchBarCombo.Items.Add(strings.AsButton);
            searchBarCombo.Items.Add(strings.AsBar);

            this.toolTip.ToolTipTitle = strings.Help;
            this.toolTip.SetToolTip(this.godmode, strings.GodModeTip);
            this.toolTip.SetToolTip(this.lockscreen, strings.LockscreenTip);
            
        }

        public List<string> Collect()
        {
            List<string> res = new List<string>();

            if (lockscreen.Checked) res.Add("no_lockscreen");
            if (godmode.Checked) res.Add("godmode");
            if (tilesStart.Checked) res.Add("tiles_start");
            if (searchBar.Checked)
            {
                if (searchBarCombo.SelectedIndex == 0) res.Add("searchbar_disabled");
                if (searchBarCombo.SelectedIndex == 1) res.Add("searchbar_button");
                if (searchBarCombo.SelectedIndex == 2) res.Add("searchbar_bar");
            }

            return res;
        }

        private void ErgonomyForm_Load(object sender, EventArgs e)
        {
            checkAll.FlatAppearance.MouseOverBackColor = ControlPaint.LightLight(ControlPaint.Dark(BackColor));
            checkAll.FlatAppearance.MouseDownBackColor = ControlPaint.LightLight(ControlPaint.Dark(BackColor));
            uncheckAll.FlatAppearance.MouseOverBackColor = ControlPaint.LightLight(ControlPaint.Dark(BackColor));
            uncheckAll.FlatAppearance.MouseDownBackColor = ControlPaint.LightLight(ControlPaint.Dark(BackColor));
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

        public void DisableControl(CheckBox control)
        {
            control.ForeColor = ControlPaint.Light(ControlPaint.Dark(BackColor));
            control.Cursor = Cursors.No;
            toolTip.SetToolTip(control, Internationalization.Strings.NotAvailableTip);

            control.CheckedChanged += delegate (object sender, EventArgs args)
            {
                CheckBox ctl = (CheckBox)sender;
                if (ctl.Checked)
                {
                    ctl.Checked = false;
                    Utils.Warning(Internationalization.Strings.NotAvailableTip);
                }
            };
        }
    }
}
