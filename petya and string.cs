using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Petya_and_string
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var input1 = Console.ReadLine();
            var input2 = Console.ReadLine();    
            var input1ToLowerCase = input1.ToLower();
            var input2ToLowerCase = input2.ToLower();

            if (string.Compare(input1ToLowerCase, input2ToLowerCase) > 0)
            {
                Console.WriteLine("1");
            }
            else if(string.Compare(input1ToLowerCase, input2ToLowerCase) < 0)
            {
                Console.WriteLine("-1");
            }
            else if (string.Compare(input1ToLowerCase, input2ToLowerCase) == 0)
            {
                Console.WriteLine("0");
            }
            Console.ReadLine();
        }
    }
}
