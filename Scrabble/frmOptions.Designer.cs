using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;


namespace Scrabble
{
    partial class frmOptions
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOptions));
            this.lblMaxLettersCanHold = new System.Windows.Forms.Label();
            this.udcMaxLettersCanHold = new System.Windows.Forms.NumericUpDown();
            this.btnOK = new System.Windows.Forms.Button();
            this.gbxMaxLetters = new System.Windows.Forms.GroupBox();
            this.lblEnterNewValue = new System.Windows.Forms.Label();
            this.udcLetterNewValue = new System.Windows.Forms.NumericUpDown();
            this.btnLetterRandomValue = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.udcMaxLettersCanHold)).BeginInit();
            this.gbxMaxLetters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.udcLetterNewValue)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMaxLettersCanHold
            // 
            this.lblMaxLettersCanHold.AutoSize = true;
            this.lblMaxLettersCanHold.Location = new System.Drawing.Point(18, 64);
            this.lblMaxLettersCanHold.Name = "lblMaxLettersCanHold";
            this.lblMaxLettersCanHold.Size = new System.Drawing.Size(154, 13);
            this.lblMaxLettersCanHold.TabIndex = 0;
            this.lblMaxLettersCanHold.Text = "Max letters can hold at a time : ";
            // 
            // udcMaxLettersCanHold
            // 
            this.udcMaxLettersCanHold.Location = new System.Drawing.Point(178, 62);
            this.udcMaxLettersCanHold.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.udcMaxLettersCanHold.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.udcMaxLettersCanHold.Name = "udcMaxLettersCanHold";
            this.udcMaxLettersCanHold.Size = new System.Drawing.Size(36, 20);
            this.udcMaxLettersCanHold.TabIndex = 1;
            this.udcMaxLettersCanHold.Value = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.udcMaxLettersCanHold.Enter += new System.EventHandler(this.udcMaxLettersCanHold_Enter);
            this.udcMaxLettersCanHold.Leave += new System.EventHandler(this.udcMaxLettersCanHold_Leave);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(85, 174);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(80, 39);
            this.btnOK.TabIndex = 2;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // gbxMaxLetters
            // 
            this.gbxMaxLetters.Controls.Add(this.udcMaxLettersCanHold);
            this.gbxMaxLetters.Controls.Add(this.lblMaxLettersCanHold);
            this.gbxMaxLetters.Location = new System.Drawing.Point(10, 3);
            this.gbxMaxLetters.Name = "gbxMaxLetters";
            this.gbxMaxLetters.Size = new System.Drawing.Size(240, 160);
            this.gbxMaxLetters.TabIndex = 3;
            this.gbxMaxLetters.TabStop = false;
            // 
            // lblEnterNewValue
            // 
            this.lblEnterNewValue.AutoSize = true;
            this.lblEnterNewValue.Location = new System.Drawing.Point(302, 187);
            this.lblEnterNewValue.Name = "lblEnterNewValue";
            this.lblEnterNewValue.Size = new System.Drawing.Size(0, 13);
            this.lblEnterNewValue.TabIndex = 5;
            // 
            // udcLetterNewValue
            // 
            this.udcLetterNewValue.Location = new System.Drawing.Point(323, 185);
            this.udcLetterNewValue.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.udcLetterNewValue.Name = "udcLetterNewValue";
            this.udcLetterNewValue.Size = new System.Drawing.Size(30, 20);
            this.udcLetterNewValue.TabIndex = 6;
            this.udcLetterNewValue.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.udcLetterNewValue.Visible = false;
            this.udcLetterNewValue.ValueChanged += new System.EventHandler(this.udcLetterNewValue_ValueChanged);
            this.udcLetterNewValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.udcLetterNewValue_KeyPress);
            // 
            // btnLetterRandomValue
            // 
            this.btnLetterRandomValue.Location = new System.Drawing.Point(360, 130);
            this.btnLetterRandomValue.Name = "btnLetterRandomValue";
            this.btnLetterRandomValue.Size = new System.Drawing.Size(120, 30);
            this.btnLetterRandomValue.TabIndex = 7;
            this.btnLetterRandomValue.UseVisualStyleBackColor = true;
            this.btnLetterRandomValue.Visible = false;
            this.btnLetterRandomValue.Click += new System.EventHandler(this.btnLetterRandomValue_Click);
            // 
            // frmOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 221);
            this.ControlBox = false;
            this.Controls.Add(this.btnLetterRandomValue);
            this.Controls.Add(this.udcLetterNewValue);
            this.Controls.Add(this.lblEnterNewValue);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.gbxMaxLetters);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmOptions";
            this.Opacity = 0D;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Options";
            ((System.ComponentModel.ISupportInitialize)(this.udcMaxLettersCanHold)).EndInit();
            this.gbxMaxLetters.ResumeLayout(false);
            this.gbxMaxLetters.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.udcLetterNewValue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion


        private void InitializeButtonLetters()
        {
            btnLetters = new Button[26];

            int x = 300;
            int y = 10;

            char letter = 'A';


            for (int i = 0; i < btnLetters.Length; i++)
            {
                btnLetters[i] = new Button()
                {
                    Text = letter.ToString(),
                    Location = new Point(x, y),
                    Size = new Size(30, 30),
                    Tag = lettersValues.FirstOrDefault(kvp => kvp.Key.Contains(letter)).Value
                };

                btnLetters[i].Click += new EventHandler(btnLetters_Click);
                Controls.Add(btnLetters[i]);

                btnLetters[i].BringToFront();


                x += 30;

                if (i % 6 == 5)
                {
                    x = 300;
                    y += 30;
                }

                letter++;

            }



            for (int i = 0; i < btnLetters.Length; i++)
            {
                ToolTip toolTip = new ToolTip();
                toolTip.SetToolTip(btnLetters[i], btnLetters[i].Tag.ToString());


                // So we see the buttons colors according to their real value, when form loads

                Letter lett = new Letter();
                btnLetters[i].BackColor = lett.GetColor(btnLetters[i].Text[0]);
            }

        }


        public static Button[] GetButtonsLetters()
        {
            return btnLetters;
        }


        private void btnLetters_Click(object sender, EventArgs e)
        {
            btnLetter = (Button)sender;

            btnLetterRandomValue.Visible = true;
            lblEnterNewValue.Visible = true;
            udcLetterNewValue.Visible = true;

            btnLetterRandomValue.Text = "Random value for " + btnLetter.Text;
            lblEnterNewValue.Text = btnLetter.Text + "=";

            udcLetterNewValue.Value = Decimal.Parse(btnLetter.Tag.ToString());

        }


        private System.Windows.Forms.Label lblMaxLettersCanHold;
        private System.Windows.Forms.NumericUpDown udcMaxLettersCanHold;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.GroupBox gbxMaxLetters;
        private System.Windows.Forms.Label lblEnterNewValue;
        private static Button[] btnLetters;
        private Button btnLetter;
        private NumericUpDown udcLetterNewValue;
        private Button btnLetterRandomValue;



        private Dictionary<List<char>, int> lettersValues = new Dictionary<List<char>, int>
        {
            {new List<char> {'A','C','D','E','G','I','L','M','N','O','R','S','T','U'}, 1},
            {new List<char> {'B', 'H', 'P'}, 2},
            {new List<char> {'F', 'K', 'Y'}, 3},
            {new List<char> {'V', 'W'}, 4},
            {new List<char> {'J', 'Q', 'X', 'Z'}, 5}
        };

    }

}


