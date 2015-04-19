namespace Mixit2015FruitShop.Test
{
    using System.Collections.Generic;
    using System.Linq;

    public class Banane : IFruit
    {
        private const int PrixUnitaire = 150;

        public int GetPrixUnitaire()
        {
            return PrixUnitaire;
        }

        public static int CalculatePrixPanier(IEnumerable<IFruit> fruits)
        {
            return fruits.OfType<Banane>().Sum(f => f.GetPrixUnitaire());
        }
    }
}
