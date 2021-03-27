using AbstactFactoryPattern.Interface;
using System;

namespace AbstactFactoryPattern.Implement
{
    public class WoodTable : ITable
    {
        public void create()
        {
            Console.WriteLine("Create wood table");
        }
    }
}
