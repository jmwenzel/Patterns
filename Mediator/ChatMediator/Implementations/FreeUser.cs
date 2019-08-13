using ChatMediator.Interfaces;
using System;

namespace ChatMediator.Implementations
{
    public class FreeUser : IUser
    {
        private readonly string _name;
        private readonly IMediator _mediator;

        public FreeUser(IMediator mediator, string name)
        {
            _mediator = mediator;
            _name = name;
        }
        public void ReceiveMessage(string message)
        {
            Console.WriteLine(_name + " received " + message.ToString());
        }

        public void SendMessage(string message)
        {
            _mediator.SendMessage(this, message);
        }
    }
}
