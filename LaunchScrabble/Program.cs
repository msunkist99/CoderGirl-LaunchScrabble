using System;

namespace LaunchScrabble
{
    class Program
    {
        static void Main(string[] args)
        {
            // prompt the user to enter their Scrabble words deliminated by a comma
            Console.WriteLine("Enter your Scrabble words - delimited by a comma.");
            string inputWords = Console.ReadLine();

            // create a string array of the user's words
            string[] words = inputWords.Split(',');

            // calculate the Scrabble score of the user's words
            int score = CalculateScrabbleScore(words);

            // display the Scrabble score
            Console.WriteLine($"Your Scrabble score is {score}");
            Console.ReadLine();
        }

        /// <summary>
        /// Calculates the score of comma delimeted Scrabble words
        /// </summary>
        /// <param name="words"></param>
        /// <returns>score</returns>
        private static int CalculateScrabbleScore(string[] words)
        {
            int score = 0;

            for (int i = 0; i < words.Length; i++)
            {
                words[i] = words[i].Trim();
                if (words[i].Length > 0)
                {
                    if ((GetCharacter(words[i], 0, 1) == "q") && (GetCharacter(words[i], 1, 1) == "u"))
                    {
                        score += 10;
                    }
                    else if ((GetCharacter(words[i], 0, 1) == "q") && (GetCharacter(words[i], 1, 1) != "u"))
                    {
                        Console.WriteLine($"Sorry - you entered an obviously incorrect word ---- {words[i]}");
                        score = 0;
                        return score;
                    }
                    else
                    {
                        score += 1;
                    }
                }
            }
            return score;
        }

        /// <summary>
        /// returns substring of characters
        /// this is really not needed - just as easy to use the SubString method directly
        /// </summary>
        /// <param name="word"></param>
        /// <param name="start"></param>
        /// <param name="length"></param>
        /// <returns>characterString</returns>
        private static string GetCharacter(string word, int start, int length)
        {
            string characterString = word.Substring(start, length);

            return characterString;
        }
    }
}


