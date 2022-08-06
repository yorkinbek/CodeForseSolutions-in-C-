using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boy_or_Girls
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            var inputCounting = input.Distinct().Count();

            if (inputCounting % 2 == 0)
            {
                Console.WriteLine("CHAT WITH HER!");

            }
            else
            {
                Console.WriteLine("IGNORE HIM!");
            }
        }
    }
}
