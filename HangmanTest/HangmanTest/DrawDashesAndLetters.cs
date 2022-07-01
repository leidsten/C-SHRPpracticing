using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HangmanTest
{
    internal class DrawDashesAndLetters
    {
        public int _numberOfDashes { get; set; }
        public List<string> _allDashes = new List<string>();
        private int _letterIndex;
        public string LetterGuess;
        bool _letterExists;

        public DrawDashesAndLetters(int wordLength, int letterIndex, string letterGuess, bool letterExists)
        {
            _numberOfDashes = wordLength;
            _letterIndex = letterIndex;
            LetterGuess = letterGuess;
            _letterExists = letterExists;
        }

        
        public void PopulateWithDashes()  /// denne skal BARE legge in dashes
        {
            for (int i = 0; i < _numberOfDashes; i++)
            {
               
                _allDashes.Add("_");
                
            }
        }

        //en funksjon til - som legger inn guessed letter på riktig index i lista.
        public void PopulateWithLetters()
        {
            for(int i = 0; i < _numberOfDashes; i++)
            {
                //ha en sjekk for at boktsven er riktig, ikke tom og at vi står på rett plass i lista
                if (i == _letterIndex && LetterGuess != " " && _letterExists)
                {
                    _allDashes.Insert(i, LetterGuess);
                   
                }
            }
        }
        

        public List<string> ReturnDashesAndLetters()
        {
            if(_allDashes.Count < 1) { PopulateWithDashes(); }
            else if(_allDashes.Count > 1) { PopulateWithLetters(); }
            else { Console.WriteLine("something went wrong..."); }
            
            return _allDashes;
        }

    }
}
