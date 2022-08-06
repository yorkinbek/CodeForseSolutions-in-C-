using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace present
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] line = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            for (int i = 1; i <= n; i++)
            {
                if (line[i] == n-i)
                {
                    Console.WriteLine(line[i] + " ");
                };
            }

            Console.ReadLine();

        }
    }
}
