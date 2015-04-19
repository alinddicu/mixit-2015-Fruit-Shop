﻿namespace Mixit2015FruitShop.Test
{
    using System.Linq;
    using System.Collections.Generic;

    public class Apples : IFruit
    {
        private const int PrixUnitaire = Pomme.PrixUnitaire;
        private const int PrixPar3 = 200;

        public int GetPrixUnitaire()
        {
            return PrixUnitaire;
        }

        public static int CalculatePrixPanier(IEnumerable<IFruit> fruits)
        {
            var nbApples = fruits.Count(f => f is Apples);
            var prixPar1 = (nbApples % 3) * PrixUnitaire;
            var prixPar3 = nbApples / 3 * PrixPar3;

            return prixPar1 + prixPar3;
        }
    }
}