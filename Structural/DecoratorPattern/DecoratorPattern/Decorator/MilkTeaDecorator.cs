using DecoratorPattern.Interface;

namespace DecoratorPattern.Decorator
{
    public abstract class MilkTeaDecorator : IMilkTea
    {
        private IMilkTea _milkTea;
        protected MilkTeaDecorator(IMilkTea milkTea)
        {
            this._milkTea = milkTea;
        }
        public virtual double Cost()
        {
            return _milkTea.Cost();
        }
    }
}
