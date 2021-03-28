using AbstactFactoryPattern.Interface;

namespace AbstactFactoryPattern.AbstractFactory
{
    public abstract class FurnitureAbstractFactory
    {
        public abstract IChair CreateChair();

        public abstract ITable CreateTable();
    }
}
