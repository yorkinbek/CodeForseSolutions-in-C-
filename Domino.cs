using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domino
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] linesOfSequence = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int sequare2 = linesOfSequence[0] * linesOfSequence[1];
            Console.WriteLine(sequare2 / 2);
            Console.ReadLine();
        }
    }
}
