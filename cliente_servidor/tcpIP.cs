using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace servidor1
{

    class tcpip
    {

        List<Thread> thread;

        public void escucha()
        {
            thread = new List<Thread>();

            IPHostEntry ipHostInfo = Dns.GetHostEntry(Dns.GetHostName());
            IPAddress ipAddress = ipHostInfo.AddressList[1];
            IPEndPoint localEndPoint = new IPEndPoint(ipAddress, 11000);

            Socket listener = new Socket(ipAddress.AddressFamily,
                SocketType.Stream, ProtocolType.Tcp);
            listener.Bind(localEndPoint);
            listener.Listen(100);
            Socket cliente;
            while (true)
            {
                cliente = listener.Accept();
                Thread hilo = new Thread(disparaCliente);
                hilo.Start(cliente);
                thread.Add(hilo);
            }
        }

        public void procesa1Cliente()
        {
        }

        public void disparaCliente(Object o)
        {
            Socket param = (Socket)o;
            byte[] enviar = Encoding.ASCII.GetBytes("Hola\n");
            param.Send(enviar);
            byte[] recibir = new byte[1];
            string recibido = "";
            param.Receive(recibir, 0);
            while (recibir[0] != 13 && recibir[0] != 10)
            {
                recibido += char.ConvertFromUtf32(recibir[0]);
                param.Receive(recibir, 0);
            }
            Console.WriteLine(recibido);
            //Console.ReadKey();
        }

    }

    class Program
    {


        static void Main(string[] args)
        {

            tcpip escucha = new tcpip();
            escucha.escucha();

        }

    }
}