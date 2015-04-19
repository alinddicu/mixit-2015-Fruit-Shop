namespace Mixit2015FruitShop.Test
{
    using System.Collections.Generic;
    using System.Linq;

    public class Cerise : Fruit
    {
        private const int PrixUnitaire = 75;
        private const int MontantReductionPar2 = 20;
        
        public static int CalculatePrixPanier(IEnumerable<Fruit> fruits)
        {
            var ceriseNumber = fruits.Count(f => f is Cerise);
            var prixNonReduit = ceriseNumber * PrixUnitaire;
            var reductionPar2 = ceriseNumber / 2 * MontantReductionPar2;

            return prixNonReduit - reductionPar2;
        }
    }
}
