using AbstactFactoryPattern.AbstractFactory;
using AbstactFactoryPattern.Implement;
using AbstactFactoryPattern.Interface;

namespace AbstactFactoryPattern.Factory
{
    public class FlasticFactory : FurnitureAbstractFactory
    {
        public override IChair CreateChair()
        {
            return new PlasticChair();
        }

        public override ITable CreateTable()
        {
            return new PlasticTable();
        }
    }
}
