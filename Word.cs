using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Word
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int countUpperCase = 0;
            int countLowerCase = 0; 
            for (int i = 0; i < input.Length; i++)
            {
                if (char.IsUpper(input[i]))
                {
                    countUpperCase++;
                }

                if (char.IsLower(input[i]))
                {
                    countLowerCase++;
                }
            }

            if (countUpperCase > countLowerCase)
            {
                Console.WriteLine(input.ToUpper());
            }
            else
            {
                Console.WriteLine(input.ToLower());
            }
            Console.ReadLine();
        }
    }
}
