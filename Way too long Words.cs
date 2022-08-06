using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Way_too_long_Words
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var numbersOfWords = int.Parse(Console.ReadLine());
            for (int i = 0; i < numbersOfWords; i++)
            {
                var word = Console.ReadLine();

                if (word.Length <= 10)
                {
                    Console.WriteLine(word);
                }
                else
                {
                    var word1 = word[0];
                    var word2 = word[word.Length - 1];
                    var wordNumbers = word.Length - 2;
                    Console.WriteLine($"{word1}{wordNumbers}{word2}");
                }
                Console.WriteLine();
            }
        }
    }
}
