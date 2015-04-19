namespace Mixit2015FruitShop.Test
{
    public class Banane : IFruit
    {
        private const int PrixUnitaire = 150;

        public int GetPrix()
        {
            return PrixUnitaire;
        }
    }
}
