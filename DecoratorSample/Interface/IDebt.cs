using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorSample
{
    public interface IDebt
    {
        double GetBalance();
        double GetInterest();
        string GetItems();
    }
}
