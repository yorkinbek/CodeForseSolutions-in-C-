using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Big_brother_and_bear
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();

            int wieghtOf1 = input[0];
            int wieghtOf2 = input[1];
            int count = 0;
            if (wieghtOf1 < wieghtOf2)
            {
                do
                {
                    wieghtOf1 *= 3;
                    wieghtOf2 *= 2;
                    count++;
                }
                while (wieghtOf1 <= wieghtOf2);
            }
            else if (wieghtOf1 == wieghtOf2)
            {
                count++;
            }
            Console.WriteLine(count);
            Console.ReadLine();

        }
    }
}
