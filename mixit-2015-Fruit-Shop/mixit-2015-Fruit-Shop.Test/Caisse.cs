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
            return _fruits.Sum(f => f.GetPrix());
        }
    }
}
