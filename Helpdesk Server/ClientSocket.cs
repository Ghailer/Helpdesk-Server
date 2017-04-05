using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;

namespace Helpdesk_Server
{
    public class ClientSocket
    {
        TcpClient client;
        string user = "x";       
        
        public ClientSocket(TcpClient Client)
        {
            client = Client;
        }
    }
}
