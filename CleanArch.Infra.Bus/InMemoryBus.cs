using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArch.Infra.Bus
{
    using System.Threading.Tasks;
    using CleanArch.Domain.Core.Bus;
    using CleanArch.Domain.Core.Commands;
    using MediatR;

    //sealed no one can extend or add functionality
    public sealed class InMemoryBus : IMediatorHandler
    {
        private readonly IMediator _mediator;

        public InMemoryBus(IMediator mediator)
        {
            _mediator = mediator;
        }

        public Task SendCommand<T>(T command) where T : Command
        {
            return _mediator.Send(command);
        }

    }
}
