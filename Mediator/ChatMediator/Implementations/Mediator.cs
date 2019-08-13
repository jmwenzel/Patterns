using ChatMediator.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChatMediator.Implementations
{
    public class Mediator : IMediator
    {
        private readonly List<IUser> users;

        public Mediator()
        {
            users = new List<IUser>();
        }

        public void Register(IUser user)
        {
            users.Add(user);
        }

        public void SendMessage(IUser user, string message)
        {
            var filteredUsers = users.Where(x => x != user).ToList();
            foreach (var filteredUser in filteredUsers)
            {
                filteredUser.ReceiveMessage(message);
            }
        }
    }
}
