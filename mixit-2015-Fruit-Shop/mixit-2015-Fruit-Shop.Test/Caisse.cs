namespace Mixit2015FruitShop.Test
{
    using System.Collections.Generic;

    public class Caisse
    {
        private readonly List<Fruit> _fruits = new List<Fruit>();

        public void Enregistrer(IEnumerable<Fruit> fruits)
        {
            _fruits.AddRange(fruits);
        }

        public int GetPrix()
        {
            var prixPommes = Pomme.CalculatePrixPanier(_fruits);
            var prixApples = Apples.CalculatePrixPanier(_fruits);
            var prixMele = Mele.CalculatePrixPanier(_fruits);
            var prixCerises = Cerise.CalculatePrixPanier(_fruits);
            var prixBananes = Banane.CalculatePrixPanier(_fruits);

            var prixEntier = prixPommes + prixApples + prixMele + prixCerises + prixBananes;

            var reduction4Pommes = PommeVariant.CalculateReduction4Pommes(_fruits);
            var reduction5Fruits = Fruit.CalculateReduction5Fruits(_fruits);

            var reductions = reduction4Pommes + reduction5Fruits;

            return prixEntier - reductions;
        }
    }
}
