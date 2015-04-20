namespace Mixit2015FruitShop.Test.Panier
{
    using Fruits;

    public class BananePanier : PanierBase
    {
        public override int GetPrix()
        {
            var bananeNumber = Fruits.Count;
            var prixEntier = bananeNumber * Banane.PrixPerUnit;
            var reduction = bananeNumber / 2 * Banane.PrixPerUnit;

            return prixEntier - reduction;
        }
    }
}
