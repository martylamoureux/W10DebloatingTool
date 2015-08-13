namespace W10DebloatingTool
{
    partial class PrivacyForm
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
            this.adsId = new System.Windows.Forms.CheckBox();
            this.accessLang = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // adsId
            // 
            this.adsId.AutoSize = true;
            this.adsId.Location = new System.Drawing.Point(12, 12);
            this.adsId.Name = "adsId";
            this.adsId.Size = new System.Drawing.Size(69, 23);
            this.adsId.TabIndex = 1;
            this.adsId.Text = "Ads ID";
            this.adsId.UseVisualStyleBackColor = true;
            // 
            // accessLang
            // 
            this.accessLang.AutoSize = true;
            this.accessLang.Location = new System.Drawing.Point(12, 41);
            this.accessLang.Name = "accessLang";
            this.accessLang.Size = new System.Drawing.Size(96, 23);
            this.accessLang.TabIndex = 1;
            this.accessLang.Text = "accessLang";
            this.accessLang.UseVisualStyleBackColor = true;
            // 
            // PrivacyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(444, 279);
            this.Controls.Add(this.accessLang);
            this.Controls.Add(this.adsId);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "PrivacyForm";
            this.Text = "PrivacyForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox adsId;
        private System.Windows.Forms.CheckBox accessLang;
    }
}