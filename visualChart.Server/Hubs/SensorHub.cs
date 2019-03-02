using Microsoft.AspNetCore.SignalR;
using Microsoft.AspNetCore.SignalR.Client;
using System.Threading.Tasks;
using visualChart.Proxy.Models;

namespace visualChart.Server.Hubs
{
    public class SensorHub : Hub
    {
        public Task Broadcast(string sender, Measure measure)
        {
            return Clients.All.SendAsync("Broadcast", measure);
        }
    }
}
