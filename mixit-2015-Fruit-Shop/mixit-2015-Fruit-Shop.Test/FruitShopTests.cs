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
        [Ignore]
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

        [TestMethod]
        /*         
         * Les articles doivent être séparés par des virgules 
         * Même prix & réductions que pour l’itération
         * 
         * > Pommes, Cerises, Bananes 
         * -> 325 
         * > Pommes 
         * -> 425
         * 
         */
        public void GivenIteration3WhenGetPrixThenReturn425()
        {
            var caisse = new Caisse();

            caisse.Enregistrer(Fruitfactory.Create("Pommes, Cerises, Bananes"));
            caisse.Enregistrer(Fruitfactory.Create("Pommes"));

            Check.That(caisse.GetPrix()).IsEqualTo(425);
        }

        [TestMethod]
        /*         
         * La réduction pour les cerises passe à 30 centimes. 
         * Un lot de bananes acheté, le second est offert. 
         * 
         * > Cerises 
         * -> 75 
         * > Pommes 
         * -> 175 
         * > Cerises 
         * -> 220 
         * > Bananes 
         * -> 370 
         * > Pommes 
         * -> 470 
         * > Bananes 
         * -> 470 
         * > Cerises 
         * -> 545
         */
        public void GivenIteration4WhenGetPrixThenReturn545()
        {
            var caisse = new Caisse();

            caisse.Enregistrer(Fruitfactory.Create("Cerises"));
            caisse.Enregistrer(Fruitfactory.Create("Pommes"));
            caisse.Enregistrer(Fruitfactory.Create("Cerises"));
            caisse.Enregistrer(Fruitfactory.Create("Bananes"));
            caisse.Enregistrer(Fruitfactory.Create("Pommes"));
            caisse.Enregistrer(Fruitfactory.Create("Bananes"));
            caisse.Enregistrer(Fruitfactory.Create("Cerises"));

            Check.That(caisse.GetPrix()).IsEqualTo(545);
        }
    }
}
