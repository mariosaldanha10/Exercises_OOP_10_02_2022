using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Create a game like Hangman in which a player guesses letters to try to replicate a hidden
word. Store at least eight words in an array, and randomly select one to be the hidden word.
Initially, display the hidden word using asterisks to represent each letter. Allow the user to
guess letters to replace the asterisks in the hidden word until the user completes the entire
word. If the user guesses a letter that is not in the hidden word, display an appropriate
message. If the user guesses a letter that appears multiple times in the hidden word, make
sure that each correct letter is placed.*/

namespace Exercises_OOP_10_02_2022.Exercises
{
    public class Question3
    {
        public Question3()
        {
        }
        public void gaming()
        {
            Console.WriteLine("THIS IS QUESTION 3");

            Console.WriteLine("Welcome to the Guess Game");
            string[] hiddenWord = new string[10];
            hiddenWord[0] = "chocolate";
            hiddenWord[1] = "peach";
            hiddenWord[2] = "mouse";
            hiddenWord[3] = "car";
            hiddenWord[4] = "glasses";
            hiddenWord[5] = "store";
            hiddenWord[6] = "mobile";
            hiddenWord[7] = "shopping";
            hiddenWord[8] = "trip";
            hiddenWord[9] = "chair";
            Random randGen = new Random();
            var secretWords = randGen.Next(0, 9);
            string hiddenWords = hiddenWord[secretWords];
            char[] guess = new char[hiddenWord.Length];
            Console.Write("Please enter a letter: ");

            for (int p = 0; p < hiddenWord.Length; p++)
                guess[p] = '*';

            while (true)
            {
                char userGuess = char.Parse(Console.ReadLine());
                for (int j = 0; j < hiddenWord.Length; j++)
                {
                    if (userGuess == hiddenWords[j])
                        guess[j] = userGuess;
                }
                Console.WriteLine(guess);
            }
        }
    }            
}

