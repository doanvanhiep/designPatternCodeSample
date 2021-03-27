using AbstactFactoryPattern.Factory;
using static AbstactFactoryPattern.Common.Common;

namespace AbstactFactoryPattern.AbstractFactory
{
    public class FurnitureFactory
    {
        // Returns a concrete factory object that is an instance of the
        // concrete factory class appropriate for the given architecture.
        public static FurnitureAbstractFactory GetFactory(MaterialType materialType)
        {
            switch (materialType)
            {
                case MaterialType.FLASTIC:
                    return new FlasticFactory();
                case MaterialType.WOOD:
                    return new WoodFactory();
                default:
                    return null;
            }
        }
    }
}
