using System;
using System.Collections.Generic;
using System.Text;

namespace ChatMediator.Interfaces
{
    public interface IMediator
    {
        void Register(IUser user);
        void SendMessage(IUser user, string message);
    }
}
