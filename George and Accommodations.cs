using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace George_and_Accommodation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());

            int roomsCapacity;
            int roomsResidence;
            int n = 0;
            for (int i = 0; i < input; i++)
            {
                int[] rooms = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

                roomsCapacity = rooms[1];
                roomsResidence = rooms[0];

                if (roomsCapacity - roomsResidence >= 2)
                {
                    n++;
                }
            }
            Console.WriteLine(n);
            Console.ReadLine();
        }
    }
}
