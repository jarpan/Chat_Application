using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;
using ChatRemote;
namespace ChatServer
{
    class Program
    {
        static void Main(string[] args)
        {
            TcpChannel chan = new TcpChannel(1234);
            ChannelServices.RegisterChannel(chan, false);
            RemotingConfiguration.RegisterWellKnownServiceType(typeof(RemoteClass), "Multi", WellKnownObjectMode.Singleton);
            Console.WriteLine("Server Started....");
            Console.ReadLine();
        }
    }
}
