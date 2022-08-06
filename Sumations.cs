using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sumations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split('+').Select(int.Parse).ToArray();
            Array.Sort(input);
            for (int i = 0; i < input.Length; i++)
            {
                string inputWithPlus = "+" + input[i];
               
                inputWithPlus.Remove(inputWithPlus[0]);
           
                Console.Write(inputWithPlus);
            }
            
            Console.ReadLine();
        }
    }
}
