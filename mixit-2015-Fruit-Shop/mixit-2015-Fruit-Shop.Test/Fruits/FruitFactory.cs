namespace Mixit2015FruitShop.Test.Fruits
{
    using System.Collections.Generic;
    using System.IO;

    public class FruitFactory
    {
        public IEnumerable<IFruit> Create(string input)
        {
            var fruits = input.Split(',');
            foreach (var fruit in fruits)
            {
                switch (fruit.Trim())
                {
                    case "Cerises":
                        yield return new Cerise();
                        break;
                    case "Pommes":
                        yield return new Pomme();
                        break;
                    case "Apples":
                        yield return new Apples();
                        break;
                    case "Mele":
                        yield return new Mele();
                        break;
                    case "Bananes":
                        yield return new Banane();
                        break;
                    default:
                        throw new InvalidDataException("Fruit inconnu : " + input);
                }
            }
        }
    }
}
