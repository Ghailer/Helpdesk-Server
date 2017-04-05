using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Net.Sockets;
using System.Net;
using System.IO;
using System.Threading;

namespace Helpdesk_Server
{

    class Program
    {
        public static List<ClientSocket> cList = new List<ClientSocket>();
        static void Main(string[] args)
        {
           SqlConnection connection = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename =" + @"C:\Users\Rafal.Szmajser\Documents\Visual Studio 2017\Projects\Helpdesk\Helpdesk\helpdeskDB.mdf" + "; Integrated Security = True");
            SQLCommands ClientSQL = new SQLCommands(connection);
            TcpListener listener = new TcpListener(IPAddress.Parse("127.0.0.1"), 8843);
            listener.Start();
            Console.WriteLine("Oczekuje na połączenie");
            while (true)
            {
                TcpClient newClient = listener.AcceptTcpClient();
                Console.WriteLine("Welcome " + newClient.Client.RemoteEndPoint.ToString());
                cList.Add(new ClientSocket(newClient));
                Thread thd = new Thread(() => connection_test.testlacznosci(newClient));
                thd.Start();
                
            }
            
            /*BinaryReader reader;
            BinaryWriter writer = new BinaryWriter(newClient.GetStream());   
            string g = "blablabla";
            Console.WriteLine(g + " zostało wysłane");
            writer.Write(g);       
            while (true)
            {
                reader = (new BinaryReader(newClient.GetStream()));
                Console.WriteLine(reader.ReadString());
                writer.Write(g);
            }*/
            
        }
    }
}
