﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatePart1App
{
    internal class User
    {
       Program program = new Program();
        public void Calculate(Func<int, int,int> mydel)
        {
            int num1, num2;
            Console.WriteLine("Please enter the first number");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the second number");
            num2 = Convert.ToInt32(Console.ReadLine());
            int result = mydel(num1, num2);
            Console.WriteLine($"The sum of {num1} and {num2} is {result}");
        }
    }
}
