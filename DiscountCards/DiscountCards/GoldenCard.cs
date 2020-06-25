using System;
using System.Collections.Generic;
using System.Text;

namespace DiscountCards
{
    public class GoldenCard : DiscountCard
    {
        private double _discount;
        private double _turnover;

        public GoldenCard(string owner, int turnover)
            : base(owner, turnover)
        {
            this.DiscountRate = 2.0;
            this._turnover = turnover;
        }

        public sealed override double DiscountRate
        {
            get => this._discount;
            protected set
            {
                if (this.Turnover > 100)
                {
                    value += this.Turnover / 100;
                    if (value > 10)
                    {
                        value = 10.0;
                    }
                }
                this._discount = value;
            }
        }
    }
}
