/***
How did you apply encapsulation to your program's design?
    We will include encapsulation by having a list of words that are private.   
        then we would select the word

player
- [DONE] The player guesses a letter in the puzzle.
  

word list
- [DONE] Creation and holder of list
- [DONE] randomly choose a word from the list.
- Next step is to create the dashed lines based on the random word chosen.
    EX: air == _ _ _

puzzle
- (guessCheck) If the guess is correct, the letter is revealed.
- (guessCheck) If the guess is incorrect, a line is cut on the player's parachute.
    - To think about: The random word needs to be pulled once. We need to store it.
- If the player has no more parachute the game is over.
- If the puzzle is solved the game is over. 

gamerunner
- Continue playing

***/

class Player
{
    // Just need to get the user's string input.
    public string Guess()
    {
        string choice;
        choice = Console.ReadLine();

        return choice;
    }
}

class Word
{
    // List<string> wordsList = new List<string>(); // This just makes a brand new empty list
        // this is the equivalent of "list = []"
    private List<string> listOfWords = new List<string> { "water", "earth", "fire", "air" };

    private string word = "";

    // this void is the setter
    public void SetRandomWord()
    {
        Random random = new Random();
        int index = random.Next(listOfWords.Count());
        string randomWord = listOfWords[index];
        // This is setting the randomly chosen word from the list 
        word = randomWord;
        
        // With a getter and setter. You don't need to return anything.
        //return randomWord;
    }

    // this is the getter
    public string RandomWord()
    {
        // this is calling word from the private string
        return word;
    }
    
}


class Puzzle 
{
    // What's inside is going to be the 
    public guessCheck()
    {

    }

}


class GameRunner 
{
    
    static void Main(string[] args)
    {

        Console.Write("What is your guess: ");
        Player choice = new Player();
        string playerchoice = choice.Guess();
        Console.WriteLine($"The guess is: {playerchoice}");



        // WORKS: This just tests if I'm able to get the random word from the class.
        //***
        Word word = new Word();
        // The reason to call SetRandomWord so that it can access that list. It is just a void and doesn't return anything.
        word.SetRandomWord();
        string randomWord = word.RandomWord();
        Console.WriteLine($"The word is: {randomWord}");
        //***/

    }

}


















    /***

    public string RandomWord()
    {
        Random random = new Random();
        int index = random.Next(listOfWords.Count());
        string randomWord = listOfWords[index];
        word = randomWord;
        
        // With a getter and setter. You don't need to return anything.
        //return randomWord;
    }

    ***/

