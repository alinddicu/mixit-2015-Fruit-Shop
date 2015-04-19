namespace Mixit2015FruitShop.Test
{
    using System.Collections.Generic;
    using System.Linq;

    public class Cerise : IFruit
    {
        private const int PrixUnitaire = 75;
        private const int MontantReductionPar2 = 20;
        
        public static int CalculatePrixPanier(ICollection<IFruit> fruits)
        {
            var ceriseNumber = fruits.Count(f => f is Cerise);
            var prixNonReduit = ceriseNumber * PrixUnitaire;
            var reductionPar2 = ceriseNumber / 2 * MontantReductionPar2;

            return prixNonReduit - reductionPar2;
        }
    }
}
