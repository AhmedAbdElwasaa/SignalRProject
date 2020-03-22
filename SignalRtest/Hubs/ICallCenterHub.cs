using SignalRtest.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SignalRtest.Hubs
{
    public interface ICallCenterHub
    {
        Task NewCallReceived(Call newCall);
        Task JoinCallCenters();
    }
}
