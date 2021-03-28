using DecoratorPattern.Interface;

namespace DecoratorPattern.Decorator
{
    public class FruitPudding : MilkTeaDecorator
    {
        public FruitPudding(IMilkTea milkTea) : base(milkTea)
        {

        }
        public override double Cost()
        {
            return 3 + base.Cost();
        }
    }
}
