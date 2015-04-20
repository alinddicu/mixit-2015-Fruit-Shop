namespace Mixit2015FruitShop.Test.Panier
{
    using System.Collections.Generic;
    using Fruits;

    public class PanierFactory
    {
        public IEnumerable<PanierBase> Create(ICollection<IFruit> fruits)
        {
            var applesPanier = new ApplesPanier();
            applesPanier.Add<Apples>(fruits);
            var bananePanier = new BananePanier();
            bananePanier.Add<Banane>(fruits);
            var cerisePanier = new CerisePanier();
            cerisePanier.Add<Cerise>(fruits);
            var melePanier = new MelePanier();
            melePanier.Add<Mele>(fruits);
            var pommePanier = new PommePanier();
            pommePanier.Add<Pomme>(fruits);
            
            yield return applesPanier;
            yield return bananePanier;
            yield return cerisePanier;
            yield return melePanier;
            yield return pommePanier;
        }
    }
}
