namespace Mixit2015FruitShop.Test
{
    using System.Collections.Generic;
    using System.Linq;

    public class Cerise : IFruit
    {
        private const int PrixUnitaire = 75;
        private const int MontantReductionPar2 = 20;

        public int GetPrixUnitaire()
        {
            return PrixUnitaire;
        }

        public static int CalculatePrixPanier(ICollection<IFruit> fruits)
        {
            var prixNonReduit = fruits.OfType<Cerise>().Sum(f => f.GetPrixUnitaire());
            var reductionPar2 = fruits.Count(f => f is Cerise) / 2 * MontantReductionPar2;

            return prixNonReduit - reductionPar2;
        }
    }
}
