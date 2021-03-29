using StrategyPattern.Object;
using StrategyPattern.Strategy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var random = new Random();
            for (int i = 0; i < 5; i++)
            {
                var strategyIndex = random.Next(0, 3);
                var ticket = new Ticket();
                ticket.Name = "Ticket " + i;
                ticket.Price = 100;

                switch (strategyIndex)
                {
                    case 0:
                        ticket.PromoteStrategy=new NoDiscountStratey();
                        break;
                    case 1:
                        ticket.PromoteStrategy = new QuaterDiscountStratey();
                        break;
                    case 2:
                        ticket.PromoteStrategy = new HalfDiscountStratey();
                        break;
                }

                ticket.Display();
            }
            Console.ReadKey();
        }
    }
}
