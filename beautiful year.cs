﻿
using System;

class Exercise11

{

    static void Main()

    {

        int y = Convert.ToInt32(Console.ReadLine());

        int a, b, c, d;

        while (true)

        {

            y = y + 1;

            a = y / 1000;

            b = y / 100 % 10;

            c = y / 10 % 10;

            d = y % 10;

            if (a != b && a != c && a != d && b != c && b != d && c != d)

            {

                break;

            }

        }

        Console.WriteLine(y);

    }

}
