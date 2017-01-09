using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;
using System.Net;

namespace lab2_communimcation
{
    class Program
    {
        static void Main(string[] args)
        {
            IPHostEntry myIP = Dns.Resolve(Dns.GetHostName());
            IPAddress ip = myIP.AddressList[0];
            IPEndPoint ipEnd = new IPEndPoint(ip, 6000);

            MyTcpClient mc = new MyTcpClient();
            MyTcpListener ml = new MyTcpListener();



            ml.Listen(6000, ip);
            mc.Connect("HELLOO!!", ip, 6000);
        }
    }
}
