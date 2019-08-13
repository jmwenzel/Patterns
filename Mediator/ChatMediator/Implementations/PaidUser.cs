using ChatMediator.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChatMediator.Implementations
{
    public class PaidUser : IUser
    {
        private readonly string _name;
        private readonly IMediator _mediator;

        public PaidUser(IMediator mediator, string name)
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
