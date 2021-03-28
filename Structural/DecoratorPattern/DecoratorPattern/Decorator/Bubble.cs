using DecoratorPattern.Interface;

namespace DecoratorPattern.Decorator
{
    public class Bubble : MilkTeaDecorator
    {
        public Bubble(IMilkTea milkTea) : base(milkTea)
        {

        }
        public override double Cost()
        {
            return 1 + base.Cost();
        }
    }
}
