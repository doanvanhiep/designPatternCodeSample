using AbstactFactoryPattern.Interface;
using System;

namespace AbstactFactoryPattern.Implement
{
    public class WoodChair : IChair
    {
        public void create()
        {
            Console.WriteLine("Create wood chair");
        }
    }
}
