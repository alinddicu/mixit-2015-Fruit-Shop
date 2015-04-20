namespace Mixit2015FruitShop.Test.Fruits
{
    using System.Collections.Generic;
    using System.Linq;

    public class Pomme : PommeBase
    {
        public static int CalculatePrixPanier(IEnumerable<IFruit> fruits)
        {
            return fruits.OfType<Pomme>().Sum(f => f.PrixUnitaire);
        }

        public override int PrixUnitaire
        {
            get { return 100; }
        }
    }
}
