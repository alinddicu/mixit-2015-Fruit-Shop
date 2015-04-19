namespace Mixit2015FruitShop.Test
{
    public class Cerise : IFruit
    {
        private const int PrixUnitaire = 75;

        public int GetPrix()
        {
            return PrixUnitaire;
        }
    }
}
