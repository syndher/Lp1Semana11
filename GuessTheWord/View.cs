using System;

namespace GuessTheWord
{
    
    public class View
    {
        
            public void GuessIt(string hint, string display)
            {
                Console.WriteLine("Guess the full word!");
                Console.WriteLine($"Hint: It's a {hint}.");
                Console.WriteLine($"Word: {new string(display)}");
            }

            public void Guess()
            {
                Console.Write("Your guess: ");
            }

            public void WrongGuess()
            {
                Console.WriteLine("Incorrect. Try again.");
            }

            public void CorrectGuess(string chosenWord)
            {
                Console.WriteLine("Correct! Well done!");
                Console.WriteLine($"The word was \"{chosenWord}\".");
            }
    }
}