namespace Scrabble
{
    partial class frmPass
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
            this.btnPass = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.chbSelectAll = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btnPass
            // 
            this.btnPass.Location = new System.Drawing.Point(60, 57);
            this.btnPass.Name = "btnPass";
            this.btnPass.Size = new System.Drawing.Size(68, 34);
            this.btnPass.TabIndex = 0;
            this.btnPass.Text = "Pass";
            this.btnPass.UseVisualStyleBackColor = true;
            this.btnPass.Click += new System.EventHandler(this.btnPass_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(143, 57);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(68, 34);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // chbSelectAll
            // 
            this.chbSelectAll.Location = new System.Drawing.Point(226, 67);
            this.chbSelectAll.Name = "chbSelectAll";
            this.chbSelectAll.Size = new System.Drawing.Size(13, 16);
            this.chbSelectAll.TabIndex = 2;
            this.chbSelectAll.UseVisualStyleBackColor = true;
            this.chbSelectAll.CheckedChanged += new System.EventHandler(this.chbSelectAll_CheckedChanged);
            // 
            // frmPass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(268, 100);
            this.ControlBox = false;
            this.Controls.Add(this.chbSelectAll);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnPass);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPass";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pass";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPass;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.CheckBox chbSelectAll;
    }
}