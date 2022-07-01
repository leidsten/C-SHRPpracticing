using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HangmanTest
{
    internal class CheckIfLetterExistsInWord
    {
        string _letterToCheck;
        string _word;
        public int _positionOfLetter { get; private set; }
        public bool _doesLetterExistInGuessword { get; private set; }
        public CheckIfLetterExistsInWord(string LetterToCheck, string word)
        {
            _letterToCheck = LetterToCheck;
            _word = word;
        }

        public void LookForLetter()
        {
            for (int i = 0; i < _word.Length; i++)
            {
                if (_word[i].ToString() == _letterToCheck)
                {
                    _positionOfLetter = i;
                    _doesLetterExistInGuessword = true;
                  
                    //return "found at position " + i;
                }
                else
                {
                    _positionOfLetter = -1;
                    _doesLetterExistInGuessword = false;
                    //return "not found.";
                }
            }
            //return "something went wrong...";

        }



    }
}
