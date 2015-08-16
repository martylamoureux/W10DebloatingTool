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
            this.components = new System.ComponentModel.Container();
            this.lockscreen = new System.Windows.Forms.CheckBox();
            this.godmode = new System.Windows.Forms.CheckBox();
            this.tilesStart = new System.Windows.Forms.CheckBox();
            this.searchBar = new System.Windows.Forms.CheckBox();
            this.searchBarCombo = new System.Windows.Forms.ComboBox();
            this.uncheckAll = new System.Windows.Forms.Button();
            this.checkAll = new System.Windows.Forms.Button();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // lockscreen
            // 
            this.lockscreen.AutoSize = true;
            this.lockscreen.Location = new System.Drawing.Point(12, 59);
            this.lockscreen.Name = "lockscreen";
            this.lockscreen.Size = new System.Drawing.Size(117, 23);
            this.lockscreen.TabIndex = 0;
            this.lockscreen.Text = "No Lockscreen";
            this.lockscreen.UseVisualStyleBackColor = true;
            // 
            // godmode
            // 
            this.godmode.AutoSize = true;
            this.godmode.Location = new System.Drawing.Point(12, 88);
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
            this.tilesStart.Location = new System.Drawing.Point(12, 206);
            this.tilesStart.Name = "tilesStart";
            this.tilesStart.Size = new System.Drawing.Size(167, 23);
            this.tilesStart.TabIndex = 0;
            this.tilesStart.Text = "No tiles on Start Menu";
            this.tilesStart.UseVisualStyleBackColor = true;
            this.tilesStart.Visible = false;
            // 
            // searchBar
            // 
            this.searchBar.AutoSize = true;
            this.searchBar.Location = new System.Drawing.Point(12, 117);
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
            this.searchBarCombo.Location = new System.Drawing.Point(31, 146);
            this.searchBarCombo.Name = "searchBarCombo";
            this.searchBarCombo.Size = new System.Drawing.Size(163, 25);
            this.searchBarCombo.TabIndex = 1;
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
            this.uncheckAll.TabIndex = 6;
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
            this.checkAll.TabIndex = 7;
            this.checkAll.Text = "Check All";
            this.checkAll.UseVisualStyleBackColor = true;
            this.checkAll.Click += new System.EventHandler(this.checkAll_Click);
            // 
            // toolTip
            // 
            this.toolTip.AutoPopDelay = 10000;
            this.toolTip.InitialDelay = 200;
            this.toolTip.IsBalloon = true;
            this.toolTip.ReshowDelay = 100;
            this.toolTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // ErgonomyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSalmon;
            this.ClientSize = new System.Drawing.Size(733, 338);
            this.Controls.Add(this.uncheckAll);
            this.Controls.Add(this.checkAll);
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
        private System.Windows.Forms.Button uncheckAll;
        private System.Windows.Forms.Button checkAll;
        private System.Windows.Forms.ToolTip toolTip;
    }
}