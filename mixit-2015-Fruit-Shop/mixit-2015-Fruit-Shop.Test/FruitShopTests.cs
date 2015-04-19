namespace Mixit2015FruitShop.Test
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using NFluent;

    [TestClass]
    public class FruitShopTests
    {
        private static FruitFactory Fruitfactory = new FruitFactory();

        [TestMethod]
        /*         * 
         * > Cerises -> 75 
         * > Pommes -> 175 
         * > Cerises -> 250 
         * > Bananes -> 400 
         * > Pommes -> 500
         */
        public void GivenIteration1WhenGetPrixThenReturn500()
        {
            var caisse = new Caisse();

            caisse.Enregistrer(Fruitfactory.Create("Cerises"));
            caisse.Enregistrer(Fruitfactory.Create("Pommes"));
            caisse.Enregistrer(Fruitfactory.Create("Cerises"));
            caisse.Enregistrer(Fruitfactory.Create("Bananes"));
            caisse.Enregistrer(Fruitfactory.Create("Pommes"));

            Check.That(caisse.GetPrix()).IsEqualTo(500);
        }
    }
}
