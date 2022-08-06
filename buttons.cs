using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace buttons
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            int factorial = 1;
            
            for (int i = 1; i <= input; i++)
            {
                 factorial = (factorial * i);
            }
            Console.WriteLine(factorial + 1);
            Console.ReadLine();
        }
    }
}
