namespace Mixit2015FruitShop.Test
{
    using System.Collections.Generic;
    using System.Linq;

    public abstract class Fruit
    {
        private const int MontantReduction5Fruits = 200;

        public static int CalculateReduction5Fruits(IEnumerable<Fruit> fruits)
        {
            return fruits.Count() / 5 * MontantReduction5Fruits;
        }
    }
}
