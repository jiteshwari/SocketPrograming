using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace ShocketProgramming
{
    class Class1
    {
        //static log4net.ILog log = log4net.LogManager.GetLogger(typeof(Action));
        /// <summary>
        /// its ClientProgram Method 
        /// socket is combination of the addressfamilly ,sockettype and protocoltype
        /// client ip address is bind with the port numbers
        /// </summary>
        public static void ClientProgram()
        {
            try
            {
                Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

                Console.WriteLine("try to connecting ");
                //socket.Connect(new IPEndPoint(IPAddress.Parse("192.168.1.21"),3000));
                Console.WriteLine("Connected");
                Console.WriteLine("Enter Something");
                string msg = Console.ReadLine();
                byte[] message = Encoding.Default.GetBytes(msg);
                //socket.Send(message, 0, message.Length, 0);

                //log.Info(msg);
                socket.Close();
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
                //log.Error(e);
            }
        }

        static void Main(string[] args)
        {
            ClientProgram();
            Console.Read();
        }
    }
} 