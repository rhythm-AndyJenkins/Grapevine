﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.AspNet.SignalR;

namespace Our.Umbraco.Grapevine.Hubs {

    public class ChatHub : Hub {
        public void Send(string name, string message) {
            // Call the broadcastMessage method to update clients.
            Clients.All.broadcastMessage(name, message);
        }
    }

}
