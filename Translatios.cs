using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Translations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input1 = Console.ReadLine();
            string input2 = Console.ReadLine();

            string c = "";
            for (int i = input2.Length - 1; i >= 0; i--)
            {
                c += input2[i];
            }

            if (input1 == c)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
           
            Console.ReadLine();
        }
    }
}
