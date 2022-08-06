using System;
using System.Collections.Generic;
using System.IO;

class Solution
{
    static void Main(String[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int x = 0;
        for (int i = 0; i < n; i++)
        {
            String st = Console.ReadLine();
            if (st[1] == '+')
            {
                x++;
            }
            else
            {
                x--;
            }
        }
        Console.WriteLine(x);
    }
}