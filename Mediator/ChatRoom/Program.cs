using ChatMediator.Implementations;
using ChatMediator.Interfaces;
using System;

namespace ChatRoom
{
    class Program
    {
        static void Main(string[] args)
        {
            IMediator mediator = new Mediator();

            IUser jackson = new FreeUser(mediator, "Jackson");
            IUser jose = new PaidUser(mediator, "Jose");
            IUser cesar = new FreeUser(mediator, "Cesar");

            mediator.Register(jackson);
            mediator.Register(jose);
            mediator.Register(cesar);

            jackson.SendMessage("Good morning");
            Console.WriteLine();
            jose.SendMessage("Welcome!");
            Console.WriteLine();
            jose.SendMessage("Have a nice day!");

            Console.ReadKey();
        }
    }
}
