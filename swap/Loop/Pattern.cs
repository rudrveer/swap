﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Swap.Loop
{
    class Pattern
    {
        static void Main(string[] args)
        {
            for(int i = 5; i >= 1; i--)
            {
                for(int j = 5; j >= i; j--)
                {
                    Console.Write(" ");
                }
                for(int j = 1; j <=i; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
        }
    }
}
