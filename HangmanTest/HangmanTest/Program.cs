// See https://aka.ms/new-console-template for more information
using HangmanTest;


var guessWord = new GetAGuessword().GetWord();
var lengthOfWord = new GetNumberOfLettersInGuessWord(guessWord).CalcLengthOfWord();

var userLetterGuess = " ";
var checkForLetter = new CheckIfLetterExistsInWord(userLetterGuess, guessWord);

var letterIndex = checkForLetter._positionOfLetter;
var letterIsRight = checkForLetter._doesLetterExistInGuessword;
//var getDashes = new DrawDashesAndLetters(lengthOfWord, letterIndex, userLetterGuess, letterIsRight).ReturnDashesAndLetters();



//må loope hele dette viewet på nytt hver gang man har gjettet en bokstav for å tegne opp på nytt

while (true)
{
    Console.WriteLine(guessWord); //se selv i "viewet" hvilket ord som er valgt
    Console.WriteLine("You got a word with {0} letters in it. ", lengthOfWord);
    var getDashes = new DrawDashesAndLetters(lengthOfWord, letterIndex, userLetterGuess, letterIsRight).ReturnDashesAndLetters();
    for (int i = 0; i < getDashes.Count; i++)
    {
            Console.Write(getDashes[i] + " ");    
    }
    Console.WriteLine();

    Console.WriteLine("Type a letter to guess");
    userLetterGuess = Console.ReadLine();
    //getDashes.LetterGuess = userLetterGuess;
    
   checkForLetter = new CheckIfLetterExistsInWord(userLetterGuess, guessWord);
   letterIndex = checkForLetter._positionOfLetter;

   // Console.WriteLine(checkForLetter.LookForLetter());
}



