using FactoryPattern.Implement;
using FactoryPattern.Interface;
using static FactoryPattern.Common.Common;

namespace FactoryPattern.Factory
{
    public class BankFactory
    {
        public static IBank GetBank(BankType bankType)
        {
            switch (bankType)
            {
                case BankType.TPBANK:
                    return new TpBank();

                case BankType.VIETCOMBANK:
                    return new VietcomBank();

                default:
                    return null;
            }
        }
    }
}
