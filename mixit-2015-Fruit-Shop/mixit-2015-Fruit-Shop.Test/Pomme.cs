namespace Mixit2015FruitShop.Test
{
    using System.Collections.Generic;
    using System.Linq;

    public class Pomme : PommeVariant
    {
        public const int PrixUnitaire = 100;

        public static int CalculatePrixPanier(IEnumerable<Fruit> fruits)
        {
            return fruits.OfType<Pomme>().Sum(f => PrixUnitaire);
        }
    }
}
