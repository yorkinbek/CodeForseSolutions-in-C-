using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stones_and_color
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string colors = Console.ReadLine();
            int count = 0;

            for (int i = 0; i < colors.Length - 1; i++)
            {
                if (colors[i] == colors[i + 1])
                {
                    count++;
                }
            }
            Console.WriteLine(count);
            Console.ReadLine();
        }
    }
}
