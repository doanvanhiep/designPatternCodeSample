using StrategyPattern.Interface;

namespace StrategyPattern.Strategy
{
    public class HalfDiscountStratey : IPromoteStrategy
    {
        public double DoDiscount(double price)
        {
            return price * 0.5;
        }
    }
}
