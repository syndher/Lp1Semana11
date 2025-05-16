using System;
using System.Collections.Generic;

namespace GuessTheWord
{
    public class Controller
    {
        private readonly View view;
        private readonly Model model;

        public Controller(View view, Model model)
        {
            view = new View();
            model = new Model();
        }

        public void Run()
            {
                // Select a random word
                Random rand = new Random();
                List<string> words = new List<string>(model.wordsWithHints.Keys);
                string chosenWord = words[rand.Next(words.Count)];
                string hint = model.wordsWithHints[chosenWord];

                // Determine revealed letter positions (up to 50% of the length)
                int length = chosenWord.Length;
                int numToReveal = Math.Max(1, (int)Math.Floor(length * 0.4)); // at least 1 letter
                char[] display = new string('_', length).ToCharArray();

                // Use hash code of the word for consistent seeding
                int seed = chosenWord.GetHashCode();
                Random maskRand = new Random(seed);

                HashSet<int> revealedIndices = new HashSet<int>();

                while (revealedIndices.Count < numToReveal)
                {
                    int index = maskRand.Next(length);
                    revealedIndices.Add(index);
                }

                foreach (int i in revealedIndices)
                {
                    display[i] = chosenWord[i];
                }

                view.GuessIt(hint, Convert.ToString(display));

                string guess;
                do
                {
                    view.Guess();
                    guess = Console.ReadLine().Trim().ToLower();

                    if (guess != chosenWord)
                        view.WrongGuess();
                } while (guess != chosenWord);

                view.CorrectGuess(chosenWord);
            }
    }
}