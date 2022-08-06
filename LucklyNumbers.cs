using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LucklyNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            long input = long.Parse(Console.ReadLine());

            int count = 0;

            while(input != 0)
            {
                if (input % 10 == 4 || input % 10 == 7) { count++; }
                input /= 10;

               
            }
            if (count == 4 || count == 7)
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
