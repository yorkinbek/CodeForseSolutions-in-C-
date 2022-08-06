using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solder_and_Banana
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int k = input[0];
            int n = input[1];
            int W = input[2];
            int result = 0;
            int lent = 0;
            int cost;
          
            for (int i = 1; i <= W; i++)
            {
                cost = k * i;
                result = cost + result;
                lent = result - n;
            }
            if (lent <= 0)
            {
                Console.WriteLine(0);
            }
            else
            {
                Console.WriteLine(lent);
            }
            
            Console.ReadLine();
        }
    }
}
