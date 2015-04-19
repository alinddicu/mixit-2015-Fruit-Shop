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

        public static int CalculatePrixPanier(ICollection<IFruit> fruits)
        {
            var prixEntier = fruits.OfType<Banane>().Sum(f => f.GetPrixUnitaire());
            var reduction = fruits.Count(f => f is Banane) / 2 * PrixUnitaire;

            return prixEntier - reduction;
        }
    }
}
