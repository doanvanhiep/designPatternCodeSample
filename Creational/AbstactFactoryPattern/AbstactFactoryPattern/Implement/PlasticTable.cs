using AbstactFactoryPattern.Interface;
using System;
namespace AbstactFactoryPattern.Implement
{
    public class PlasticTable : ITable
    {
        public void create()
        {
            Console.WriteLine("Create plastic table");
        }
    }
}
