namespace Mixit2015FruitShop.Test.Fruits
{
    public class Banane : IFruit
    {
        public const int PrixPerUnit = 150;
        
        public int PrixUnitaire
        {
            get { return PrixPerUnit; }
        }
    }
}
