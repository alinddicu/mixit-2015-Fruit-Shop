namespace Mixit2015FruitShop.Test
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using NFluent;

    [TestClass]
    public class FruitShopTests
    {
        private static readonly FruitFactory Fruitfactory = new FruitFactory();

        [TestMethod]
        [Ignore]
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

        [TestMethod]
        /*         
         * Pour 2 lots de cerises achetés on applique 20 centimes de réduction
         * 
         * > Cerises 
         * -> 75 
         * > Pommes 
         * -> 175 
         * > Cerises 
         * -> 230 
         * > Bananes 
         * -> 380 
         * > Cerises 
         * -> 455 
         * > Cerises 
         * -> 510 
         * > Pommes 
         * -> 610
         */
        public void GivenIteration2WhenGetPrixThenReturn610()
        {
            var caisse = new Caisse();

            caisse.Enregistrer(Fruitfactory.Create("Cerises"));
            caisse.Enregistrer(Fruitfactory.Create("Pommes"));
            caisse.Enregistrer(Fruitfactory.Create("Cerises"));
            caisse.Enregistrer(Fruitfactory.Create("Bananes"));
            caisse.Enregistrer(Fruitfactory.Create("Cerises"));
            caisse.Enregistrer(Fruitfactory.Create("Cerises"));
            caisse.Enregistrer(Fruitfactory.Create("Pommes"));

            Check.That(caisse.GetPrix()).IsEqualTo(610);
        }
    }
}
