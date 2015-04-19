namespace Mixit2015FruitShop.Test
{
    using System.Collections.Generic;
    using System.Linq;

    public class Pomme : IFruit
    {
        private const int PrixUnitaire = 100;

        public int GetPrixUnitaire()
        {
            return PrixUnitaire;
        }

        public static int CalculatePrixPanier(IEnumerable<IFruit> fruits)
        {
            return fruits.OfType<Pomme>().Sum(f => f.GetPrixUnitaire());
        }
    }
}
