namespace DecoratorSample
{
    public class OverdueInterest : DebtDecorator
    {
        public OverdueInterest(IDebt debt) : base(debt)
        {
        }

        public override double GetInterest()
        {
            return _debt.GetInterest() + 10;
        }

        public override string GetItems()
        {
            return $"{_debt.GetItems()}, Overdue: 10";
        }
    }
}
