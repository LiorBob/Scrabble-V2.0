using System;
using System.Windows.Forms;
using System.Threading.Tasks;




namespace Scrabble
{
    public partial class frmOptions : Form
    {
        private const int MAX_LETTER_VALUE = 9999;



        public frmOptions()
        {
            InitializeComponent();

            FadeIn(50);



            InitializeButtonLetters();

            udcLetterNewValue.Maximum = MAX_LETTER_VALUE;
        }


        private void btnOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        public int GetMaxLettersCanHold()
        {
            return (int)udcMaxLettersCanHold.Value;
        }


        private void udcLetterNewValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (udcLetterNewValue.Value.ToString().Length == MAX_LETTER_VALUE.ToString().Length) 
            {
                if (Char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                    udcLetterNewValue.Value = udcLetterNewValue.Minimum;
                }
            }


            if (e.KeyChar == (char)Keys.Enter)
            {
                btnLetter.Tag = (int)udcLetterNewValue.Value;

                UpdateLetterToolTip();
            }


            ResizeUpDownControl();
            
        }


        private void udcLetterNewValue_ValueChanged(object sender, EventArgs e)
        {
            ResizeUpDownControl();
        }


        private void ResizeUpDownControl()
        {
            if (udcLetterNewValue.Value.ToString().Length <= MAX_LETTER_VALUE.ToString().Length)
            {
                udcLetterNewValue.Width = 26 + udcLetterNewValue.Value.ToString().Length * 8;
            }

        }


        private void btnLetterRandomValue_Click(object sender, EventArgs e)
        {
            btnLetter.Tag = new Random().Next((int)udcLetterNewValue.Minimum, MAX_LETTER_VALUE + 1);

            UpdateLetterToolTip();
        }


        private void UpdateLetterToolTip()
        {
            btnLetterRandomValue.Visible = false;
            lblEnterNewValue.Visible = false;
            udcLetterNewValue.Visible = false;


            // Shows the new value of the letter , as its tooltip text

            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(btnLetter, btnLetter.Tag.ToString());


            // So when we update letter's value, its button's color will be changed accordingly

            Letter letter = new Letter();
            btnLetter.BackColor = letter.GetColor(btnLetter.Text[0]);


            btnLetter.Focus();
        }





        // So the "OK" button is the default button during changing Max Letters can hold value

        private void udcMaxLettersCanHold_Enter(object sender, EventArgs e)
        {
            this.AcceptButton = btnOK;
        }




        // "OK" button will not be activated  when Max Letters can hold control is out of focus
        
        private void udcMaxLettersCanHold_Leave(object sender, EventArgs e)
        {
            this.AcceptButton = null;
        }




        // Fade-In effect when form loads

        private async void FadeIn(int interval)
        {
            // Form is not fully invisible. Fade it in

            while (this.Opacity < 1)
            {
                await Task.Delay(interval);
                this.Opacity += 0.02;
            }

            this.Opacity = 1;   // make fully visible       
        }

    }

}