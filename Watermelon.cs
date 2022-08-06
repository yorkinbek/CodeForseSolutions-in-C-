

using System;

namespace Watermelon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var kilos = int.Parse(Console.ReadLine());

            if (kilos % 2 == 0 && kilos > 2)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }

            Console.ReadLine();
        }
    }
}
