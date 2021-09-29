using System;

namespace Aggregation
{
    public class BaseDeposit : Deposit
    {
        public BaseDeposit(decimal amount, int period) : base(amount, period)
        {

        }

        public override decimal Income()
        {
            decimal result = Amount;
            for (int i = 0; i < Period; i++)
            {
                result += 0.05m * result;
            }
            return Math.Round(result - Amount, 2);
        }
    }
}
