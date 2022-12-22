using Microsoft.AspNet.SignalR;
using Microsoft.AspNet.SignalR.Hubs;
using SignalRDenemeMvc.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SignalRDenemeMvc.SignalHub
{
    [HubName("besinlerHub")]
    public class besinlerHub: Hub
    {
        public static void Show()
        {
            IHubContext context = GlobalHost.ConnectionManager.GetHubContext<besinlerHub>();
            context.Clients.All.tetikle();
        }
    }
}