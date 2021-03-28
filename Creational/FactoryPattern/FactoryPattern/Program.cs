using FactoryPattern.Factory;
using FactoryPattern.Interface;
using System;
using static FactoryPattern.Common.Common;

namespace FactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            IBank bank = BankFactory.GetBank(BankType.TPBANK);
            if (bank != null)
            {
                bank.GetName();
            }
            else
            {
                Console.WriteLine("Null");
            }
            Console.Read();
        }
    }
}
