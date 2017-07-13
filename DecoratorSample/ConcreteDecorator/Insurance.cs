using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorSample.ConcreteDecorator
{
    public class Insurance : DebtDecorator
    {
        public Insurance(IDebt debt) : base(debt)
        {
        }

        public override double GetInterest()
        {
            return _debt.GetInterest() + (_debt.GetBalance() + _debt.GetInterest())*0.003 ;
        }

        public override string GetItems()
        {
            return $"{_debt.GetItems()}, Insurance: {(_debt.GetBalance() + _debt.GetInterest())*0.003}";
        }
    }
}
