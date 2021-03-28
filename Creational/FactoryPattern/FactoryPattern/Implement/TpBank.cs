using FactoryPattern.Interface;
using System;

namespace FactoryPattern.Implement
{
    public class TpBank : IBank
    {
        public void GetName()
        {
            Console.WriteLine("TpBank");
        }
    }
}
