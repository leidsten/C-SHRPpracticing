using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HangmanTest
{
    internal class GetAGuessword
    {
        //array of words
        public string _guessword { get; private set; } //get - trenger vel ikke settes utenfra? :o
        private string[] _guessWords = { "regnskyll", "skilpadde", "edderkopp", "bordvifte" };

        //trigger randomword funk  -- er det "lov" i en ctor?

        public GetAGuessword()
        {
            GetRandomWord();
        }


        //function to get one random word
        private void GetRandomWord()
        {
            Random random = new Random();
            int randomIndex = random.Next(0, _guessWords.Length);

            _guessword = _guessWords[randomIndex];

        }

        //eller kanskje en public funkis som returner?
        public string GetWord()
        {
            return _guessword;
        }



    }
}
