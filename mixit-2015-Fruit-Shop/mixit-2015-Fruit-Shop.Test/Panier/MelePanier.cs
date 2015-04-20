namespace Mixit2015FruitShop.Test.Panier
{
    using Fruits;

    public class MelePanier : PanierBase
    {
        public override int GetPrix()
        {
            var nbMele = Fruits.Count;
            var prixPar1 = (nbMele % 2) * Mele.PrixPerUnit;
            var prixPar3 = nbMele / 2 * Mele.PrixPar2;

            return prixPar1 + prixPar3;
        }
    }
}
