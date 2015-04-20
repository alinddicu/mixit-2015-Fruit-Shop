namespace Mixit2015FruitShop.Test.Fruits
{
    using System.Collections.Generic;
    using System.Linq;

    public abstract class PommeBase : IFruit
    {
        public const int PrixPerUnit = 100;

        private const int MontantReduction4Pommes = 100;

        public abstract int PrixUnitaire { get; }

        public static int CalculateReduction4Pommes(IEnumerable<IFruit> fruits)
        {
            return fruits.OfType<PommeBase>().Count() / 5 * MontantReduction4Pommes;
        }
    }
}
