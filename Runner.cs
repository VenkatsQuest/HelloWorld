﻿using System;
namespace HelloWorld
{
    public class Runner
    {
        public Runner()
        {
        }
        public void Run()
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("This is Line2!");
            Console.WriteLine("This is Line3!");
            Console.WriteLine("Greeting from User1!");
            Console.WriteLine("Greeting from User1 HAS MADE THIS CHANGE!");

            Calculator oCalculator = new Calculator();
            int sum = oCalculator.Add(5, 7);
            Console.WriteLine(sum);
            Console.WriteLine($"The Difference between 5 and 7 is {oCalculator.Subtract(5, 7)}");

        }
    }
}
