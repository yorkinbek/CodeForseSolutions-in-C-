using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anton_and_Danik
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());

            string words = Console.ReadLine();

            int countA = 0;
            int countD = 0;
            for (int i = 0; i < input; i++)
            {
                if (words[i] == 'A')
                {
                    countA++;
                    
                }
                if (words[i] == 'D')
                {
                    countD++;
                }
            }

            if (countA > countD)
            {
                Console.WriteLine("Anton");
            }

            else if(countD > countA)
            {
                Console.WriteLine("Danik");
            }
            else
            {
                Console.WriteLine("Friendship");
            }
            Console.ReadLine();
        }
    }
}
