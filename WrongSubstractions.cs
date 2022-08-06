using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wrong_Substractions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();

            for (int i = 0; i < input[1]; i++)
            {
                int result = input[0] % 10;

                if (result == 0)
                {
                    input[0] /= 10;
                }
                else
                {
                    input[0] -= 1;
                }
            }
            Console.WriteLine(input[0]);    
            Console.ReadLine();
        }
    }
}
