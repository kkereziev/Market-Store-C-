using System;
using System.Collections.Generic;
using System.Text;

namespace DiscountCards
{
    public class PayDesk
    {
        public static string PrintCard(DiscountCard card, double purchaseValue)
        {
            var sb=new StringBuilder();
            sb.AppendLine($"Purchase value: ${purchaseValue:f2}");
            sb.AppendLine($"Discount rate: {card.DiscountRate:f1}%");
            sb.AppendLine($"Discount: ${card.Discount(purchaseValue):f2}");
            sb.AppendLine($"Total: ${SumTotalPriceForPurchase(purchaseValue,card):f2}");
            return sb.ToString();
        }

        private static double SumTotalPriceForPurchase(double purchaseValue, DiscountCard card)
        {
            return Math.Round(purchaseValue - card.Discount(purchaseValue), 2);
        }
    }
}
