using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Team
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] myArray = new int[n];
            int x = 0;

            for (int i = 0; i < n; i++)
            {
                int[] input1 = Console.ReadLine().Split().Select(int.Parse).ToArray();
                for(int j = 0; j < 3; j++)
                {
                    myArray[i] += input1[j];
                }
                if (myArray[i] > 1)
                {
                    x++;
                }
              
            }
            Console.WriteLine(x);
            Console.ReadLine();
        }
    }
}
