using DecoratorPattern.Decorator;
using DecoratorPattern.Implement;
using System;

namespace DecoratorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var ourMilkTea = new WhiteBubble(new Bubble(new MilkTea()));
            Console.WriteLine(ourMilkTea.Cost().ToString());
            Console.ReadKey();
        }
    }
}
