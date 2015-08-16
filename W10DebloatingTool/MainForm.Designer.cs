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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.containerPanel = new System.Windows.Forms.Panel();
            this.privacyButton = new System.Windows.Forms.Button();
            this.appsButton = new System.Windows.Forms.Button();
            this.letsgoButton = new System.Windows.Forms.Button();
            this.saveLogsCheckbox = new System.Windows.Forms.CheckBox();
            this.ergonomyButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.infoButton = new System.Windows.Forms.Button();
            this.servicesButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // containerPanel
            // 
            this.containerPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.containerPanel.AutoScroll = true;
            this.containerPanel.Location = new System.Drawing.Point(0, 44);
            this.containerPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.containerPanel.Name = "containerPanel";
            this.containerPanel.Size = new System.Drawing.Size(734, 371);
            this.containerPanel.TabIndex = 0;
            // 
            // privacyButton
            // 
            this.privacyButton.BackColor = System.Drawing.Color.DimGray;
            this.privacyButton.FlatAppearance.BorderSize = 0;
            this.privacyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.privacyButton.Font = new System.Drawing.Font("Segoe UI Semilight", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.privacyButton.ForeColor = System.Drawing.Color.White;
            this.privacyButton.Location = new System.Drawing.Point(0, 0);
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
            this.appsButton.Location = new System.Drawing.Point(178, 0);
            this.appsButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.appsButton.Name = "appsButton";
            this.appsButton.Size = new System.Drawing.Size(178, 44);
            this.appsButton.TabIndex = 1;
            this.appsButton.Text = "Applications";
            this.appsButton.UseVisualStyleBackColor = false;
            // 
            // letsgoButton
            // 
            this.letsgoButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.letsgoButton.BackColor = System.Drawing.Color.White;
            this.letsgoButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.letsgoButton.FlatAppearance.BorderSize = 0;
            this.letsgoButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray;
            this.letsgoButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.letsgoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.letsgoButton.Font = new System.Drawing.Font("Segoe UI Semibold", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.letsgoButton.ForeColor = System.Drawing.Color.Black;
            this.letsgoButton.Location = new System.Drawing.Point(194, 372);
            this.letsgoButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.letsgoButton.Name = "letsgoButton";
            this.letsgoButton.Size = new System.Drawing.Size(346, 84);
            this.letsgoButton.TabIndex = 1;
            this.letsgoButton.Text = "LET\'S GO";
            this.letsgoButton.UseVisualStyleBackColor = false;
            this.letsgoButton.Click += new System.EventHandler(this.letsgoButton_Click);
            this.letsgoButton.MouseEnter += new System.EventHandler(this.letsgoButton_MouseEnter);
            this.letsgoButton.MouseLeave += new System.EventHandler(this.letsgoButton_MouseLeave);
            // 
            // saveLogsCheckbox
            // 
            this.saveLogsCheckbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.saveLogsCheckbox.AutoSize = true;
            this.saveLogsCheckbox.Location = new System.Drawing.Point(446, 463);
            this.saveLogsCheckbox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.saveLogsCheckbox.Name = "saveLogsCheckbox";
            this.saveLogsCheckbox.Size = new System.Drawing.Size(89, 23);
            this.saveLogsCheckbox.TabIndex = 3;
            this.saveLogsCheckbox.Text = "Save Logs";
            this.saveLogsCheckbox.UseVisualStyleBackColor = true;
            this.saveLogsCheckbox.CheckedChanged += new System.EventHandler(this.saveLogsCheckbox_CheckedChanged);
            // 
            // ergonomyButton
            // 
            this.ergonomyButton.BackColor = System.Drawing.Color.DimGray;
            this.ergonomyButton.FlatAppearance.BorderSize = 0;
            this.ergonomyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ergonomyButton.Font = new System.Drawing.Font("Segoe UI Semilight", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ergonomyButton.ForeColor = System.Drawing.Color.White;
            this.ergonomyButton.Location = new System.Drawing.Point(362, 0);
            this.ergonomyButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ergonomyButton.Name = "ergonomyButton";
            this.ergonomyButton.Size = new System.Drawing.Size(178, 44);
            this.ergonomyButton.TabIndex = 1;
            this.ergonomyButton.Text = "Ergonomy";
            this.ergonomyButton.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Location = new System.Drawing.Point(-4, 347);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(761, 160);
            this.label1.TabIndex = 4;
            // 
            // infoButton
            // 
            this.infoButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.infoButton.BackColor = System.Drawing.Color.LightGray;
            this.infoButton.FlatAppearance.BorderSize = 0;
            this.infoButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.infoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.infoButton.Image = global::W10DebloatingTool.Properties.Resources._1439414004_sign_info;
            this.infoButton.Location = new System.Drawing.Point(696, 461);
            this.infoButton.Name = "infoButton";
            this.infoButton.Size = new System.Drawing.Size(26, 26);
            this.infoButton.TabIndex = 5;
            this.infoButton.UseVisualStyleBackColor = false;
            this.infoButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // servicesButton
            // 
            this.servicesButton.BackColor = System.Drawing.Color.DimGray;
            this.servicesButton.FlatAppearance.BorderSize = 0;
            this.servicesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.servicesButton.Font = new System.Drawing.Font("Segoe UI Semilight", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.servicesButton.ForeColor = System.Drawing.Color.White;
            this.servicesButton.Location = new System.Drawing.Point(556, 0);
            this.servicesButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.servicesButton.Name = "servicesButton";
            this.servicesButton.Size = new System.Drawing.Size(178, 44);
            this.servicesButton.TabIndex = 1;
            this.servicesButton.Text = "Services";
            this.servicesButton.UseVisualStyleBackColor = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(734, 499);
            this.Controls.Add(this.infoButton);
            this.Controls.Add(this.saveLogsCheckbox);
            this.Controls.Add(this.letsgoButton);
            this.Controls.Add(this.servicesButton);
            this.Controls.Add(this.ergonomyButton);
            this.Controls.Add(this.appsButton);
            this.Controls.Add(this.privacyButton);
            this.Controls.Add(this.containerPanel);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
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
        private System.Windows.Forms.Button letsgoButton;
        private System.Windows.Forms.CheckBox saveLogsCheckbox;
        private System.Windows.Forms.Button ergonomyButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button infoButton;
        private System.Windows.Forms.Button servicesButton;
    }
}