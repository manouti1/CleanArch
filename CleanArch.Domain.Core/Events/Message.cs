using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArch.Domain.Core.Events
{
    using MediatR;

    public abstract class Message : IRequest<bool>
    {
        public string MessageType{ get; protected set; }

        protected Message()
        {
            MessageType = GetType().Name;
        }
    }
}
