using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using SpeechLib;


namespace Scrabble
{
    class FirstMove
    {
        private List<Button> wordPutOnBoard;
        private List<String> dictionary;

        private Dictionary<Point, String> squaresBonuses;

        private Label lblBoardCenter;

        private int score;

        private bool isStillFirstMove = true;
        private bool isSpeakLegalWords;



        public FirstMove(List<Button> wordPutOnBoard, Label lblBoardCenter, Dictionary<Point, String> squaresBonuses, List<String> dictionary, bool isSpeakLegalWords)
        {
            this.wordPutOnBoard = wordPutOnBoard;
            this.squaresBonuses = squaresBonuses;
            this.dictionary = dictionary;
            this.lblBoardCenter = lblBoardCenter;
            this.isSpeakLegalWords = isSpeakLegalWords;

            InvokeFirstMove();
        }



        private void InvokeFirstMove()
        {
            if (!CheckCenterOccupied())
            {
                MessageBox.Show("The center of the board must be occupied", Application.ProductName);
                return;
            }


            /* Now we check if the word is put correctly on board 
               (must be put either horizontally or vertically) */

            if (!CheckWordPutCorrectly())
            {
                MessageBox.Show("The word must be put either horizontally or vertically , and without spaces", Application.ProductName);
                return;
            }


            string wordPut = GetWordPut();


            if (CheckWordFound(wordPut))   // word was found in dictionary
            {
                if (isSpeakLegalWords)
                {
                    SpVoice objSpeak = new SpVoice();

                    objSpeak.Voice = objSpeak.GetVoices("", "").Item(0);     // Microsoft Anna
                    objSpeak.Speak(wordPut.ToLower(), SpeechVoiceSpeakFlags.SVSFDefault);
                }

                score = GetWordPoints(wordPut);

                isStillFirstMove = false;

            }

            else    // word was not found in dictionary
            {
                MessageBox.Show("'" + wordPut.ToLower() + "' " + "is not a word.", Application.ProductName);
            } 

        }




        /* Checks if center of the board is occupied :
           If wordPutOnBoard list contains a button , which location
           is the location of the centric-label on the board 
           (lblBoardSquares[BOARD_SIZE / 2].Location) ,
           then the center of the board is occupied ;
           Otherwise , the center is not occupied */

        private bool CheckCenterOccupied()
        {
            return wordPutOnBoard.Exists(x => x.Location == lblBoardCenter.Location);
        }



        private bool CheckWordPutCorrectly()
        {
            bool hasToSortCoordinatesByX = true;
            bool hasToSortCoordinatesByY = true;


            foreach (Button button in wordPutOnBoard)
            {
                if (button.Location.Y != wordPutOnBoard[0].Location.Y)
                {
                    hasToSortCoordinatesByX = false;
                }

                if (button.Location.X != wordPutOnBoard[0].Location.X)
                {
                    hasToSortCoordinatesByY = false;
                }
            }



            /*  If All Y-coordinates are identical , then sort
                the letter locations , by the X-Coordinates of the 
                locations of the word put on board ;
                The word is put horizontally */

            if (hasToSortCoordinatesByX)
            {
                wordPutOnBoard.Sort((b1, b2) => b1.Location.X.CompareTo(b2.Location.X));

                return CheckNoSpaceX();
            }

            else if (hasToSortCoordinatesByY)   // Word is put vertically 
            {
                wordPutOnBoard.Sort((b1, b2) => b1.Location.Y.CompareTo(b2.Location.Y));

                return CheckNoSpaceY();
            }

            else   // Neither horizontally nor vertically :  illegal 
            {
                return false;
            }

        }



        /* Checks if a word , which is put horizontally , contains
           no spaces */

        private bool CheckNoSpaceX()
        {
            bool isNoSpaceX = true;

            for (int i = 0; i < wordPutOnBoard.Count - 1; i++)
            {
                if (wordPutOnBoard[i].Location.X + wordPutOnBoard[0].Width != wordPutOnBoard[i + 1].Location.X)
                {
                    isNoSpaceX = false;
                    break;
                }
            }

            return isNoSpaceX;
        }



        /* Checks if a word , which is put vertically , contains
           no spaces */

        private bool CheckNoSpaceY()
        {
            bool isNoSpaceY = true;

            for (int i = 0; i < wordPutOnBoard.Count - 1; i++)
            {
                if (wordPutOnBoard[i].Location.Y + wordPutOnBoard[0].Height != wordPutOnBoard[i + 1].Location.Y)
                {
                    isNoSpaceY = false;
                    break;
                }
            }

            return isNoSpaceY;
        }



        // Returns the word just put on the board

        private string GetWordPut()
        {
            var wordText = wordPutOnBoard.Select(x => x.Text);

            return string.Concat(wordText);
        }



        private bool CheckWordFound(string wordPut)
        {
            return dictionary.BinarySearch(wordPut) >= 0;
        }


        private int GetWordPoints(string word)
        {
            int wordPoints = 0;
            int multiplyFactor = 1;

            Letter letter = new Letter();

            foreach (char lett in word)
            {
                wordPoints += letter.GetPoints(lett);
            }


            int delay = 1500;


            /* If the first word is put on a bonus square, this bonus
               must be 2w */

            foreach (Button button in wordPutOnBoard)
            {
                ToolTip toolTipLetter = new ToolTip();


                if (button.BackColor == Color.White)
                {
                    wordPoints -= letter.GetPoints(button.Text[0]);
                    toolTipLetter.Show("0", button, 1, 1, delay);
                }

                else
                {
                    toolTipLetter.Show(letter.GetPoints(button.Text[0]) + "", button, 1, 1, delay);
                }


                if (squaresBonuses.ContainsKey(button.Location))
                {
                    multiplyFactor *= 2;
                }

                delay += 100;

            }


            if (multiplyFactor > 1)
            {
                ToolTip toolTipDoubleWord = new ToolTip();

                toolTipDoubleWord.BackColor = Color.LightCyan;


                if (wordPutOnBoard[0].Location.Y == wordPutOnBoard[1].Location.Y)
                {
                    toolTipDoubleWord.Show(wordPoints + " x " + multiplyFactor, wordPutOnBoard[wordPutOnBoard.Count / 2], 0, 30, 2500);
                }

                else
                {
                    toolTipDoubleWord.Show(wordPoints + " x " + multiplyFactor, wordPutOnBoard[wordPutOnBoard.Count / 2], 30, 0, 2500);
                }

            }


            wordPoints *= multiplyFactor;


            ToolTip toolTipWordPoints = new ToolTip();

            toolTipWordPoints.BackColor = Color.MediumSpringGreen;


            if (wordPutOnBoard[0].Location.Y == wordPutOnBoard[1].Location.Y)
            {
                toolTipWordPoints.Show("'" + word + "' : " + wordPoints + " points", wordPutOnBoard[wordPutOnBoard.Count - 1], 30, 0, 4000);
            }

            else
            {
                toolTipWordPoints.Show("'" + word + "' : " + wordPoints + " points", wordPutOnBoard[wordPutOnBoard.Count - 1], 0, 30, 4000);
            }


            return wordPoints;

        }


        public bool CheckStillFirstMove()
        {
            return isStillFirstMove;
        }


        public int GetScore()
        {
            return score;
        }

    }

}
