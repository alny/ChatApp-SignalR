using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SignalR {
    public class ChatHub : Hub {
        // The hubs task is to just throw back the messages to all the conncted users
        public async Task Send(string name, string message) {
            await Clients.All.SendAsync("Send", name, message);
        }

    }
}
