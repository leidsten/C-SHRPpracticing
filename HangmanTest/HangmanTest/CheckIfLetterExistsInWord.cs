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

        public string LookForLetter()
        {
            if (_word.IndexOf(_letterToCheck) != -1)
            {
                _positionOfLetter = _word.IndexOf(_letterToCheck);
                _doesLetterExistInGuessword = true;
                return "found at position " + _word.IndexOf(_letterToCheck);
            }
            else
            {
                _positionOfLetter = -1;
                _doesLetterExistInGuessword = false;
                return "not found.";
            }
               
        }

    }
}
