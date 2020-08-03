using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArch.Domain.Core.Bus
{
    using System.Threading.Tasks;
    using CleanArch.Domain.Core.Commands;

    public interface IMediatorHandler
    {
        Task SendCommand<T>(T command) where T : Command;
    }
}
