﻿using System;

namespace _06.NumberBetween100And200
{
    class NumberBetween100And200
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            if (number < 100)
            {
                Console.WriteLine("Less than 100");
            }
            else if (number > 200)
            {
                Console.WriteLine("Greater than 200");
            }
            else
            {
                Console.WriteLine("Between 100 and 200");
            }
        }
    }
}
