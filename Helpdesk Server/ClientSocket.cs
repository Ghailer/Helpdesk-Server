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
        
        
        public void testowo(Dictionary<string, Action<string>> testDict)
        {
            // testDict.Add("INSERT INTO Users" , ((string x) => AddUser(command)));
            testDict.Add("INSERT INTO Users", ((string x) => Console.WriteLine("String1")));
            testDict.Add("test2", ((string x) => Console.WriteLine("String2")));
        }

        public void testrun(Dictionary<string, Action<string>> testDict)
        {
            if (testDict.ContainsKey("test2"))
            {
                Console.WriteLine("test2");
                var funkcja = testDict["test2"];
                funkcja.Invoke("sss");
            }
        }
        
        public ClientSocket(TcpClient Client)
        {
            client = Client;
        }
    }
}
