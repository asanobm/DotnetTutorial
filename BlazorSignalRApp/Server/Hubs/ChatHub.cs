//
//  ChatHub.cs
//
//  Author:
//       Asanobm <kim_bumin@fourglobe.co.jp>
//
// 7/12/2020 
using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;

namespace BlazorSignalRApp.Server.Hubs
{
    public class ChatHub : Hub
    {
        public async Task SendMessage(string user, string message)
        {
            await Clients.All.SendAsync("ReceiveMessage", user, message);
        }
    }
}
