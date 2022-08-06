using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorldCapilation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string words = Console.ReadLine();

            Console.WriteLine(char.ToUpper(words[0]) + words.Substring(1));
            Console.ReadLine();
        }
    }
}
