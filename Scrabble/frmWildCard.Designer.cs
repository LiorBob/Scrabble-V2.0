namespace Scrabble
{
    partial class frmWildCard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmWildCard));
            this.btnOK = new System.Windows.Forms.Button();
            this.cmbWildCardLetters = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(63, 12);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(69, 21);
            this.btnOK.TabIndex = 1;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // cmbWildCardLetters
            // 
            this.cmbWildCardLetters.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbWildCardLetters.FormattingEnabled = true;
            this.cmbWildCardLetters.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "E",
            "F",
            "G",
            "H",
            "I",
            "J",
            "K",
            "L",
            "M",
            "N",
            "O",
            "P",
            "Q",
            "R",
            "S",
            "T",
            "U",
            "V",
            "W",
            "X",
            "Y",
            "Z"});
            this.cmbWildCardLetters.Location = new System.Drawing.Point(12, 12);
            this.cmbWildCardLetters.MaxDropDownItems = 26;
            this.cmbWildCardLetters.Name = "cmbWildCardLetters";
            this.cmbWildCardLetters.Size = new System.Drawing.Size(35, 21);
            this.cmbWildCardLetters.TabIndex = 0;
            this.cmbWildCardLetters.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbWildCardLetters_KeyPress);
            // 
            // frmWildCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(144, 385);
            this.ControlBox = false;
            this.Controls.Add(this.cmbWildCardLetters);
            this.Controls.Add(this.btnOK);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmWildCard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Select wild card letter";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.ComboBox cmbWildCardLetters;
    }
}