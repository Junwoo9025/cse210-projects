/***
How did you apply encapsulation to your program's design?
    We will include encapsulation by having a list of words that are private.   
        then we would select the word

player
- The player guesses a letter in the puzzle.
- If the puzzle is solved the game is over.   

word list
- [DONE] Creation and holder of list
- [DONE] randomly choose a word from the list.

puzzle
- If the guess is correct, the letter is revealed.
- If the guess is incorrect, a line is cut on the player's parachute.
- If the player has no more parachute the game is over.

gamerunner
- Continue playing

***/

class Player
{
    // Just need to get the user's string input.
    public string Guess()
    {
        string choice;
        Console.Write("What is your guess: ");
        choice = Console.ReadLine();

        return choice;
    }
}

class Word
{
    // List<string> wordsList = new List<string>(); // This just makes a brand new empty list
        // this is the equivalent of "list = []"
    private List<string> listOfWords = new List<string> { "water", "earth", "fire", "air" };


    public string RandomWord()
    {
        Random random = new Random();
        int index = random.Next(listOfWords.Count());
        string randomWord = listOfWords[index];
        
        return randomWord;
    }

    
}

class GameRunner 
{
    
    static void Main(string[] args)
    {
        Player choice = new Player();
        string playerchoice = choice.Guess();
        Console.WriteLine($"The guess is: {playerchoice}");

        // WORKS: This just tests if I'm able to get the random word from the class.
        /***
        Word word = new Word();
        string randomWord = word.RandomWord();
        Console.WriteLine($"The word is: {randomWord}");
        ***/

    }

}

