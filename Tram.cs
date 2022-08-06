using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            int entering = 0;
            int exiting = 0;
            for (int i = 0; i < input; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    int[] numbersStop = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                    numbersStop[0] = entering;
                    numbersStop[1] = exiting;
                }
               
            }


        }
    }
}
