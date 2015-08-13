namespace W10DebloatingTool
{
    partial class ErgonomyForm
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
            this.lockscreen = new System.Windows.Forms.CheckBox();
            this.godmode = new System.Windows.Forms.CheckBox();
            this.tilesStart = new System.Windows.Forms.CheckBox();
            this.searchBar = new System.Windows.Forms.CheckBox();
            this.searchBarCombo = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lockscreen
            // 
            this.lockscreen.AutoSize = true;
            this.lockscreen.Location = new System.Drawing.Point(12, 12);
            this.lockscreen.Name = "lockscreen";
            this.lockscreen.Size = new System.Drawing.Size(117, 23);
            this.lockscreen.TabIndex = 0;
            this.lockscreen.Text = "No Lockscreen";
            this.lockscreen.UseVisualStyleBackColor = true;
            // 
            // godmode
            // 
            this.godmode.AutoSize = true;
            this.godmode.Enabled = false;
            this.godmode.Location = new System.Drawing.Point(12, 41);
            this.godmode.Name = "godmode";
            this.godmode.Size = new System.Drawing.Size(134, 23);
            this.godmode.TabIndex = 0;
            this.godmode.Text = "Enable GodMode";
            this.godmode.UseVisualStyleBackColor = true;
            // 
            // tilesStart
            // 
            this.tilesStart.AutoSize = true;
            this.tilesStart.Enabled = false;
            this.tilesStart.Location = new System.Drawing.Point(12, 70);
            this.tilesStart.Name = "tilesStart";
            this.tilesStart.Size = new System.Drawing.Size(167, 23);
            this.tilesStart.TabIndex = 0;
            this.tilesStart.Text = "No tiles on Start Menu";
            this.tilesStart.UseVisualStyleBackColor = true;
            // 
            // searchBar
            // 
            this.searchBar.AutoSize = true;
            this.searchBar.Location = new System.Drawing.Point(12, 99);
            this.searchBar.Name = "searchBar";
            this.searchBar.Size = new System.Drawing.Size(99, 23);
            this.searchBar.TabIndex = 0;
            this.searchBar.Text = "Search bar :";
            this.searchBar.UseVisualStyleBackColor = true;
            // 
            // searchBarCombo
            // 
            this.searchBarCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.searchBarCombo.FormattingEnabled = true;
            this.searchBarCombo.Location = new System.Drawing.Point(31, 128);
            this.searchBarCombo.Name = "searchBarCombo";
            this.searchBarCombo.Size = new System.Drawing.Size(163, 25);
            this.searchBarCombo.TabIndex = 1;
            // 
            // ErgonomyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSalmon;
            this.ClientSize = new System.Drawing.Size(565, 238);
            this.Controls.Add(this.searchBarCombo);
            this.Controls.Add(this.searchBar);
            this.Controls.Add(this.tilesStart);
            this.Controls.Add(this.godmode);
            this.Controls.Add(this.lockscreen);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ErgonomyForm";
            this.Text = "ErgonomyForm";
            this.Load += new System.EventHandler(this.ErgonomyForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox lockscreen;
        private System.Windows.Forms.CheckBox godmode;
        private System.Windows.Forms.CheckBox tilesStart;
        private System.Windows.Forms.CheckBox searchBar;
        private System.Windows.Forms.ComboBox searchBarCombo;
    }
}