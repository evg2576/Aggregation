namespace Aggregation
{
    public class SpecialDeposit : Deposit
    {
        public SpecialDeposit(decimal amount, int period) : base(amount, period)
        {

        }

        public override decimal Income()
        {
            decimal result = Amount;
            for (int i = 0; i < Period; i++)
            {
                result += ((i + 1) * 0.01m * result);
            }
            return (result - Amount);
        }
    }
}
