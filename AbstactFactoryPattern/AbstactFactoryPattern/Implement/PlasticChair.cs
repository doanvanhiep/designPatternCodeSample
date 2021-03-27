using AbstactFactoryPattern.Interface;
using System;

namespace AbstactFactoryPattern.Implement
{
    public class PlasticChair : IChair
    {
        public void create()
        {
            Console.WriteLine("Create plastic chair");
        }
    }
}
