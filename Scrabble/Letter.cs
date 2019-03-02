using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;


namespace Scrabble
{
    class Letter
    {
        private Color ORANGE = Color.FromArgb(251, 197, 24);
        private Color BLUE = Color.FromArgb(152, 150, 240);
        private Color GREEN = Color.FromArgb(186, 196, 67);
        private Color LIGHTGREEN = Color.FromArgb(171, 230, 95);
        private Color PURPLE = Color.FromArgb(205, 111, 243);


        private char name;
        private int points;
        private Color color;
        private List<Letter> abcLetters;


        public Letter()
        {
            abcLetters = new List<Letter>();
            SetLettersAttributes();
        }


        public Letter(char name, int points, Color color)
        {
            this.name = name;
            this.points = points;
            this.color = color;
        }


        private void SetLettersAttributes()
        {
            List<Color> lettersColors = new List<Color> {Color.OrangeRed, ORANGE, BLUE, GREEN, LIGHTGREEN, PURPLE};

            Button[] btnLetters = frmOptions.GetButtonsLetters();


            foreach (Button button in btnLetters)
            {
                int letterValue = (int)button.Tag;
                int colorIndex = letterValue < lettersColors.Count ? letterValue : 0;

                abcLetters.Add(new Letter(button.Text[0], letterValue, lettersColors[colorIndex]));
            }

            abcLetters.Add(new Letter(' ', 0, Color.White));

        }



        public Color GetColor(char letter)
        {
            return abcLetters.Find(x => x.name == letter).color;
        }


        public int GetPoints(char letter)
        {
            return abcLetters.Find(x => x.name == letter).points;
        }

    }

}
