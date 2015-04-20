namespace Mixit2015FruitShop.Test.Panier
{
    using System.Collections.Generic;
    using System.Linq;
    using Fruits;

    public abstract class PanierBase
    {
        private const int MontantReduction5Fruits = 200;

        protected PanierBase()
        {
            Fruits = new List<IFruit>();
        }

        protected List<IFruit> Fruits { get; private set; }
        
        public void Add<TFruit>(IEnumerable<IFruit> fruits)
            where TFruit : IFruit
        {
            Fruits.AddRange(fruits.OfType<TFruit>().Cast<IFruit>());
        }

        public virtual int GetPrix()
        {
            return Fruits.Sum(f => f.PrixUnitaire);
        }

        public static int CalculateReduction5Fruits(IEnumerable<IFruit> fruits)
        {
            return fruits.Count() / 5 * MontantReduction5Fruits;
        }
    }
}
