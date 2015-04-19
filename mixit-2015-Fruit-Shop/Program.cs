namespace Mixit2015FruitShop
{
    using System;
    using System.IO;
    using Test;

    /**
     * http://fr.slideshare.net/brunoboucard/fruit-shop-techdays-2015 
     */
    public static class Program
    {
        public static void Main()
        {
            var caisse = new Caisse();
            var fruitfactory = new FruitFactory();

            try
            {
                var input = Console.ReadLine();
                while (input != "exit")
                {
                    caisse.Enregistrer(fruitfactory.Create(input));
                    Console.WriteLine("-> " + caisse.GetPrix());
                    input = Console.ReadLine();
                }
            }
            catch (InvalidDataException ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadLine();
            }
        }
    }
}
