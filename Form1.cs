using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Threading.Tasks;
using System.Net;
using System.Threading;

namespace AsyncBlockingTcpListenerBug
{
    public partial class Form1 : Form
    {
        private TcpListener _listener;

        public Form1()
        {
            InitializeComponent();
        }

        private void startListener_Click(object sender, EventArgs e)
        {
            _listener = new TcpListener(IPAddress.Any ,54321);
            _listener.Start();

            sendMessage.Enabled = true;

            Thread listenThread = new Thread(ListenForConnections);
            listenThread.Start();
        }

        private void ListenForConnections()
        {
            while (true)
            {
                //Using AcceptTcpClient callers get a response
                TcpClient client = _listener.AcceptTcpClient();

                NetworkStream stream = client.GetStream();

                while (client.Connected)
                {

                    byte[] data = new byte[1024];
                    int length = 0;

                    while (length < 1024)
                    {
                        data[length] = (byte)stream.ReadByte();

                        if (data[length] == '\n')
                            break;

                        length++;
                    }

                    stream.Write(data, 0, length);
                }

                
            }
        }

        private void sendMessage_Click(object sender, EventArgs e)
        {
            TcpClient client = new TcpClient("localhost", 54321);

            NetworkStream stream = client.GetStream();

            stream.Write(Encoding.UTF8.GetBytes("hello\n"), 0, 6);

            byte[] buffer = new byte[6];
            stream.Read(buffer, 0, 6);

            string response = Encoding.UTF8.GetString(buffer);

            MessageBox.Show(String.Format("Response was {0}", response));
        }
    }
}
