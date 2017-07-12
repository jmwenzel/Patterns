using DecoratorSample;
using DecoratorSample.ConcreteDecorator;
using System;

namespace RunDecorator
{
    class Program
    {
        static void Main(string[] args)
        {
            IDebt debt = new Debt();
            Console.WriteLine(debt.GetItems());
            Console.WriteLine($"Total debt: { debt.GetBalance() + debt.GetInterest()}");
            Console.WriteLine();

            debt = new OverdueInterest(debt);
            Console.WriteLine(debt.GetItems());
            Console.WriteLine($"Total debt: { debt.GetBalance() + debt.GetInterest()}");
            Console.WriteLine();

            debt = new Insurance(debt);
            Console.WriteLine(debt.GetItems());
            Console.WriteLine($"Total debt: { debt.GetBalance() + debt.GetInterest()}");
            Console.ReadKey();
        }
    }
}
