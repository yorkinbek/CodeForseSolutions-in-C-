using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elephant
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());

            int result = input / 5;
            int remainder = input % 5;

            if (remainder == 0)
            {
                Console.WriteLine(result);
            }

            else if (remainder > 0)
            {
                Console.Write(result + 1);
            }
        }
    }
}
