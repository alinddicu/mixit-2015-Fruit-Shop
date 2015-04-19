namespace Mixit2015FruitShop.Test
{
    using System.Collections.Generic;
    using System.Linq;

    public class Mele : IFruit
    {
        private const int PrixUnitaire = Pomme.PrixUnitaire;
        private const int PrixPar2 = 150;

        public int GetPrixUnitaire()
        {
            return PrixUnitaire;
        }

        public static int CalculatePrixPanier(IEnumerable<IFruit> fruits)
        {
            var nbApples = fruits.Count(f => f is Mele);
            var prixPar1 = (nbApples % 2) * PrixUnitaire;
            var prixPar3 = nbApples / 2 * PrixPar2;

            return prixPar1 + prixPar3;
        }
    }
}
