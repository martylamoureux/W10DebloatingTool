﻿using System;
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
    public partial class MainForm : Form
    {
        private Dictionary<string, Form> panelForms = new Dictionary<string, Form>();
        private Dictionary<string, Button> panelButtons = new Dictionary<string, Button>();

        public MainForm()
        {
            // Set Language
            i18n.Internationalization.SetSystemLanguage();

            InitializeComponent();
            RegisterView(new PrivacyForm(), privacyButton);
            RegisterView(new ApplicationsForm(), appsButton);
            AdaptButtons();
            LoadTranslation();

            this.languagesCombo.DataSource = new BindingSource(Internationalization.Languages, null);
            this.languagesCombo.ValueMember = "Key";
            this.languagesCombo.DisplayMember = "Value";
            this.languagesCombo.SelectedValue = Internationalization.CurrentLanguageCode;
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

            this.letsgoButton.Text = strings.LetsGo.ToUpper();
            this.saveLogsCheckbox.Text = strings.SaveLogs;

            // Save Logs checkbox position
            int x = (letsgoButton.Left + letsgoButton.Width) - saveLogsCheckbox.Width;
            int y = letsgoButton.Top + letsgoButton.Height + 2;
            this.saveLogsCheckbox.Location = new Point(x, y);
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
            button.BackColor = Color.DimGray;
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
                btn.BackColor = Color.DimGray;
            }

            Button button = panelButtons[viewName];
            button.BackColor = form.BackColor;

            // Update scrollbar
            int offset = form.Height;
        }

        public void AdaptButtons()
        {
            int width = this.Width / panelButtons.Count;
            int y = 23;
            int x = 0;

            foreach (Button button in panelButtons.Values)
            {
                button.Location = new Point(x, y);
                button.Width = width;

                x += width;
            }
        }

        private void languagesCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.languagesCombo.SelectedValue is string)
            {
                string lang = this.languagesCombo.SelectedValue.ToString();
                Internationalization.SetLanguage(lang);
                LoadTranslation();

                foreach (Form form in panelForms.Values)
                {
                    form.GetType().GetMethod("LoadTranslation").Invoke(form, new object[0]);

                }
            }
            
        }
    }
}