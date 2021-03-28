using System;

namespace FactoryPattern.Interface
{
    public class VietcomBank : IBank
    {
        public void GetName()
        {
            Console.WriteLine("VietComBank");
        }
    }
}
