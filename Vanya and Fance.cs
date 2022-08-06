using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vanya_and_Fance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] input1 = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int[] input2 = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int numberOfStudents = input1[0];

            int minOfHeight = input1[1];
            int blowMin = 0;
            int abowMin = 0;
            for (int i = 0; i < numberOfStudents; i++)
            {
                if (input2[i] > minOfHeight)
                {
                    abowMin += 2;
                }
                else
                {
                    blowMin += 1;
                }
            }
            Console.WriteLine(blowMin + abowMin);
            Console.ReadLine();
        }
    }
}
