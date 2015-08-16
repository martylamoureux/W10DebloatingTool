namespace W10DebloatingTool
{
    partial class ServicesForm
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
            this.smartscreen = new System.Windows.Forms.CheckBox();
            this.phone = new System.Windows.Forms.CheckBox();
            this.biometric = new System.Windows.Forms.CheckBox();
            this.diagtrack = new System.Windows.Forms.CheckBox();
            this.autologger = new System.Windows.Forms.CheckBox();
            this.dmwapppushservice = new System.Windows.Forms.CheckBox();
            this.trackingServers = new System.Windows.Forms.CheckBox();
            this.uncheckAll = new System.Windows.Forms.Button();
            this.checkAll = new System.Windows.Forms.Button();
            this.disableAdvancedTracking = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // smartscreen
            // 
            this.smartscreen.AutoSize = true;
            this.smartscreen.Location = new System.Drawing.Point(12, 53);
            this.smartscreen.Name = "smartscreen";
            this.smartscreen.Size = new System.Drawing.Size(152, 23);
            this.smartscreen.TabIndex = 1;
            this.smartscreen.Text = "Disable SmartScreen";
            this.smartscreen.UseVisualStyleBackColor = true;
            // 
            // phone
            // 
            this.phone.AutoSize = true;
            this.phone.Location = new System.Drawing.Point(12, 82);
            this.phone.Name = "phone";
            this.phone.Size = new System.Drawing.Size(167, 23);
            this.phone.TabIndex = 1;
            this.phone.Text = "Disable Phone Services";
            this.phone.UseVisualStyleBackColor = true;
            // 
            // biometric
            // 
            this.biometric.AutoSize = true;
            this.biometric.Location = new System.Drawing.Point(12, 111);
            this.biometric.Name = "biometric";
            this.biometric.Size = new System.Drawing.Size(133, 23);
            this.biometric.TabIndex = 1;
            this.biometric.Text = "Disable Biometric";
            this.biometric.UseVisualStyleBackColor = true;
            // 
            // diagtrack
            // 
            this.diagtrack.AutoSize = true;
            this.diagtrack.Location = new System.Drawing.Point(12, 140);
            this.diagtrack.Name = "diagtrack";
            this.diagtrack.Size = new System.Drawing.Size(135, 23);
            this.diagtrack.TabIndex = 1;
            this.diagtrack.Text = "Disable DiagTrack";
            this.diagtrack.UseVisualStyleBackColor = true;
            // 
            // autologger
            // 
            this.autologger.AutoSize = true;
            this.autologger.Location = new System.Drawing.Point(12, 169);
            this.autologger.Name = "autologger";
            this.autologger.Size = new System.Drawing.Size(149, 23);
            this.autologger.TabIndex = 1;
            this.autologger.Text = "Disable AutoLogger";
            this.autologger.UseVisualStyleBackColor = true;
            // 
            // dmwapppushservice
            // 
            this.dmwapppushservice.AutoSize = true;
            this.dmwapppushservice.Location = new System.Drawing.Point(12, 198);
            this.dmwapppushservice.Name = "dmwapppushservice";
            this.dmwapppushservice.Size = new System.Drawing.Size(205, 23);
            this.dmwapppushservice.TabIndex = 1;
            this.dmwapppushservice.Text = "Disable DmwAppPushService";
            this.dmwapppushservice.UseVisualStyleBackColor = true;
            // 
            // trackingServers
            // 
            this.trackingServers.AutoSize = true;
            this.trackingServers.Location = new System.Drawing.Point(12, 227);
            this.trackingServers.Name = "trackingServers";
            this.trackingServers.Size = new System.Drawing.Size(162, 23);
            this.trackingServers.TabIndex = 1;
            this.trackingServers.Text = "Block Tracking Servers";
            this.trackingServers.UseVisualStyleBackColor = true;
            // 
            // uncheckAll
            // 
            this.uncheckAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.uncheckAll.Cursor = System.Windows.Forms.Cursors.Default;
            this.uncheckAll.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.uncheckAll.FlatAppearance.BorderSize = 2;
            this.uncheckAll.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.uncheckAll.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkCyan;
            this.uncheckAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uncheckAll.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.uncheckAll.Location = new System.Drawing.Point(589, 12);
            this.uncheckAll.Name = "uncheckAll";
            this.uncheckAll.Size = new System.Drawing.Size(132, 30);
            this.uncheckAll.TabIndex = 4;
            this.uncheckAll.Text = "Uncheck all";
            this.uncheckAll.UseVisualStyleBackColor = true;
            this.uncheckAll.Click += new System.EventHandler(this.uncheckAll_Click);
            // 
            // checkAll
            // 
            this.checkAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkAll.Cursor = System.Windows.Forms.Cursors.Default;
            this.checkAll.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.checkAll.FlatAppearance.BorderSize = 2;
            this.checkAll.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.checkAll.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkCyan;
            this.checkAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkAll.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.checkAll.Location = new System.Drawing.Point(451, 12);
            this.checkAll.Name = "checkAll";
            this.checkAll.Size = new System.Drawing.Size(132, 30);
            this.checkAll.TabIndex = 5;
            this.checkAll.Text = "Check All";
            this.checkAll.UseVisualStyleBackColor = true;
            this.checkAll.Click += new System.EventHandler(this.checkAll_Click);
            // 
            // disableAdvancedTracking
            // 
            this.disableAdvancedTracking.AutoSize = true;
            this.disableAdvancedTracking.Location = new System.Drawing.Point(12, 256);
            this.disableAdvancedTracking.Name = "disableAdvancedTracking";
            this.disableAdvancedTracking.Size = new System.Drawing.Size(190, 23);
            this.disableAdvancedTracking.TabIndex = 1;
            this.disableAdvancedTracking.Text = "Disable Advanced Tracking";
            this.disableAdvancedTracking.UseVisualStyleBackColor = true;
            // 
            // ServicesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateBlue;
            this.ClientSize = new System.Drawing.Size(733, 338);
            this.Controls.Add(this.uncheckAll);
            this.Controls.Add(this.checkAll);
            this.Controls.Add(this.disableAdvancedTracking);
            this.Controls.Add(this.trackingServers);
            this.Controls.Add(this.dmwapppushservice);
            this.Controls.Add(this.autologger);
            this.Controls.Add(this.diagtrack);
            this.Controls.Add(this.biometric);
            this.Controls.Add(this.phone);
            this.Controls.Add(this.smartscreen);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ServicesForm";
            this.Text = "ServicesForm";
            this.Load += new System.EventHandler(this.ServicesForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox smartscreen;
        private System.Windows.Forms.CheckBox phone;
        private System.Windows.Forms.CheckBox biometric;
        private System.Windows.Forms.CheckBox diagtrack;
        private System.Windows.Forms.CheckBox autologger;
        private System.Windows.Forms.CheckBox dmwapppushservice;
        private System.Windows.Forms.CheckBox trackingServers;
        private System.Windows.Forms.Button uncheckAll;
        private System.Windows.Forms.Button checkAll;
        private System.Windows.Forms.CheckBox disableAdvancedTracking;
    }
}