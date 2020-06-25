using System;
using System.Collections.Generic;
using System.Text;

namespace DiscountCards
{
    public class ProgramRun
    {
        public static void Run()
        {
            var bronzeCard = new BronzeCard("Ivan", 0);
            var bronzeCardPurchase = 150;
            Console.WriteLine(PayDesk.PrintCard(bronzeCard, bronzeCardPurchase));

            var silver = new SilverCard("Gosho", 600);
            var silverCardPurchase = 850;
            Console.WriteLine(PayDesk.PrintCard(silver, silverCardPurchase));

            var gold = new GoldenCard("Pesho", 1500);
            var goldCardPurchase = 1300;
            Console.WriteLine(PayDesk.PrintCard(gold, goldCardPurchase));
        }
    }
}
