namespace Mixit2015FruitShop.Test
{
    using System.Collections.Generic;
    using System.Linq;
    using Fruits;
    using Panier;

    public class Caisse
    {
        private readonly List<IFruit> _fruits = new List<IFruit>();

        public void Enregistrer(IEnumerable<IFruit> fruits)
        {
            _fruits.AddRange(fruits);
        }

        public int GetPrix()
        {
            var paniers = new PanierFactory().Create(_fruits);
            var prixEntier = paniers.Sum(p => p.GetPrix());
            //var prixPommes = Pomme.CalculatePrixPanier(_fruits);
            //var prixApples = Apples.CalculatePrixPanier(_fruits);
            //var prixMele = Mele.CalculatePrixPanier(_fruits);
            //var prixCerises = Cerise.CalculatePrixPanier(_fruits);
            //var prixBananes = Banane.CalculatePrixPanier(_fruits);

            //var prixEntier = prixPommes + prixApples + prixMele + prixCerises + prixBananes;

            var reduction4Pommes = PommeBase.CalculateReduction4Pommes(_fruits);
            var reduction5Fruits = PanierBase.CalculateReduction5Fruits(_fruits);

            var reductions = reduction4Pommes + reduction5Fruits;

            return prixEntier - reductions;
        }
    }
}
