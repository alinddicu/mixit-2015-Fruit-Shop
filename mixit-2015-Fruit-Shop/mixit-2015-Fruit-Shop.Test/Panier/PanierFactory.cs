namespace Mixit2015FruitShop.Test.Panier
{
    using System.Collections.Generic;
    using System.Linq;
    using Fruits;

    public class PanierFactory
    {
        public IEnumerable<PanierBase> Create(ICollection<IFruit> fruits)
        {
            var applesPanier = new ApplesPanier();
            applesPanier.Add(fruits.OfType<Apples>());
            var bananePanier = new BananePanier();
            bananePanier.Add(fruits.OfType<Banane>());
            var cerisePanier = new CerisePanier();
            cerisePanier.Add(fruits.OfType<Cerise>());
            var melePanier = new MelePanier();
            melePanier.Add(fruits.OfType<Mele>());
            var pommePanier = new PommePanier();
            pommePanier.Add(fruits.OfType<Pomme>());
            
            yield return applesPanier;
            yield return bananePanier;
            yield return cerisePanier;
            yield return melePanier;
            yield return pommePanier;
        }
    }
}
