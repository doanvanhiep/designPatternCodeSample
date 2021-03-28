using AbstactFactoryPattern.AbstractFactory;
using AbstactFactoryPattern.Implement;
using AbstactFactoryPattern.Interface;

namespace AbstactFactoryPattern.Factory
{
    public class WoodFactory : FurnitureAbstractFactory
    {
        public override IChair CreateChair()
        {
            return new WoodChair();
        }

        public override ITable CreateTable()
        {
            return new WoodTable();
        }
    }
}
