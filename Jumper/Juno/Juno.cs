// puzzle
// - (guessCheck) If the guess is correct, the letter is revealed.
// - (guessCheck) If the guess is incorrect, a line is cut on the player's parachute.
//     - To think about: The random word needs to be pulled once. We need to store it.
// - If the player has no more parachute the game is over.
// - If the puzzle is solved the game is over. 
using System;
class Image
{
List<string> _jumperImage;

public Image()
{
    _jumperImage = new List<string>();
    CreateJumperImage();
}
 private void CreateJumperImage()
   {
      _jumperImage.Add(" ___ ");
      _jumperImage.Add("/___\\");
      _jumperImage.Add("\\   /");
      _jumperImage.Add(" \\ /");
      _jumperImage.Add("  0  ");
      _jumperImage.Add(" /|\\ ");
      _jumperImage.Add(" / \\ ");
   }

public void DisplayJumper(int wrongGuesses, int correctWord)
   {
      if (wrongGuesses == correctWord)
      {
         DeadJumper();
      }
      else
      {
         AliveJumper(wrongGuesses);
      }
   }


private void AliveJumper(int wrongGuesses)
   {
      for (int i = wrongGuesses; i < _jumperImage.Count; i++)
      {
         Console.WriteLine(_jumperImage[i]);
      }
      Console.Write("\n");
      Console.WriteLine("^^^^^^^");
   }


private void DeadJumper()
{
  Console.WriteLine(" x ");
  Console.WriteLine(" /|\ ");
  Console.WriteLine("/ \");
  Console.WriteLine("\n");
  Console.WriteLine("^^^^^^^");
  
}
 public void DisplayCurrentWord(string word)
   {
      Console.WriteLine(word);
   }

   /*
   summary: Gets the guessed letter from the user
   return: (string) returns a single letter
   */
   public string JumperGuess()
   {
      Console.Write("Guess a letter [a-z]: ");
      string guess = Console.ReadLine();
      return guess;
   }
}

