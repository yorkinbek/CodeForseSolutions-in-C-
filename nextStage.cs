using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NextStage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int nextRoundParticipantsCount = 0;

            int[] n  = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int numberOfParticipants = n[0];
            int proxodnoyPosition = n[1];
            
            int[] participantsWithScores = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int proxodnoyBall = participantsWithScores[proxodnoyPosition - 1];

            foreach (var score in participantsWithScores)
            {
                if (score >= proxodnoyBall && score > 0)
                    nextRoundParticipantsCount++;
            }

            Console.WriteLine(nextRoundParticipantsCount);
            //int[] myArray = new int[n[0]];
            //for (int i = 0; i < n[0]; i++)
            //{
            //    myArray[i] = k[i];
            //}
            //int elementLength = 0;
            //foreach (int score in myArray)
            //{
            //    if (score > n[1] && n[1] > 0 )
            //    {
            //        elementLength += 1;
            //    }
            //}
            //Console.WriteLine(elementLength);
            //Console.ReadLine();
        }
    }
}
