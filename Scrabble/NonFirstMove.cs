using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using SpeechLib;



namespace Scrabble
{
    class NonFirstMove
    {
        private List<Button> lettersPutOnBoard;
        private List<Button> wordPutOnBoard;

        private List<String> dictionary;
        private List<String> wordsCombined;

        private Dictionary<Point, String> squaresBonuses;

        private List<List<Button>> buttonsCombined;

        private Label[] lblBoardSquares;

        private string wordsCombinationsPoints;
        
        private int score;

        private bool isMoveOK = false;
        private bool isSpeakLegalWords;



        public NonFirstMove(List<Button> lettersPutOnBoard, List<Button> wordPutOnBoard, Label[] lblBoardSquares, Dictionary<Point, String> squaresBonuses, List<String> dictionary, int score, bool isSpeakLegalWords)
        {
            wordsCombined = new List<String>();
            buttonsCombined = new List<List<Button>>();

            this.lettersPutOnBoard = lettersPutOnBoard;
            this.wordPutOnBoard = wordPutOnBoard;
            this.lblBoardSquares = lblBoardSquares;
            this.squaresBonuses = squaresBonuses;
            this.dictionary = dictionary;
            this.score = score;
            this.isSpeakLegalWords = isSpeakLegalWords;

            InvokeNonFirstMove();
        }



        private void InvokeNonFirstMove()
        {
            if (!CheckWordAdjacent())
            {
                MessageBox.Show("The word you put must be adjacent to existing word on the board", Application.ProductName);
                return;
            }


            if (!CheckWordPutCorrectly())
            {
                MessageBox.Show("The word must be put either horizontally or vertically , and without spaces", Application.ProductName);
                return;
            }



            string incorrectWords = "";


            foreach (String wordPut in wordsCombined)
            {
                if (!CheckWordFound(wordPut))
                {
                    incorrectWords += "'" + wordPut.ToLower() + "' " + "is not a word.\n";
                }
            }



            // At least 1 incorrect word

            if (incorrectWords != "")
            {
                MessageBox.Show(incorrectWords, Application.ProductName);
                return;
            }



            // All words are correct  - they are all found in dictionary

            wordsCombinationsPoints = "";

            int totalWordsPoints = 0;



            // Speak the combined words

            if (isSpeakLegalWords)
            {
                SpVoice objSpeak = new SpVoice();

                objSpeak.Voice = objSpeak.GetVoices("", "").Item(0);     // Microsoft Anna


                for (int i = 0; i < wordsCombined.Count; i++)
                {
                    objSpeak.Speak(wordsCombined[i].ToLower(), SpeechVoiceSpeakFlags.SVSFDefault);
                }
            }

                
            // Calculate score for all words together

            for (int i = 0; i < wordsCombined.Count; i++)
            {
                int wordPoints = GetWordPoints(wordsCombined[i], i);

                totalWordsPoints += wordPoints;
                score += wordPoints;
            }


            ToolTip toolTipWordPoints = new ToolTip();
            toolTipWordPoints.BackColor = Color.MediumSpringGreen;

            wordsCombinationsPoints = totalWordsPoints + " points given.\n\n" + wordsCombinationsPoints;
                
            toolTipWordPoints.Show(wordsCombinationsPoints, lblBoardSquares[0], 563, 300, 6000);


            isMoveOK = true;

        }



        private bool CheckWordAdjacent()
        {
            bool isAdjacentHorizontally;
            bool isAdjacentVertically; 


            foreach (Button a in wordPutOnBoard)
            {
                foreach (Button b in lettersPutOnBoard)
                {
                    isAdjacentHorizontally = (a.Location.Y == b.Location.Y) && (Math.Abs(a.Location.X - b.Location.X) == a.Width);
                    isAdjacentVertically = (a.Location.X == b.Location.X) && (Math.Abs(a.Location.Y - b.Location.Y) == a.Height);


                    if (isAdjacentHorizontally || isAdjacentVertically)
                    {
                        return true;
                    }

                }

            }

            return false;

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


                if (!ReadWordFromLeft(wordPutOnBoard[0]))
                {
                    return false;
                }


                foreach (Button button in wordPutOnBoard)
                {
                    ReadWordFromTop(button);
                } 


                return true;            
  
            }


            else if (hasToSortCoordinatesByY) // Word is put vertically 
            {
                wordPutOnBoard.Sort((b1, b2) => b1.Location.Y.CompareTo(b2.Location.Y));


                if (!ReadWordFromTop(wordPutOnBoard[0]))
                {
                    return false;
                }

                foreach (Button button in wordPutOnBoard)
                {
                    ReadWordFromLeft(button);
                }  


                return true;            

            }


            else   // Neither horizontally nor vertically :  illegal 
            {
                return false;
            }

        }



        private bool ReadWordFromLeft(Button button)
        {
            List<Button> combinedButtons = new List<Button>();
            combinedButtons.Add(button);

            string combinedWord = button.Text;
            int i = GetSquareIndex(button);


            if (i % 15 != 0)    // Leftmost letter is not on left edge of current row
            {
                CombineWithLeftSide(i, ref combinedWord , combinedButtons);
            }


            if (i % 15 != 14)   // Rightmost letter is not on right edge of current row
            {
                if (!CombineWithRightSide(i, ref combinedWord , combinedButtons))
                {
                    return false;
                }
            }


            if (combinedWord.Length > 1)
            {
                buttonsCombined.Add(combinedButtons);
                wordsCombined.Add(combinedWord);
            }

            return true;

        }



        /* Go left , until a blank square found  or start of row
           encountered, to find the leftmost letter of combined word .
           Using the ref keyword , we overwrite combinedWord in the
           caller method ReadWordFromLeft . */

        private void CombineWithLeftSide(int i, ref string combinedWord, List<Button> combinedButtons)
        {
            do
            {
                i--;

                bool isBlankSquare = true;

                foreach (Button button in lettersPutOnBoard)
                {
                    if (lblBoardSquares[i].Location == button.Location)
                    {
                        combinedButtons.Insert(0, button);

                        combinedWord = button.Text + combinedWord;
                        isBlankSquare = false;

                        break;
                    }
                }

                if (isBlankSquare)
                {
                    break;
                }

            } 
            
            while (i % 15 != 0);
             
        }



        /* Go right , until a blank square found  or end of row
           encountered, to find the rightmost letter of combined word */

        private bool CombineWithRightSide(int i, ref string combinedWord, List<Button> combinedButtons)
        {
            List<Button> buttonsPutOnBoard = new List<Button>(wordPutOnBoard);

            buttonsPutOnBoard.AddRange(lettersPutOnBoard);


            do
            {
                i++;

                bool isBlankSquare = true;


                foreach (Button button in buttonsPutOnBoard)
                {
                    if (lblBoardSquares[i].Location == button.Location)
                    {
                        combinedButtons.Add(button);

                        combinedWord += button.Text;
                        isBlankSquare = false;

                        break;
                    }

                }

                if (isBlankSquare)
                {
                    break;
                }

            }

            while (i % 15 != 14);


            return CheckNoSpaceX(i);

        }



        private bool CheckNoSpaceX(int i)
        {
            bool isNoSpaceX = true;

            foreach (Button b in wordPutOnBoard)
            {
                if (b.Location.X > lblBoardSquares[i].Location.X)
                {
                    isNoSpaceX = false;
                    break;
                }
            }

            return isNoSpaceX;
        }
 


        private bool ReadWordFromTop(Button button)
        {
            List<Button> combinedButtons = new List<Button>();
            combinedButtons.Add(button);

            string combinedWord = button.Text;
            int i = GetSquareIndex(button);


            if (i / 15 != 0)    // uppermost letter is not on upper edge of current column
            {
                CombineWithUpperSide(i, ref combinedWord, combinedButtons);
            }


            if (i / 15 != 14)   // Lowermost letter is not on lower edge of current column
            {
                if (!CombineWithLowerSide(i, ref combinedWord, combinedButtons))
                {
                    return false;
                }
            }


            if (combinedWord.Length > 1)
            {
                buttonsCombined.Add(combinedButtons);
                wordsCombined.Add(combinedWord);
            }

            return true;

        }



        private void CombineWithUpperSide(int i, ref string combinedWord, List<Button> combinedButtons)
        {
            do
            {
                i -= 15;

                bool isBlankSquare = true;

                foreach (Button button in lettersPutOnBoard)
                {
                    if (lblBoardSquares[i].Location == button.Location)
                    {
                        combinedButtons.Insert(0, button);

                        combinedWord = button.Text + combinedWord;
                        isBlankSquare = false;

                        break;
                    }
                }

                if (isBlankSquare)
                {
                    break;
                }

            }

            while (i / 15 != 0);

        }



        private bool CombineWithLowerSide(int i, ref string combinedWord, List<Button> combinedButtons)
        {
            List<Button> buttonsPutOnBoard = new List<Button>(wordPutOnBoard);

            buttonsPutOnBoard.AddRange(lettersPutOnBoard);


            do
            {
                i += 15;

                bool isBlankSquare = true;


                foreach (Button button in buttonsPutOnBoard)
                {
                    if (lblBoardSquares[i].Location == button.Location)
                    {
                        combinedButtons.Add(button);

                        combinedWord += button.Text;
                        isBlankSquare = false;

                        break;
                    }

                }

                if (isBlankSquare)
                {
                    break;
                }

            }

            while (i / 15 != 14);


            return CheckNoSpaceY(i);

        }



        private bool CheckNoSpaceY(int i)
        {
            bool isNoSpaceY = true;

            foreach (Button b in wordPutOnBoard)
            {
                if (b.Location.Y > lblBoardSquares[i].Location.Y)
                {
                    isNoSpaceY = false;
                    break;
                }
            }

            return isNoSpaceY;
        }



        private int GetSquareIndex(Button button)
        {
            int squareIndex = Array.FindIndex(lblBoardSquares, x => x.Location == button.Location);

            return squareIndex;
        }



        private bool CheckWordFound(string wordPut)
        {
            return dictionary.BinarySearch(wordPut) >= 0;
        }



        private int GetWordPoints(string word, int i)
        {
            int wordPoints = 0;
            int multiplyFactor = 1;

            Letter letter = new Letter();

            foreach (char lett in word)
            {
                wordPoints += letter.GetPoints(lett);
            }


            int delay = 1500;


            foreach (Button button in buttonsCombined[i])
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

                delay += 100;

            }



            foreach (Button button in wordPutOnBoard)
            {
                if (!buttonsCombined[i].Contains(button))
                {
                    continue;
                }



                if (squaresBonuses.ContainsKey(button.Location))
                {
                    squaresBonuses.TryGetValue(button.Location, out string bonus);

                    int multiplier = bonus[0] - '0';        // Converts char digit to int


                    switch (bonus[1])                       // Treats bonus ends with w or L
                    {
                        case 'w':

                            multiplyFactor *= multiplier;
                            break;


                        case 'L':

                            ToolTip toolTipLetter = new ToolTip();


                            if (button.BackColor != Color.White)
                            {
                                wordPoints += letter.GetPoints(button.Text[0]) * (multiplier - 1);
                                toolTipLetter.Show(letter.GetPoints(button.Text[0]) + "x" + multiplier, button, 1, 1, delay);
                            }

                            else         // white button :  0 points
                            {
                                toolTipLetter.Show("0x" + multiplier, button, 1, 1, delay);
                            }

                            break;

                    }

                }

            }


            if (multiplyFactor > 1)
            {
                ToolTip toolTipDoubleWord = new ToolTip();

                toolTipDoubleWord.BackColor = Color.LightCyan;


                if (buttonsCombined[i][0].Location.Y == buttonsCombined[i][1].Location.Y)
                {
                    toolTipDoubleWord.Show(wordPoints + " x " + multiplyFactor, buttonsCombined[i][buttonsCombined[i].Count - 1], 30, 0, 3000);
                }

                else
                {
                    toolTipDoubleWord.Show(wordPoints + " x " + multiplyFactor, buttonsCombined[i][buttonsCombined[i].Count - 1], 0, 30, 3000);
                }

            }


            wordPoints *= multiplyFactor;

            wordsCombinationsPoints += "'" + word + "' : " + wordPoints + " points\n";


            return wordPoints;

        }



        public bool CheckMoveOK()
        {
            return isMoveOK;
        }



        public int GetScore()
        {
            return score;
        }

    }

}
