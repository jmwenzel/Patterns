using System;
using System.Collections.Generic;
using System.Text;

namespace ChatMediator.Interfaces
{
    public interface IUser
    {
        void SendMessage(string message);
        void ReceiveMessage(string message);
    }


}
