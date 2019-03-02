using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;


namespace Scrabble
{
    class FirstWordHint
    {
        private const int FIVE = 5;
        private const int NINE = 9;

        private readonly int MAX_LETTERS_CAN_HOLD;
        private readonly int BINGO_BONUS;

        string buttonsWord;
        


        public FirstWordHint(List<String> dictionary, string buttonsOriginalWord, ListBox lstBestWords, int bingoBonus)
        {
            List<string> bestWords = new List<string>();
            int bestWordPoints = 0;
            
            MAX_LETTERS_CAN_HOLD = buttonsOriginalWord.Length / 2;
            BINGO_BONUS = bingoBonus;


            foreach (string word in dictionary)
            {
                buttonsWord = buttonsOriginalWord;

                int wordPoints = GetWordPoints(word);


                if (wordPoints >= bestWordPoints)
                {
                    if (wordPoints > bestWordPoints)
                    {
                        bestWordPoints = wordPoints;
                        bestWords.Clear();
                    }

                    bestWords.Add(word);

                }

            }



            List<string> bestWordsWithScore = new List<string>();


            foreach (string word in bestWords)
            {
                bestWordsWithScore.Add(bestWordPoints + "\t" + word);
            }

            lstBestWords.Items.AddRange(bestWordsWithScore.ToArray());



            if (bestWordPoints == 0)
            {
                lstBestWords.Items.Add("You have to click Pass button");
            }


            int numOfBestWordsFound = lstBestWords.Items.Count;            
            int height;


            if (numOfBestWordsFound == 1)
            {
                height = 20;
            }

            else if (numOfBestWordsFound < 13)
            {
                height = numOfBestWordsFound * 15;
            }

            else
            {
                height = 170;
            }
            

            lstBestWords.Size = new Size(190, height);

            lstBestWords.Visible = true;
            lstBestWords.BringToFront();    // updates best words list

            lstBestWords.Focus();

        }



        private int GetWordPoints(string word)
        {
            int wordPoints = 0;

            Letter letter = new Letter();

            foreach (char lett in word)
            {
                if (buttonsWord.Contains(lett.ToString()))
                {
                    int indexOfLetterToBeRemoved = buttonsWord.IndexOf(lett);

                    if (buttonsWord[indexOfLetterToBeRemoved + 1] != '*')
                    {
                        wordPoints += letter.GetPoints(lett);
                    }

                    buttonsWord = buttonsWord.Remove(indexOfLetterToBeRemoved, 1);
                    
                }

            }


            if ((word.Length >= FIVE) && (word.Length < NINE))
            {
                wordPoints *= 2;        // word can be put on one 2w 
            }


            if (word.Length >= NINE)
            {
                wordPoints *= 4;        // word can be put on two 2w 
            }


            if (word.Length == MAX_LETTERS_CAN_HOLD)
            {
                wordPoints += BINGO_BONUS;      // add bonus points
            }

            return wordPoints;

        }

    }

}
