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
    public partial class MainForm : Form
    {
        private int tabsHeight = 44;
        private Color backColor = Color.Black;

        private Dictionary<string, Form> panelForms = new Dictionary<string, Form>();
        private Dictionary<string, Button> panelButtons = new Dictionary<string, Button>();

        public MainForm()
        {
            // Set Language
            i18n.Internationalization.SetSystemLanguage();

            InitializeComponent();
            RegisterView(new PrivacyForm(), privacyButton);
            RegisterView(new ApplicationsForm(), appsButton);
            RegisterView(new ServicesForm(), servicesButton);
            RegisterView(new ErgonomyForm(), ergonomyButton);
            AdaptButtons();
            LoadTranslation();

            label1.BackColor = ControlPaint.Dark(Color.DarkGray);
            saveLogsCheckbox.BackColor = ControlPaint.Dark(Color.DarkGray);
            saveLogsCheckbox.ForeColor = Color.White;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            string key = panelForms.Keys.FirstOrDefault();
            if (key != null)
                ActivateView(key);
        }

        public void LoadTranslation()
        {
            IStrings strings = Internationalization.Strings;
            this.privacyButton.Text = strings.Privacy;
            this.appsButton.Text = strings.Applications;
            this.ergonomyButton.Text = strings.Ergonomy;

            this.letsgoButton.Text = strings.LetsGo.ToUpper();
            this.saveLogsCheckbox.Text = strings.SaveLogs;

            // this.infoButton.Text = strings.Informations;

            // Save Logs checkbox position
            int x = (letsgoButton.Left + letsgoButton.Width) - saveLogsCheckbox.Width;
            int y = letsgoButton.Top + letsgoButton.Height + 2;
            this.saveLogsCheckbox.Location = new Point(x, y);
            

            foreach (Form form in panelForms.Values)
            {
                form.GetType().GetMethod("LoadTranslation").Invoke(form, new object[0]);
            }
        }

        public void RegisterView(Form form, Button button)
        {
            form.TopLevel = false;
            // form.Dock = DockStyle.Fill;
            form.FormBorderStyle = FormBorderStyle.None;
            
            panelForms.Add(form.Name, form);

            button.FlatAppearance.MouseOverBackColor = form.BackColor;
            button.FlatAppearance.MouseDownBackColor = form.BackColor;
            button.FlatAppearance.BorderSize = 0;
            button.BackColor = ControlPaint.Dark(Color.DimGray);
            button.Tag = form.Name;
            button.Click += SwitchView;
            panelButtons.Add(form.Name, button);
        }

        private void SwitchView(object sender, EventArgs e)
        {
            string viewName = ((Control) sender).Tag.ToString();

            ActivateView(viewName);
        }

        public void ActivateView(string viewName)
        {
            Form form = panelForms[viewName];
            this.containerPanel.VerticalScroll.Value = 0;
            this.containerPanel.Controls.Clear();
            this.containerPanel.Controls.Add(form);
            this.containerPanel.VerticalScroll.Value = 0;
            this.containerPanel.BackColor = form.BackColor;
            form.Show();

            // Reset buttons colors
            foreach (Button btn in panelButtons.Values.Where(b => b.Tag.ToString() != viewName))
            {
                btn.BackColor = ControlPaint.Dark(Color.DarkGray);
            }

            Button button = panelButtons[viewName];
            button.BackColor = form.BackColor;
            button.ForeColor = form.ForeColor;

            backColor = form.BackColor;

            letsgoButton.FlatAppearance.MouseOverBackColor = ControlPaint.LightLight(ControlPaint.LightLight(form.BackColor));
            letsgoButton.FlatAppearance.MouseDownBackColor = ControlPaint.LightLight(ControlPaint.LightLight(form.BackColor));
            letsgoButton.ForeColor = form.BackColor;

            // Update scrollbar
            int offset = form.Height;
        }

        public void AdaptButtons()
        {
            int width = this.Width / panelButtons.Count;
            int y = containerPanel.Top - tabsHeight;
            int x = 0;

            foreach (Button button in panelButtons.Values)
            {
                button.Location = new Point(x, y);
                button.Width = width;
                button.Height = tabsHeight;

                x += width;
            }
        }

        private void letsgoButton_Click(object sender, EventArgs e)
        {

            List<string> bag = new List<string>();

            foreach (Form form in panelForms.Values)
            {
                bag.AddRange((IEnumerable<string>) form.GetType().GetMethod("Collect").Invoke(form, new object[0]));
            }

            if (bag.Count == 0)
            {
                Utils.Info(Internationalization.Strings.NothingToDo);
                return;
            }

            Utils.Info(Internationalization.Strings.ProcessingWillTakeAWhile);

            Engine engine = new Engine(bag.ToArray(), this.saveLogsCheckbox.Checked);
            engine.Run(this);

            Utils.Info(Internationalization.Strings.RestartComputer);

            Process.Start("shutdown", "/r /t 0");

        }

        private void saveLogsCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (saveLogsCheckbox.Checked)
            {
                string path = Properties.Settings.Default.LogsPath;

                FolderBrowserDialog dlg = new FolderBrowserDialog();
                dlg.Description = Internationalization.Strings.ChooseLogsPath;
                dlg.SelectedPath = path;
                if (dlg.ShowDialog() != DialogResult.OK)
                {
                    saveLogsCheckbox.Checked = false;
                    return;
                }

                Properties.Settings.Default.LogsPath = dlg.SelectedPath;
                Properties.Settings.Default.Save();
            }
        }

        private void letsgoButton_MouseEnter(object sender, EventArgs e)
        {
             //letsgoButton.ForeColor = Color.White;
        }

        private void letsgoButton_MouseLeave(object sender, EventArgs e)
        {
            letsgoButton.ForeColor = backColor;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new InfoForm().ShowDialog();
            LoadTranslation();
        }
    }
}
