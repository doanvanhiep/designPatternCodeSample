using StrategyPattern.Interface;

namespace StrategyPattern.Strategy
{
    public class NoDiscountStratey : IPromoteStrategy
    {
        public double DoDiscount(double price)
        {
            return price;
        }
    }
}
