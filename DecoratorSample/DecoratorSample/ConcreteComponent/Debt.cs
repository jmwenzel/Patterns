namespace DecoratorSample
{
    public class Debt : IDebt
    {
        public double GetBalance()
        {
            return 1000;
        }

        public double GetInterest()
        {
            return 100;
        }

        public string GetItems()
        {
            return $"Balance: 1000, Interest: 100";
        }
    }
}
