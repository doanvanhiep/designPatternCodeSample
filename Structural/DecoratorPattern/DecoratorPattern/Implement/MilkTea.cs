using DecoratorPattern.Interface;

namespace DecoratorPattern.Implement
{
    public class MilkTea : IMilkTea
    {
        public double Cost()
        {
            return 5;
        }
    }
}
