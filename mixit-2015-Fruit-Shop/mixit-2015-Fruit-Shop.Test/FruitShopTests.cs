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
        /* 
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
        [Ignore]
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
        [Ignore]
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

        [TestMethod]
        [Ignore]
        /*         
         * On a déployé du nouveau Hardware, faut redeployer asap. 
         * Même deadline 
         * 
         * 3 lots de "Apples" valent 2 € 
         * 2 lots de "Mele" valent 1 € 
         * 
         * > Cerises, Apples 
         * -> 175 
         * > Cerises 
         * -> 230 
         * > Apples, Pommes, Bananes 
         * -> 580 
         * > Apples, Pommes 
         * -> 680 
         * > Mele 
         * -> 780 
         * > Pommes 
         * -> 880
         */
        public void GivenIteration6BisWhenGetPrixThenReturn680()
        {
            var caisse = new Caisse();

            caisse.Enregistrer(
                Fruitfactory.Create(
                "Mele, Apples, Apples, Pommes, Apples, Mele, Cerises, Cerises, Bananes"));
            
            Check.That(caisse.GetPrix()).IsEqualTo(680);
        }

        [TestMethod]
        /*
         * Créer les super réductions 
         * Support du CSV ET d’une entrée par ligne 
         * 
         * 4 pommes achetées, 1 € de réduction 
         * 5 fruits achetés, 2 € de réduction 
         * 
         * Tests Vérifications 
         * 
         * > Mele, Apples, Apples, Mele 
         * -> 200 
         * > Bananes 
         * -> 150 
         * > Mele, Apples, Apples, Pommes, Mele 
         * -> 150 
         *          
         * > Mele, Apples, Apples, Pommes, Mele 
         * -> 100 
         * > Bananes 
         * -> 250
         */
        public void GivenIteration7WhenGetPrixThenReturn250()
        {
            var caisse = new Caisse();

            caisse.Enregistrer(Fruitfactory.Create("Mele, Apples, Apples, Pommes, Mele"));
            caisse.Enregistrer(Fruitfactory.Create("Bananes"));

            Check.That(caisse.GetPrix()).IsEqualTo(250);
        }
    }
}
