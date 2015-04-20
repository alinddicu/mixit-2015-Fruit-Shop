namespace Mixit2015FruitShop.Test.Fruits
{
    public class Mele : PommeBase
    {
        public const int PrixPar2 = 100;
        
        public override int PrixUnitaire
        {
            get { return PrixPerUnit; }
        }
    }
}
