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
            this.lockscreen.Text = strings.NoLockscreen;
        }

        public List<string> Collect()
        {
            List<string> res = new List<string>();

            if (lockscreen.Checked) res.Add("no_lockscreen");

            return res;
        } 
    }
}
