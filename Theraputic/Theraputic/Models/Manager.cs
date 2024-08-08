using Microsoft.AspNetCore.SignalR.Client;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Diagnostics;

namespace Theraputic.Models
{
    static class Manager
    {
        public static string wsURL = "http://35.232.68.4:80/chatHub";
        public static HubConnection connect;

        public static async System.Threading.Tasks.Task connectToWSAsync()
        {
            connect = new HubConnectionBuilder().WithUrl(wsURL).WithAutomaticReconnect().Build();
            await Task.Delay(new Random().Next(0, 5) * 1000);
            await connect.StartAsync();
            Debug.WriteLine(" manager : connected");
        }
    }
}
