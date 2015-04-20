namespace Mixit2015FruitShop.Test.Fruits
{
    public class Cerise : IFruit
    {
        public const int PrixPerUnit = 75;
        public const int MontantReductionPar2 = 20;

        public int PrixUnitaire
        {
            get { return PrixPerUnit; }
        }
    }
}
