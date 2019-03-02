using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Threading.Tasks;
using System.Windows.Forms;




namespace Scrabble
{
    public partial class frmSplash : Form
    {
        private const int MAX_ANGLE = 360;


        private List<Color> gradientColors = new List<Color>()    
        {
            Color.Red,
            Color.Orange,
            Color.Yellow,
            Color.Green,
            Color.Blue,
            Color.Indigo,
            Color.Violet,
            Color.Cyan,
            Color.LightGreen,
            Color.DarkGreen,
            Color.White,
            Color.Black,
            Color.DarkOrange,
            Color.LightBlue,
            Color.Aqua,
            Color.Pink,
            Color.DarkViolet,
            Color.Brown,
            Color.Gold,
            Color.Silver
        };





        public frmSplash()
        {
            InitializeComponent();

            lblVersion.Text = "Version " + Application.ProductVersion.Substring(0, 3);
            lblCopyright.Text = lblCopyright.Text.Replace("(C)", "\u00A9");
        }



        private void tmrSplash_Tick(object sender, EventArgs e)
        {
            FadeOut(50);


            if (this.Opacity == 0)
            {
                this.Close();
            }
        }





        // Paints Title label as Linear Gradient Brush, with various colors

        private void lblTitle_Paint(object sender, PaintEventArgs e)
        {
            LinearGradientBrush brush = new LinearGradientBrush(lblTitle.ClientRectangle, Color.Black, Color.Black, LinearGradientMode.Horizontal);
            ColorBlend cb = new ColorBlend();



            // Random number of gradient colors in our Linear Gradient Brush

            int randomNumOfGradientColors = new Random().Next(1, gradientColors.Count + 1);

            cb.Positions = new float[randomNumOfGradientColors + 1];            
            cb.Colors = new Color[randomNumOfGradientColors + 1];


            float gradientStep = 1 / (float)randomNumOfGradientColors;

            int j = 0;



            // Builds the gradient stops array, along with its colors from gradient colors list defined above

            for (float i = 0; i <= 1.0; i += gradientStep)
            {
                cb.Positions[j] = i;
                cb.Colors[j] = gradientColors[j];

                j++;
            }



            // Defines last value in gradient stops array as 1.0  (if it's not 1)

            if (cb.Positions[randomNumOfGradientColors] != 1.0f)            
            {
                cb.Positions[randomNumOfGradientColors] = 1.0f;
            }


            brush.InterpolationColors = cb;



            // Rotates with Random angle between 1 and MAX_ANGLE

            int randomAngle = new Random().Next(1, MAX_ANGLE + 1);          

            brush.RotateTransform(randomAngle);



            // Paint

            e.Graphics.DrawString(lblTitle.Text, lblTitle.Font, brush, 0, lblTitle.Top);
        }






        private async void FadeOut(int interval)
        {
            // Form is fully visible. Fade it out

            while (this.Opacity > 0)
            {
                await Task.Delay(interval);
                this.Opacity -= 0.02;
            }

            this.Opacity = 0;        // make fully invisible       
        }
    }
}