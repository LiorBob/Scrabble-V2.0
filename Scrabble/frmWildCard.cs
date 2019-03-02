using System;
using System.Windows.Forms;



namespace Scrabble
{
    public partial class frmWildCard : Form
    {
        public frmWildCard()
        {
            InitializeComponent();

            cmbWildCardLetters.SelectedIndex = 0;
        }


        /// <summary>
        /// If Enter key was pressed on combo , accept letter and close form
        /// </summary>

        private void cmbWildCardLetters_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)   
            {
                btnOK.PerformClick();   
            }
        }


        private void btnOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public string GetWildCardLetter()
        {
            return (string)cmbWildCardLetters.SelectedItem;
        }

    }

}