using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;


/* The following form is being shown when clicking "Pass" from
   the main game form */

namespace Scrabble
{
    public partial class frmPass : Form
    {
        // Buttons with same letters as in the main game form
        
        private List<Button> btnLetters;    
        private List<int> indicesLettersToReplace;
        private ToolTip toolTip;


        public frmPass(List<Button> btnLettersToReplace, int maxLettersToReplace)
        {
            InitializeComponent();

            toolTip = new ToolTip();
            toolTip.SetToolTip(chbSelectAll, "Select All");


            if (maxLettersToReplace > 7)
            {
                ClientSize = new Size(268 + 30 * (maxLettersToReplace - 7), 100);
                btnPass.Location = new Point(ClientSize.Width / 3, 57);
                btnCancel.Location = new Point(ClientSize.Width / 3 + 83, 57);
                chbSelectAll.Location = new Point(ClientSize.Width / 3 + 165, 67);
            }

            InitializeButtonLetters(btnLettersToReplace, maxLettersToReplace);
        }


        private void InitializeButtonLetters(List<Button> btnLettersToReplace, int maxLettersToReplace)
        {
            btnLetters = new List<Button>();
            indicesLettersToReplace = new List<int>();

            Letter letter = new Letter();

            int x = 30;



            /* Places the buttons on the form , with the same
               letters as in the main game form */

            for (int i = 0; i < maxLettersToReplace; i++)
            {
                Button button = new Button()
                {
                    Font = new Font("Cooper Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 177),
                    Location = new Point(x, 10),
                    Size = new Size(30, 30),
                    TabIndex = i,
                    Tag = false,
                    Text = btnLettersToReplace[i].Text
                };

                button.BackColor = letter.GetColor(button.Text[0]);
                button.Click += new EventHandler(btnLetters_Click);
                btnLetters.Add(button);
                Controls.Add(button);

                x += 30;
            }

        }


        private void btnLetters_Click(object sender, EventArgs e)
        {
            Button btnLetterToReplace = (Button)sender;

            int tabIndex = btnLetterToReplace.TabIndex;


            bool isLetterToBeReplaced = !(bool)btnLetters[tabIndex].Tag;

            btnLetters[tabIndex].Tag = isLetterToBeReplaced;


            FontStyle fontStyle = isLetterToBeReplaced ? FontStyle.Bold | FontStyle.Underline : FontStyle.Bold;

            btnLetterToReplace.Font = new Font("Cooper Black", 12F, fontStyle, GraphicsUnit.Point, 177);

        }


        // Following LINQ statement selects indices of letters, which have tag = true (to replace)

        private void btnPass_Click(object sender, EventArgs e)
        {
            indicesLettersToReplace = btnLetters.Where(y => (bool)y.Tag == true).Select(x => x.TabIndex).ToList();

            Close();           
        }


        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();            // Closes the current form
        }


        public List<int> GetIndicesLettersToReplace()
        {
            return indicesLettersToReplace;
        }


        private void chbSelectAll_CheckedChanged(object sender, EventArgs e)
        {
            string selectDeselectAll = chbSelectAll.Checked ? "Deselect All" : "Select All";

            toolTip.SetToolTip(chbSelectAll, selectDeselectAll);


            foreach (Button button in btnLetters)
            {
                button.PerformClick();
            }

        }

    }

}