namespace Aggregation
{
    public class LongDeposit : Deposit
    {
        public LongDeposit(decimal amount, int period) : base(amount, period)
        {

        }

        public override decimal Income()
        {
            decimal result = Amount;
            for (int i = 0; i < Period; i++)
            {
                if (i > 5)
                    result += 0.15m * result;
            }
            return (result - Amount);
        }
    }
}
