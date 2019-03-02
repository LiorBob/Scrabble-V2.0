namespace Scrabble
{
    partial class frmSplash
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSplash));
            this.tmrSplash = new System.Windows.Forms.Timer(this.components);
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblVersion = new System.Windows.Forms.Label();
            this.lblCopyright = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tmrSplash
            // 
            this.tmrSplash.Enabled = true;
            this.tmrSplash.Interval = 3000;
            this.tmrSplash.Tick += new System.EventHandler(this.tmrSplash_Tick);
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Stencil", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.SystemColors.Info;
            this.lblTitle.Location = new System.Drawing.Point(75, 26);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(360, 130);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "SCRABBLE";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTitle.Paint += new System.Windows.Forms.PaintEventHandler(this.lblTitle_Paint);
            // 
            // lblVersion
            // 
            this.lblVersion.BackColor = System.Drawing.Color.Transparent;
            this.lblVersion.Location = new System.Drawing.Point(38, 186);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(145, 37);
            this.lblVersion.TabIndex = 1;
            // 
            // lblCopyright
            // 
            this.lblCopyright.AutoSize = true;
            this.lblCopyright.BackColor = System.Drawing.Color.Transparent;
            this.lblCopyright.Location = new System.Drawing.Point(38, 223);
            this.lblCopyright.Name = "lblCopyright";
            this.lblCopyright.Size = new System.Drawing.Size(243, 13);
            this.lblCopyright.TabIndex = 2;
            this.lblCopyright.Text = "Copyright (C) 2019 Lior Bobrov. All rights reserved.\r\n";
            // 
            // frmSplash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(512, 266);
            this.Controls.Add(this.lblCopyright);
            this.Controls.Add(this.lblVersion);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmSplash";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Scrabble";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer tmrSplash;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.Label lblCopyright;
    }
}