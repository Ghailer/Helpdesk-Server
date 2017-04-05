using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace Helpdesk_Server
{
    static class connection_test
    {


        static public void testlacznosci(TcpClient newClient)
        {
            BinaryReader reader;
            BinaryWriter writer = new BinaryWriter(newClient.GetStream());   
            string test = "String testowy HELLO CLIENT!";
           // Console.WriteLine(test + " zostało wysłane");
            writer.Write(test);
            int i = 0;
            while (true)
            {
                // i++;
                Console.WriteLine("Nasluchiwanie");
                reader = (new BinaryReader(newClient.GetStream()));
                Console.WriteLine(reader.ReadString());
                //writer.Write(test + i);
                //Console.WriteLine("Wysłano " + i);
            }
            Console.ReadKey();
        }
    }
}
