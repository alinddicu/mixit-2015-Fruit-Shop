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
        [Ignore]
        /*         
         * Les articles doivent être séparés par des virgules 
         * Même prix & réductions que pour l’itération
         * 
         * > Pommes, Cerises, Bananes 
         * -> 325 
         * > Pommes 
         * -> 425
         */
        public void GivenIteration3WhenGetPrixThenReturn425()
        {
            var caisse = new Caisse();

            caisse.Enregistrer(Fruitfactory.Create("Pommes, Cerises, Bananes"));
            caisse.Enregistrer(Fruitfactory.Create("Pommes"));

            Check.That(caisse.GetPrix()).IsEqualTo(425);
        }

        [TestMethod]
        [Ignore]
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

        [TestMethod]
        /*         
         * Support de la localisation 
         * La réduction pour les cerises repassent à 0,20 € 
         * On doit supporter les mots "Apples" et "Mele" pour "Pommes" 
         * 
         * > Cerises 
         * -> 75 
         * > Apples 
         * -> 175 
         * > Cerises 
         * -> 230 
         * > Bananes 
         * -> 380 
         * > Pommes 
         * -> 480 
         * > Mele 
         * -> 580
         */
        public void GivenIteration5WhenGetPrixThenReturn545()
        {
            var caisse = new Caisse();

            caisse.Enregistrer(Fruitfactory.Create("Cerises"));
            caisse.Enregistrer(Fruitfactory.Create("Apples"));
            caisse.Enregistrer(Fruitfactory.Create("Cerises"));
            caisse.Enregistrer(Fruitfactory.Create("Bananes"));
            caisse.Enregistrer(Fruitfactory.Create("Pommes"));
            caisse.Enregistrer(Fruitfactory.Create("Mele"));

            Check.That(caisse.GetPrix()).IsEqualTo(580);
        }

        [TestMethod]
        /*         
         * Support de la localisation par article 
         * Le support du CSV est pour la prochaine itération 
         * 3 lots de "Apples" valent 2 € 
         * 2 lots de "Mele" valent 1,50 € 
         * 
         * Tests 
         * 
         * > Mele 
         * -> 100 
         * > Apples 
         * -> 200 
         * > Apples 
         * -> 300 
         * > Pommes 
         * -> 400 
         * > Apples 
         * -> 400 
         * > Mele 
         * -> 450 
         * > Cerises 
         * -> 525 
         * > Cerises 
         * -> 580
         */
        public void GivenIteration6WhenGetPrixThenReturn545()
        {
            var caisse = new Caisse();

            caisse.Enregistrer(Fruitfactory.Create("Mele"));
            caisse.Enregistrer(Fruitfactory.Create("Apples"));
            caisse.Enregistrer(Fruitfactory.Create("Apples"));
            caisse.Enregistrer(Fruitfactory.Create("Pommes"));
            caisse.Enregistrer(Fruitfactory.Create("Apples"));
            caisse.Enregistrer(Fruitfactory.Create("Mele"));
            caisse.Enregistrer(Fruitfactory.Create("Cerises"));
            caisse.Enregistrer(Fruitfactory.Create("Cerises"));

            Check.That(caisse.GetPrix()).IsEqualTo(580);
        }
    }
}
