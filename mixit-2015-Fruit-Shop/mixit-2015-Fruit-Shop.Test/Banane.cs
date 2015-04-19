namespace Mixit2015FruitShop.Test
{
    using System.Collections.Generic;
    using System.Linq;

    public class Banane : IFruit
    {
        private const int PrixUnitaire = 150;

        public static int CalculatePrixPanier(IEnumerable<IFruit> fruits)
        {
            var bananeNumber = fruits.Count(f => f is Banane);
            var prixEntier = bananeNumber * PrixUnitaire;
            var reduction =  bananeNumber/ 2 * PrixUnitaire;

            return prixEntier - reduction;
        }
    }
}
