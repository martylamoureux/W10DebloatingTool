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
            // ErgonomyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSalmon;
            this.ClientSize = new System.Drawing.Size(565, 238);
            this.Controls.Add(this.lockscreen);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ErgonomyForm";
            this.Text = "ErgonomyForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox lockscreen;
    }
}