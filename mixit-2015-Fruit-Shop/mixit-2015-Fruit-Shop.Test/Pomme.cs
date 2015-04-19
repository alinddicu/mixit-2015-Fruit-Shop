namespace Mixit2015FruitShop.Test
{
    public class Pomme : IFruit
    {
        private const int PrixUnitaire = 100;

        public int GetPrix()
        {
            return PrixUnitaire;
        }
    }
}
