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
        private string _letterGuess;
        bool _letterExists;

        public DrawDashesAndLetters(int wordLength, int letterIndex, string letterGuess, bool letterExists)
        {
            _numberOfDashes = wordLength;
            _letterIndex = letterIndex;
            _letterGuess = letterGuess;
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
                if (i == _letterIndex && _letterGuess != " " && _letterExists)
                {
                    _allDashes.Add(_letterGuess);
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
