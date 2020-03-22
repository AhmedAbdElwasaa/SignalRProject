using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;
using SignalRtest.Data.Entities;

namespace SignalRtest.Hubs
{
    public class CallCenterHub : Hub<ICallCenterHub>
    {
        public async Task JoinCallCenters()
        {
          await Groups.AddToGroupAsync(Context.ConnectionId, "CallCenters");
        }

        public async Task NewCallReceived(Call newCall)
        {
          await Clients.Group("CallCenters").NewCallReceived(newCall);
        }
    }
}
