namespace Mixit2015FruitShop.Test.Panier
{
    using Fruits;

    public class ApplesPanier : PanierBase
    {
        public override int GetPrix()
        {
            var nbApples = Fruits.Count;
            var prixPar1 = (nbApples % 3) * Apples.PrixPerUnit;
            var prixPar3 = nbApples / 3 * Apples.PrixPar3;

            return prixPar1 + prixPar3;
        }
    }
}
