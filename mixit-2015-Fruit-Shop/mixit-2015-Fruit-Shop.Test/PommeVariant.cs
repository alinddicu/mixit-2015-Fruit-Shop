namespace Mixit2015FruitShop.Test
{
    using System.Collections.Generic;
    using System.Linq;

    public abstract class PommeVariant : Fruit
    {
        private const int MontantReduction4Pommes = 100;

        public static int CalculateReduction4Pommes(IEnumerable<Fruit> fruits)
        {
            return fruits.OfType<PommeVariant>().Count() / 5 * MontantReduction4Pommes;
        }
    }
}
