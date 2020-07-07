using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MasoudChatApplication.Client.Domains
{
    public class ChatForm
    {
        public string MessageInput { get; set; }
        public object CurrentUser { get; set; } = new ChatUser();
    }
}
