using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Net.Sockets;
using Azure;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcR0EN0zKhbsFp2YjPukFLskwknem2D65Yi0Ng&usqp=CAU");
            cl1 objeto = new cl1();
            objeto.Enviar("Hola peque");
            objeto.Recibir();
            objeto.probar();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.youtube.com/watch?v=eGMHObp5cx4");
        }

       
    }
    class cl1
    {
        TcpClient tcpClient;
        NetworkStream ss;
        StreamReader clientStreamReader;

        public cl1()
        {
            tcpClient = new TcpClient();
            tcpClient.Connect("localhost", 5040);

            ss = tcpClient.GetStream();
            clientStreamReader = new StreamReader(ss);

        }

        public void Enviar(string S)
        {
            string aEnviar = S + "\n";
            byte[] ss2 = Encoding.ASCII.GetBytes(aEnviar);
            ss.Write(ss2, 0, ss2.Length);

        }

        public string Recibir()
        {
            string recibido = "";
            clientStreamReader.BaseStream.ReadTimeout = 20000;
            recibido = clientStreamReader.ReadLine();
            recibido = clientStreamReader.ReadLine();
            return recibido;
        }


        public void probar()
        {
            string recibido;

            string aEnviar = "abcdefgh\n";
            byte[] ss2 = Encoding.ASCII.GetBytes(aEnviar);

            ss.Write(ss2, 0, ss2.Length);
            recibido = clientStreamReader.ReadLine();
            recibido = clientStreamReader.ReadLine();
            //}
        }


    }
}
