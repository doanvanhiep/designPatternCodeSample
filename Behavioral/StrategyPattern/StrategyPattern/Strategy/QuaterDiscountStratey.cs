using StrategyPattern.Interface;

namespace StrategyPattern.Strategy
{
    public class QuaterDiscountStratey : IPromoteStrategy
    {
        public double DoDiscount(double price)
        {
            return price * 0.75;
        }
    }
}
