using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HangmanTest
{
    internal class GetNumberOfLettersInGuessWord
    {
        //recieve the random word to guess - return how many letters it has.

        //constructor - word as param  ?
        private string _guessWord;

        public GetNumberOfLettersInGuessWord(string guessWord)
        {
            _guessWord = guessWord;
        }

        public int CalcLengthOfWord()
        {
            var wLength = _guessWord.Length;
            return wLength;
        }
    }
}
