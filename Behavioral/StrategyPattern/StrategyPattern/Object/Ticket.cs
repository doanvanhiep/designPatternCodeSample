using StrategyPattern.Interface;
using System;

namespace StrategyPattern.Object
{
    public class Ticket
    {
        public IPromoteStrategy PromoteStrategy { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public Ticket()
        {

        }
        public Ticket(IPromoteStrategy promoteStrategy)
        {
            PromoteStrategy = promoteStrategy;
        }
        public double GetPromotePrice()
        {
            return PromoteStrategy.DoDiscount(Price);
        }
        public void Display()
        {
            Console.WriteLine(string.Format("Name: {0} - Price: {1} - Price Promote: {2}", Name, Price.ToString(), GetPromotePrice()));
        }
    }
}
