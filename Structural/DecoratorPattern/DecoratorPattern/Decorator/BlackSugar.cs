using DecoratorPattern.Interface;

namespace DecoratorPattern.Decorator
{
    public class BlackSugar : MilkTeaDecorator
    {
        public BlackSugar(IMilkTea milkTea) : base(milkTea)
        {

        }
        public override double Cost()
        {
            return 2 + base.Cost();
        }
    }
}
