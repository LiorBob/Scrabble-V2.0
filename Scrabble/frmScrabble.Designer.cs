using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Linq;



namespace Scrabble
{
    partial class frmScrabble
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmScrabble));
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnPass = new System.Windows.Forms.Button();
            this.lblScore = new System.Windows.Forms.Label();
            this.lblLettersRemaining = new System.Windows.Forms.Label();
            this.btnFirstWordHint = new System.Windows.Forms.Button();
            this.optionsToolStrip = new System.Windows.Forms.ToolStrip();
            this.speakLegalWordsToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.backgroundColorToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.circleBonusesToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.sortLettersToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.shuffleLettersToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.historyBackToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.historyNextToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.lettersValuesToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.picLegend = new System.Windows.Forms.PictureBox();
            this.optionsToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLegend)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(600, 496);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(68, 34);
            this.btnSubmit.TabIndex = 0;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnPass
            // 
            this.btnPass.Location = new System.Drawing.Point(680, 496);
            this.btnPass.Name = "btnPass";
            this.btnPass.Size = new System.Drawing.Size(68, 34);
            this.btnPass.TabIndex = 1;
            this.btnPass.Text = "Pass";
            this.btnPass.UseVisualStyleBackColor = true;
            this.btnPass.Click += new System.EventHandler(this.btnPass_Click);
            // 
            // lblScore
            // 
            this.lblScore.Location = new System.Drawing.Point(600, 295);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(120, 34);
            this.lblScore.TabIndex = 2;
            this.lblScore.Text = "Score :   0";
            // 
            // lblLettersRemaining
            // 
            this.lblLettersRemaining.AutoSize = true;
            this.lblLettersRemaining.Location = new System.Drawing.Point(600, 260);
            this.lblLettersRemaining.Name = "lblLettersRemaining";
            this.lblLettersRemaining.Size = new System.Drawing.Size(111, 13);
            this.lblLettersRemaining.TabIndex = 4;
            this.lblLettersRemaining.Text = "Letters remaining :  99";
            // 
            // btnFirstWordHint
            // 
            this.btnFirstWordHint.Location = new System.Drawing.Point(503, 496);
            this.btnFirstWordHint.Name = "btnFirstWordHint";
            this.btnFirstWordHint.Size = new System.Drawing.Size(85, 34);
            this.btnFirstWordHint.TabIndex = 5;
            this.btnFirstWordHint.Text = "First Word Hint";
            this.btnFirstWordHint.UseVisualStyleBackColor = true;
            this.btnFirstWordHint.Click += new System.EventHandler(this.btnFirstWordHint_Click);
            // 
            // optionsToolStrip
            // 
            this.optionsToolStrip.AutoSize = false;
            this.optionsToolStrip.Dock = System.Windows.Forms.DockStyle.Left;
            this.optionsToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.optionsToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.speakLegalWordsToolStripButton,
            this.backgroundColorToolStripButton,
            this.circleBonusesToolStripButton,
            this.sortLettersToolStripButton,
            this.shuffleLettersToolStripButton,
            this.historyBackToolStripButton,
            this.historyNextToolStripButton,
            this.lettersValuesToolStripButton});
            this.optionsToolStrip.Location = new System.Drawing.Point(0, 0);
            this.optionsToolStrip.Name = "optionsToolStrip";
            this.optionsToolStrip.Size = new System.Drawing.Size(25, 266);
            this.optionsToolStrip.TabIndex = 6;
            this.optionsToolStrip.Text = "toolStrip1";
            // 
            // speakLegalWordsToolStripButton
            // 
            this.speakLegalWordsToolStripButton.AutoSize = false;
            this.speakLegalWordsToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.speakLegalWordsToolStripButton.Image = global::Scrabble.Properties.Resources.Speak;
            this.speakLegalWordsToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.speakLegalWordsToolStripButton.Name = "speakLegalWordsToolStripButton";
            this.speakLegalWordsToolStripButton.Size = new System.Drawing.Size(20, 20);
            this.speakLegalWordsToolStripButton.ToolTipText = "Speak Legal Words : Yes";
            this.speakLegalWordsToolStripButton.Click += new System.EventHandler(this.speakLegalWordsToolStripButton_Click);
            // 
            // backgroundColorToolStripButton
            // 
            this.backgroundColorToolStripButton.AutoSize = false;
            this.backgroundColorToolStripButton.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.backgroundColorToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.backgroundColorToolStripButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backgroundColorToolStripButton.ForeColor = System.Drawing.SystemColors.Control;
            this.backgroundColorToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.backgroundColorToolStripButton.Margin = new System.Windows.Forms.Padding(1, 1, 0, 2);
            this.backgroundColorToolStripButton.Name = "backgroundColorToolStripButton";
            this.backgroundColorToolStripButton.Size = new System.Drawing.Size(18, 18);
            this.backgroundColorToolStripButton.Text = "bg";
            this.backgroundColorToolStripButton.ToolTipText = "Current Background";
            this.backgroundColorToolStripButton.Click += new System.EventHandler(this.backgroundColorToolStripButton_Click);
            // 
            // circleBonusesToolStripButton
            // 
            this.circleBonusesToolStripButton.AutoSize = false;
            this.circleBonusesToolStripButton.BackColor = System.Drawing.Color.DarkCyan;
            this.circleBonusesToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.circleBonusesToolStripButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.circleBonusesToolStripButton.ForeColor = System.Drawing.Color.Gold;
            this.circleBonusesToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.circleBonusesToolStripButton.Margin = new System.Windows.Forms.Padding(0, 3, 0, 2);
            this.circleBonusesToolStripButton.Name = "circleBonusesToolStripButton";
            this.circleBonusesToolStripButton.Size = new System.Drawing.Size(18, 18);
            this.circleBonusesToolStripButton.Text = "bs";
            this.circleBonusesToolStripButton.ToolTipText = "Bonuses Shape : Circle";
            this.circleBonusesToolStripButton.Click += new System.EventHandler(this.circleBonusesToolStripButton_Click);
            // 
            // sortLettersToolStripButton
            // 
            this.sortLettersToolStripButton.AutoSize = false;
            this.sortLettersToolStripButton.BackColor = System.Drawing.Color.Purple;
            this.sortLettersToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.sortLettersToolStripButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sortLettersToolStripButton.ForeColor = System.Drawing.Color.Chartreuse;
            this.sortLettersToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.sortLettersToolStripButton.Margin = new System.Windows.Forms.Padding(0, 3, 0, 2);
            this.sortLettersToolStripButton.Name = "sortLettersToolStripButton";
            this.sortLettersToolStripButton.Size = new System.Drawing.Size(18, 18);
            this.sortLettersToolStripButton.Text = "az";
            this.sortLettersToolStripButton.ToolTipText = "Sort Letters By Order : Ascending";
            this.sortLettersToolStripButton.Click += new System.EventHandler(this.sortLettersToolStripButton_Click);
            // 
            // shuffleLettersToolStripButton
            // 
            this.shuffleLettersToolStripButton.AutoSize = false;
            this.shuffleLettersToolStripButton.BackColor = System.Drawing.Color.Red;
            this.shuffleLettersToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.shuffleLettersToolStripButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.shuffleLettersToolStripButton.ForeColor = System.Drawing.Color.MediumBlue;
            this.shuffleLettersToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.shuffleLettersToolStripButton.Margin = new System.Windows.Forms.Padding(0, 3, 0, 2);
            this.shuffleLettersToolStripButton.Name = "shuffleLettersToolStripButton";
            this.shuffleLettersToolStripButton.Size = new System.Drawing.Size(18, 18);
            this.shuffleLettersToolStripButton.Text = "sh";
            this.shuffleLettersToolStripButton.ToolTipText = "Shuffle Letters";
            this.shuffleLettersToolStripButton.Click += new System.EventHandler(this.shuffleLettersToolStripButton_Click);
            // 
            // historyBackToolStripButton
            // 
            this.historyBackToolStripButton.AutoSize = false;
            this.historyBackToolStripButton.BackColor = System.Drawing.Color.Yellow;
            this.historyBackToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.historyBackToolStripButton.Enabled = false;
            this.historyBackToolStripButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.historyBackToolStripButton.ForeColor = System.Drawing.Color.Fuchsia;
            this.historyBackToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.historyBackToolStripButton.Margin = new System.Windows.Forms.Padding(0, 3, 0, 2);
            this.historyBackToolStripButton.Name = "historyBackToolStripButton";
            this.historyBackToolStripButton.Size = new System.Drawing.Size(18, 18);
            this.historyBackToolStripButton.Text = "hb";
            this.historyBackToolStripButton.ToolTipText = "History Back - view previous move";
            this.historyBackToolStripButton.Click += new System.EventHandler(this.historyBackToolStripButton_Click);
            // 
            // historyNextToolStripButton
            // 
            this.historyNextToolStripButton.AutoSize = false;
            this.historyNextToolStripButton.BackColor = System.Drawing.Color.Yellow;
            this.historyNextToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.historyNextToolStripButton.Enabled = false;
            this.historyNextToolStripButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.historyNextToolStripButton.ForeColor = System.Drawing.Color.Blue;
            this.historyNextToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.historyNextToolStripButton.Margin = new System.Windows.Forms.Padding(0, 3, 0, 2);
            this.historyNextToolStripButton.Name = "historyNextToolStripButton";
            this.historyNextToolStripButton.Size = new System.Drawing.Size(18, 18);
            this.historyNextToolStripButton.Text = "hn";
            this.historyNextToolStripButton.ToolTipText = "History Next - view next move";
            this.historyNextToolStripButton.Click += new System.EventHandler(this.historyNextToolStripButton_Click);
            // 
            // lettersValuesToolStripButton
            // 
            this.lettersValuesToolStripButton.AutoSize = false;
            this.lettersValuesToolStripButton.BackColor = System.Drawing.Color.Chartreuse;
            this.lettersValuesToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.lettersValuesToolStripButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.lettersValuesToolStripButton.ForeColor = System.Drawing.Color.Firebrick;
            this.lettersValuesToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.lettersValuesToolStripButton.Margin = new System.Windows.Forms.Padding(0, 3, 0, 2);
            this.lettersValuesToolStripButton.Name = "lettersValuesToolStripButton";
            this.lettersValuesToolStripButton.Size = new System.Drawing.Size(18, 18);
            this.lettersValuesToolStripButton.Text = "lv";
            this.lettersValuesToolStripButton.ToolTipText = "Letters Values";
            this.lettersValuesToolStripButton.Click += new System.EventHandler(this.lettersValuesToolStripButton_Click);
            // 
            // picLegend
            // 
            this.picLegend.Location = new System.Drawing.Point(600, 18);
            this.picLegend.Name = "picLegend";
            this.picLegend.Size = new System.Drawing.Size(143, 228);
            this.picLegend.TabIndex = 3;
            this.picLegend.TabStop = false;
            // 
            // frmScrabble
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 266);
            this.Controls.Add(this.optionsToolStrip);
            this.Controls.Add(this.btnFirstWordHint);
            this.Controls.Add(this.lblLettersRemaining);
            this.Controls.Add(this.picLegend);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.btnPass);
            this.Controls.Add(this.btnSubmit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "frmScrabble";
            this.Text = "Scrabble";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmScrabble_Load);
            this.optionsToolStrip.ResumeLayout(false);
            this.optionsToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLegend)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion



        private void InitializeButtonLetters()
        {
            btnLetters = new List<Button>();
            randomLetters = new Random();

            Letter letter = new Letter();

            int subtractionValue; 
            int x; 



            // Calculates the x position of the leftmost letter button, on letters surfaces

            subtractionValue = MAX_LETTERS_CAN_HOLD + 1 - MAX_LETTERS_CAN_HOLD % 2;

            x = 41 + 15 * (15 - subtractionValue);



            for (int i = 0; i < MAX_LETTERS_CAN_HOLD; i++)
            {
                char randomLetter = (char)randomLetters.Next('A', 'Z' + 2);

                if (randomLetter == 'Z' + 1)
                {
                    randomLetter = ' ';
                }


                Button button = new Button()
                {
                    Font = new Font("Cooper Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 177),
                    Location = new Point(x, 496),
                    Size = new Size(30, 30),
                    TabIndex = BOARD_SIZE + i,
                    Text = randomLetter.ToString(),
                    BackColor = letter.GetColor(randomLetter)
                };


                button.MouseDown += new MouseEventHandler(btnLetters_MouseDown);
                btnLetters.Add(button);
                Controls.Add(button);

                x += 30;
            }
            
        }



        private void InitializeBoardSquares()
        {
            lblBoardSquares = new Label[BOARD_SIZE];

            int x = 41;
            int y = 18 - 30;


            for (int i = 0; i < lblBoardSquares.Length; i++)
            {
                if ((i % 15) == 0)
                {
                    x = 41;
                    y += 30;
                }

                else
                {
                    x += 30;
                }



                lblBoardSquares[i] = new Label()
                {
                    AllowDrop = true,
                    BorderStyle = BorderStyle.Fixed3D,
                    Font = new Font("Cooper Black", 11F, FontStyle.Bold, GraphicsUnit.Point, 177),
                    Location = new Point(x, y),
                    Name = "lblBoardSquares",
                    Size = new Size(30, 30),
                    TabIndex = i
                };


                lblBoardSquares[i].DragDrop += new DragEventHandler(lblBoardSquares_DragDrop);
                lblBoardSquares[i].DragEnter += new DragEventHandler(lblBoardSquares_DragEnter);
                lblBoardSquares[i].Paint += new PaintEventHandler(lblBoardSquares_Paint);

                lblBoardSquares[i].Click += new EventHandler(lblBoardSquares_Click);
                Controls.Add(lblBoardSquares[i]);

            }


            // The following line marks the center square of the board 

            lblBoardSquares[BOARD_SIZE / 2].BorderStyle = BorderStyle.FixedSingle;

        } 



        private void InitializeLettersSurfaces()
        {
            lblLettersSurfaces = new Label[MAX_LETTERS_CAN_HOLD];

            int subtractionValue;
            int x;


            // Calculates the x position of the leftmost letter label, on letters surfaces

            subtractionValue = MAX_LETTERS_CAN_HOLD + 1 - MAX_LETTERS_CAN_HOLD % 2;

            x = 41 + 15 * (15 - subtractionValue);



            for (int i = 0; i < lblLettersSurfaces.Length; i++)
            {
                lblLettersSurfaces[i] = new Label()
                {
                    AllowDrop = true,
                    Location = new Point(x, 496),
                    Name = "lblLettersSurfaces",
                    Size = new Size(30, 30),
                    TabIndex = i
                };

                lblLettersSurfaces[i].DragDrop += new DragEventHandler(lblLettersSurfaces_DragDrop);
                lblLettersSurfaces[i].DragEnter += new DragEventHandler(lblLettersSurfaces_DragEnter);
                Controls.Add(lblLettersSurfaces[i]);

                x += 30;
            }

        }





        /* Gets the bonus type, according to the TabIndex of the current label.
           If there is a bonus - draw it on the board */

        private void lblBoardSquares_Paint(object sender, PaintEventArgs e)
        {
            Label label = (Label)sender;

            string bonusType = bonuses.FirstOrDefault(kvp => kvp.Key.Contains(label.TabIndex)).Value;


            if (bonusType != null)
            {
                DrawBonus(label.Location, bonusType, e);
            }

        }



        private void DrawBonus(Point bonusLocation, string bonusType, PaintEventArgs e)
        {
            Color color = bonusesColors[bonusType];

            if (!squaresBonuses.ContainsKey(bonusLocation))
            {
                squaresBonuses.Add(bonusLocation, bonusType);
            }


            if (isCircleBonuses)
            {
                e.Graphics.FillEllipse(new SolidBrush(color), new Rectangle(6, 6, 15, 15));
            }

            else
            {
                e.Graphics.FillRectangle(new SolidBrush(color), new Rectangle(0, 0, 30, 30));
            }


            e.Graphics.DrawString(bonusType, Font, new SolidBrush(Color.White), 5, 7);

        }




        private void InitializeLettersValuesGridView()
        {
            dgvLettersValues = new DataGridView()
            {
                AllowUserToResizeRows = false,
                AllowUserToResizeColumns = false,
                RowHeadersVisible = false,
                ColumnHeadersVisible = false,

                Enabled = false,
                Visible = false,

                Location = new Point(503, 18),
                Size = new Size(83, 445)
            };


            DataGridViewTextBoxColumn letters = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn points = new DataGridViewTextBoxColumn();

            letters.Width = 40;
            points.Width = 40;



            dgvLettersValues.Columns.AddRange(new DataGridViewColumn[] {letters, points});


            for (char ch = 'A'; ch <= 'Z'; ch++)
            {
                if (ch < 'Z')
                {
                    dgvLettersValues.Rows.Add();
                }



                Letter letter = new Letter();

                DataGridViewRow currentRow = dgvLettersValues.Rows[ch - 'A'];


                currentRow.Height = 17;
                currentRow.Cells[0].Value = ch;
                currentRow.Cells[1].Value = letter.GetPoints(ch);


                // Updates row color , according to the color of the letter (for each letter)

                currentRow.DefaultCellStyle.BackColor = letter.GetColor(ch);

            }

            Controls.Add(dgvLettersValues);

        }



        private void InitializeFirstWordHintListBox()
        {
            lstBestWords = new ListBox();
            Controls.Add(lstBestWords);

            lstBestWords.Visible = false;

            lstBestWords.Location = new Point(600, 320);
            lstBestWords.DoubleClick += new EventHandler(this.lstBestWords_DoubleClick);
        }



        private void btnLetters_MouseDown(object sender, MouseEventArgs e)
        {
            SkipToLastMove();

            btnLetterToDrag = (Button)sender;
            btnLetterToDrag.DoDragDrop(btnLetterToDrag.Text, DragDropEffects.Move);
        }


        private void lblBoardSquares_DragDrop(object sender, DragEventArgs e)
        {
            /* If , after putting a letter on the board , we dragged
               it to another square on the board , then the old letter's 
               button is being removed from wordPutOnBoard List .
               This check is done by the Contains method below */

            if (wordPutOnBoard.Contains(btnLetterToDrag))
            {
                wordPutOnBoard.Remove(btnLetterToDrag);
            }


            Label lblBoardSquare = (Label)sender;
            btnLetterToDrag.Location = lblBoardSquare.Location;


            if (btnLetterToDrag.Text == " ")
            {
                frmWildCard wildCardForm = new frmWildCard();
                wildCardForm.ShowDialog();

                btnLetterToDrag.Text = wildCardForm.GetWildCardLetter();


                /* Treats the case we had a blank wild card ,
                   clicked on the First Word Hint button and
                   immediately changed the letter in the
                   wild card .
                   In this case , we have to re-calculate the
                   First Word Hint and show the updated hint */

                if (Controls.Contains(lstBestWords))
                {
                    lstBestWords.Visible = false;

                    btnFirstWordHint.Visible = true;
                    btnFirstWordHint.PerformClick();
                }

            }


            wordPutOnBoard.Add(btnLetterToDrag);

        }


        private void lblBoardSquares_DragEnter(object sender, DragEventArgs e)
        {
            // Change the drag cursor to show valid data ready

            if (e.AllowedEffect == DragDropEffects.Move)
            {
                e.Effect = DragDropEffects.Move;
            }

        }


        private void lblLettersSurfaces_DragDrop(object sender, DragEventArgs e)
        {
            /* we apply the same remove , as we did in  
               lblBoardSquares_DragDrop above */

            if (wordPutOnBoard.Contains(btnLetterToDrag))
            {
                wordPutOnBoard.Remove(btnLetterToDrag);
            }


            Label lblLetterSurface = (Label)sender;
            btnLetterToDrag.Location = lblLetterSurface.Location;

        }


        private void lblLettersSurfaces_DragEnter(object sender, DragEventArgs e)
        {
            // Change the drag cursor to show valid data ready

            if (e.AllowedEffect == DragDropEffects.Move)
            {
                e.Effect = DragDropEffects.Move;
            }

        }


        private void lblBoardSquares_Click(object sender, EventArgs e)
        {
            foreach (Label label in lblBoardSquares)
            {
                label.Image = null;
            }

            lblLabelToPut = (Label)sender;

        }





        private List<Button> btnLetters;

        private Dictionary<List<int>, string> bonuses = new Dictionary<List<int>, string>
        {
            {new List<int> {3, 11, 45, 59, 165, 179, 213, 221}, "3w"},
            {new List<int> {6, 8, 48, 56, 80, 84, 90, 104, 120, 134, 140, 144, 168, 176, 216, 218}, "3L"},
            {new List<int> {20, 24, 52, 76, 88, 108, 116, 136, 148, 172, 200, 204}, "2w"},
            {new List<int> {17, 27, 31, 34, 40, 43, 62, 66, 68, 72, 94, 100, 124, 130, 152, 156, 158, 162, 181, 184, 190, 193, 197, 207}, "2L"}
        };


        private Dictionary<string, Color> bonusesColors = new Dictionary<string, Color>
        {
            {"3w", Color.Blue},
            {"3L", Color.Black},
            {"2w", Color.CornflowerBlue},
            {"2L", Color.Gray}
        };



        private Dictionary<Point, String> squaresBonuses = new Dictionary<Point, String>();

        private Label[] lblBoardSquares;
        private Label[] lblLettersSurfaces;

        private Label lblLabelToPut = new Label();

        private Button btnLetterToDrag;
        private Random randomLetters;

        private Button btnSubmit;
        private Button btnPass;
        private Label lblScore;
        private PictureBox picLegend;
        private Label lblLettersRemaining;

        private Button btnFirstWordHint;
        private ListBox lstBestWords;


        // Following variables were added in ver. 1.8

        private DataGridView dgvLettersValues;

        private ToolStrip optionsToolStrip;
        private ToolStripButton speakLegalWordsToolStripButton;
        private ToolStripButton backgroundColorToolStripButton;
        private ToolStripButton circleBonusesToolStripButton;
        private ToolStripButton sortLettersToolStripButton;
        private ToolStripButton shuffleLettersToolStripButton;
        private ToolStripButton historyBackToolStripButton;
        private ToolStripButton historyNextToolStripButton;
        private ToolStripButton lettersValuesToolStripButton;

    }

}

