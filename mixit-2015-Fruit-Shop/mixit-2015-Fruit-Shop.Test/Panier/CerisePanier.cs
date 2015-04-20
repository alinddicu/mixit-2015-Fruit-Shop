namespace Mixit2015FruitShop.Test.Panier
{
    using System.Collections.Generic;
    using Fruits;

    public class CerisePanier : PanierBase
    {
        public override int GetPrix()
        {
            var ceriseNumber = Fruits.Count;
            var prixNonReduit = ceriseNumber * Cerise.PrixU;
            var reductionPar2 = ceriseNumber / 2 * Cerise.MontantReductionPar2;

            return prixNonReduit - reductionPar2;
        }
    }
}
