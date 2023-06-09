﻿using System;
using System.Linq;
using System.Collections.Generic;

namespace ITP1_5_C
{
    class Program
    {
        static void Main()
        {
            while(true)
            {
                string[] Input = Console.ReadLine().Split(' ');

                int H = int.Parse(Input[0]);
                int W = int.Parse(Input[1]);

                if (H == 0 && W == 0) break;

                for (int a = 1; a <= H; a++)
                {
                    if (a == 1 || a % 2 == 1)
                    {
                        for (int b = 1; b < W; b++)
                        {
                            if(b == 1 || b % 2 != 0) Console.Write('#');
                            else Console.Write('.');
                        }
                        if (W % 2 == 0)
                        {
                            Console.WriteLine('.');
                        }
                        else
                        {
                            Console.WriteLine('#');
                        }
                    }

                    else
                    {
                        for (int c = 1; c < W; c++)
                        {
                            if(c == 1 || c % 2 != 0)Console.Write('.');
                            else Console.Write('#');
                        }
                        if (W % 2 == 0)
                        {
                            Console.WriteLine('#');
                        }
                        else
                        {
                            Console.WriteLine('.');
                        }
                    }
                }
                Console.WriteLine(' ');
            }
        }
    }
}