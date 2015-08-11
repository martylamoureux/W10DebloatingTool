namespace W10DebloatingTool
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.containerPanel = new System.Windows.Forms.Panel();
            this.privacyButton = new System.Windows.Forms.Button();
            this.appsButton = new System.Windows.Forms.Button();
            this.languagesCombo = new System.Windows.Forms.ComboBox();
            this.letsgoButton = new System.Windows.Forms.Button();
            this.saveLogsCheckbox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // containerPanel
            // 
            this.containerPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.containerPanel.AutoScroll = true;
            this.containerPanel.Location = new System.Drawing.Point(0, 67);
            this.containerPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.containerPanel.Name = "containerPanel";
            this.containerPanel.Size = new System.Drawing.Size(777, 380);
            this.containerPanel.TabIndex = 0;
            // 
            // privacyButton
            // 
            this.privacyButton.BackColor = System.Drawing.Color.DimGray;
            this.privacyButton.FlatAppearance.BorderSize = 0;
            this.privacyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.privacyButton.Font = new System.Drawing.Font("Segoe UI Semilight", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.privacyButton.ForeColor = System.Drawing.Color.White;
            this.privacyButton.Location = new System.Drawing.Point(0, 23);
            this.privacyButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.privacyButton.Name = "privacyButton";
            this.privacyButton.Size = new System.Drawing.Size(178, 44);
            this.privacyButton.TabIndex = 1;
            this.privacyButton.Text = "Privacy";
            this.privacyButton.UseVisualStyleBackColor = false;
            // 
            // appsButton
            // 
            this.appsButton.BackColor = System.Drawing.Color.DimGray;
            this.appsButton.FlatAppearance.BorderSize = 0;
            this.appsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.appsButton.Font = new System.Drawing.Font("Segoe UI Semilight", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appsButton.ForeColor = System.Drawing.Color.White;
            this.appsButton.Location = new System.Drawing.Point(178, 23);
            this.appsButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.appsButton.Name = "appsButton";
            this.appsButton.Size = new System.Drawing.Size(178, 44);
            this.appsButton.TabIndex = 1;
            this.appsButton.Text = "Applications";
            this.appsButton.UseVisualStyleBackColor = false;
            // 
            // languagesCombo
            // 
            this.languagesCombo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.languagesCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.languagesCombo.FormattingEnabled = true;
            this.languagesCombo.Location = new System.Drawing.Point(14, 552);
            this.languagesCombo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.languagesCombo.Name = "languagesCombo";
            this.languagesCombo.Size = new System.Drawing.Size(140, 25);
            this.languagesCombo.TabIndex = 2;
            this.languagesCombo.SelectedIndexChanged += new System.EventHandler(this.languagesCombo_SelectedIndexChanged);
            // 
            // letsgoButton
            // 
            this.letsgoButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.letsgoButton.BackColor = System.Drawing.Color.DimGray;
            this.letsgoButton.FlatAppearance.BorderSize = 0;
            this.letsgoButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.letsgoButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.letsgoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.letsgoButton.Font = new System.Drawing.Font("Segoe UI Semibold", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.letsgoButton.ForeColor = System.Drawing.Color.White;
            this.letsgoButton.Location = new System.Drawing.Point(194, 466);
            this.letsgoButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.letsgoButton.Name = "letsgoButton";
            this.letsgoButton.Size = new System.Drawing.Size(389, 84);
            this.letsgoButton.TabIndex = 1;
            this.letsgoButton.Text = "LET\'S GO";
            this.letsgoButton.UseVisualStyleBackColor = false;
            // 
            // saveLogsCheckbox
            // 
            this.saveLogsCheckbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.saveLogsCheckbox.AutoSize = true;
            this.saveLogsCheckbox.Location = new System.Drawing.Point(489, 557);
            this.saveLogsCheckbox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.saveLogsCheckbox.Name = "saveLogsCheckbox";
            this.saveLogsCheckbox.Size = new System.Drawing.Size(89, 23);
            this.saveLogsCheckbox.TabIndex = 3;
            this.saveLogsCheckbox.Text = "Save Logs";
            this.saveLogsCheckbox.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(777, 595);
            this.Controls.Add(this.saveLogsCheckbox);
            this.Controls.Add(this.languagesCombo);
            this.Controls.Add(this.letsgoButton);
            this.Controls.Add(this.appsButton);
            this.Controls.Add(this.privacyButton);
            this.Controls.Add(this.containerPanel);
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "W10 Debloating Tool";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel containerPanel;
        private System.Windows.Forms.Button privacyButton;
        private System.Windows.Forms.Button appsButton;
        private System.Windows.Forms.ComboBox languagesCombo;
        private System.Windows.Forms.Button letsgoButton;
        private System.Windows.Forms.CheckBox saveLogsCheckbox;
    }
}