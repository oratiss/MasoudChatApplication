using MasoudChatApplication.Client.Domains;
using Microsoft.AspNetCore.SignalR.Client;
using System.Text.Json;
using System.Threading.Tasks;

namespace MasoudChatApplication.Client.Services
{
    public class ChatService : IChatService
    {
        public ChatForm ChatForm { get; set; } = new ChatForm();
        public bool HasSentMsg { get; set; }

        public HubConnection HubConnection { get; set; }

    }

}
