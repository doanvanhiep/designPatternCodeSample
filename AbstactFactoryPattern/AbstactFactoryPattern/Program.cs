using AbstactFactoryPattern.AbstractFactory;
using AbstactFactoryPattern.Interface;
using static AbstactFactoryPattern.Common.Common;

namespace AbstactFactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            FurnitureAbstractFactory factory = FurnitureFactory.GetFactory(MaterialType.WOOD);

            IChair chair = factory.CreateChair();
            chair.create(); // Create plastic chair

            ITable table = factory.CreateTable();
            table.create(); // Create plastic table
        }
    }
}
