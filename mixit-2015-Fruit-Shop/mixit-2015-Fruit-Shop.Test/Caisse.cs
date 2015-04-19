namespace Mixit2015FruitShop.Test
{
    using System.Collections.Generic;

    public class Caisse
    {
        private readonly List<IFruit> _fruits = new List<IFruit>();
        
        public void Enregistrer(IEnumerable< IFruit> fruits)
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

            return prixPommes + prixApples + prixMele + prixCerises + prixBananes;
        }
    }
}
