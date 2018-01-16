using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;

namespace SignalRCore2Chat
{
    public class Chat : Hub
    {
        public async Task Send(string guestName, string message)
        {
            await Clients.All.InvokeAsync("Send", guestName, message);
        }

        //public override Task OnConnectedAsync()
        //{
        //    Clients.All.InvokeAsync("broadcastMessage", "system" + $"{Context.ConnectionId}", "joined the conversation");
        //    return base.OnConnectedAsync();
        //}

        //public override Task OnDisconnectedAsync(System.Exception exception)
        //{
        //    Clients.All.InvokeAsync("broadcastMessage", "system", $"{Context.ConnectionId} left the conversation");
        //    return base.OnDisconnectedAsync(exception);
        //}
    }
}
