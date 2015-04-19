namespace Mixit2015FruitShop.Test
{
    using System.IO;

    public class FruitFactory
    {
        public IFruit Create(string input)
        {
            switch (input)
            {
                case "Cerises":
                    return new Cerise();
                case "Pommes":
                    return new Pomme();
                case "Bananes":
                    return new Banane();
            }

            throw new InvalidDataException("Fruit non connu" + input);
        }
    }
}
