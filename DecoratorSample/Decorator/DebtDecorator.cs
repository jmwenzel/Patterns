namespace DecoratorSample
{
    public class DebtDecorator : IDebt
    {
        protected IDebt _debt;

        public DebtDecorator(IDebt debt)
        {
            _debt = debt;
        }

        public double GetBalance()
        {
            return _debt.GetBalance();
        }

        public virtual double GetInterest()
        {
            return _debt.GetInterest();
        }

        public virtual string GetItems()
        {
            return _debt.GetItems();
        }
    }
}
