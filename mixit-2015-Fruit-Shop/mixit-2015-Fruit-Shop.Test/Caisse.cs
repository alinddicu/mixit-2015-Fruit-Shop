namespace Mixit2015FruitShop.Test
{
    using System.Collections.Generic;
    using System.Linq;

    public class Caisse
    {
        private readonly IList<IFruit> _fruits = new List<IFruit>();

        public void Enregistrer(IFruit fruit)
        {
            _fruits.Add(fruit);
        }

        public int GetPrix()
        {
            var prixPommes = Pomme.CalculatePrixPanier(_fruits);
            var prixCerises = Cerise.CalculatePrixPanier(_fruits);
            var prixBananes = Banane.CalculatePrixPanier(_fruits);

            return prixPommes + prixCerises + prixBananes;
        }
    }
}
