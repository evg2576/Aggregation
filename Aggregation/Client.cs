namespace Aggregation
{
    public class Client
    {
        private Deposit[] deposits;

        public Client()
        {
            deposits = new Deposit[10];
        }

        public bool AddDeposit(Deposit deposit)
        {
            for (int i = 0; i < deposits.Length; i++)
            {
                if (deposits[i] == null)
                {
                    deposits[i] = deposit;
                    return true;
                }
            }
            return false;
        }

        public decimal TotalIncome()
        {
            decimal result = 0;
            foreach (Deposit deposit in deposits)
            {
                if(deposit != null)
                    result += deposit.Income();
            }
            return result;
        }

        public decimal MaxIncome()
        {
            decimal max = decimal.MinValue;
            for (int i = 0; i < deposits.Length; i++)
            {
                if (deposits[i] != null && deposits[i].Income() > max)
                    max = deposits[i].Income();
            }
            return max;
        }

        public decimal GetIncomeByNumber(int number)
        {
            if (number <= deposits.Length && deposits[number - 1] != null)
            {
                return deposits[number - 1].Income();
            }
            else return 0;
        }
    }
}
