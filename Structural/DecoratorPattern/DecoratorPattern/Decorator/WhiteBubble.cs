using DecoratorPattern.Interface;

namespace DecoratorPattern.Decorator
{
    public class WhiteBubble : MilkTeaDecorator
    {
        public WhiteBubble(IMilkTea milkTea) : base(milkTea)
        {

        }
        public override double Cost()
        {
            return 4 + base.Cost();
        }
    }
}
