using System;
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
            Console.WriteLine("Greeting from User2!");

            Calculator oCalculator = new Calculator();
            int sum = oCalculator.Add(5, 7);
            Console.WriteLine(sum);

        }
    }
}
