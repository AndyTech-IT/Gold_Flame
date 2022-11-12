using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Security.AccessControl;
using System.Text;
using UDP_Server;

namespace Gold_Flame
{
    public partial class Form1 : Form
    {
        Dictionary<string, IPEndPoint> _senders;

        public Form1()
        {
            InitializeComponent();
            _senders = new Dictionary<string, IPEndPoint>();
        }

        private static byte[] Encode_Hello_Message(string user_name, ushort port) => Encode_String(user_name).Concat(Encode_Ushort(port)).ToArray();

        private static byte[] Encode_String(string value)
        {
            byte[] str_bytes = Encoding.UTF8.GetBytes(value);
            return Encode_Ushort((ushort)str_bytes.Length).Concat(str_bytes).ToArray();
        }

        private static byte[] Encode_Ushort(ushort value)
        {
            return BitConverter.GetBytes(value);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            UDP_Listener.Start(80);
            UDP_Listener.Data_Received += On_Received;


            TCP_Listener client1_listener = new();
            client1_listener.Data_Received += On_1_Recieved;
            ushort port1 = client1_listener.Start();

            UDP_Sender.SendBroadcast(Encode_Hello_Message("User1", port1), 80);

            TCP_Listener client2_listener = new();
            client2_listener.Data_Received += On_2_Recieved;
            ushort port2 = client2_listener.Start();

            UDP_Sender.SendBroadcast(Encode_Hello_Message("User2", port2), 80);
        }

        void On_1_Recieved(IPEndPoint? sender, byte[] data)
        {
            Debug.WriteLine($"1 Recieved: {Encoding.UTF8.GetString(data)} from {sender}");
        }

        void On_2_Recieved(IPEndPoint? sender, byte[] data)
        {
            Debug.WriteLine($"2 Recieved: {Encoding.UTF8.GetString(data)} from {sender}");
        }



        int PORT_NO = 5000;
        const string SERVER_IP = "127.0.0.1";
        private void Server(object? data)
        {
            string name = data?.ToString() ?? "No name";
            IPAddress localAdd = IPAddress.Parse(SERVER_IP);
            TcpListener listener = new TcpListener(localAdd, PORT_NO++);
            Debug.WriteLine("Listening...");
            listener.Start();

            //---incoming client connected---
            TcpClient client = listener.AcceptTcpClient();

            //---get the incoming data through a network stream---
            NetworkStream nwStream = client.GetStream();
            byte[] buffer = new byte[client.ReceiveBufferSize];

            //---read incoming stream---
            int bytesRead = nwStream.Read(buffer, 0, client.ReceiveBufferSize);

            //---convert the data received into a string---
            string dataReceived = Encoding.UTF8.GetString(buffer, 0, bytesRead);
            Debug.WriteLine("Received : " + dataReceived);

            //---write back the text to the client---
            Debug.WriteLine("Sending back : " + name);
            nwStream.Write(Encoding.UTF8.GetBytes(name));
            client.Close();
            listener.Stop();
        }

        private void On_Received(byte[] data, IPAddress? ip)
        {
            byte[] len_data = data.Take(2).ToArray();
            data = data.Skip(2).ToArray();
            ushort name_len = BitConverter.ToUInt16(len_data);
            string sender_name = Encoding.UTF8.GetString(data.Take(name_len).ToArray());
            data = data.Skip(name_len).ToArray();
            ushort port = BitConverter.ToUInt16(data.Take(2).ToArray());

            string textToSend = "";
            IPEndPoint sender = new(ip!, port);
            if (_senders.ContainsKey(sender_name) == false)
            {
                _senders.Add(sender_name, sender);
                textToSend = $"Welcome {sender_name}!";
            }
            else
            {
                textToSend = $"Hello again {sender_name}..";
            }


            //---create a TCPClient object at the IP and port no.---
            TcpClient client = new();

            //---send the text---
            Debug.WriteLine("Sending : " + textToSend);
            byte[] bytesToSend = Encoding.UTF8.GetBytes(textToSend);
            client.Connect(sender);
            client.Client.Send(bytesToSend);

            ////---read back the text---
            //byte[] bytesToRead = new byte[client.ReceiveBufferSize];
            //int bytesRead = nwStream.Read(bytesToRead, 0, client.ReceiveBufferSize);
            //Debug.WriteLine("Received : " + Encoding.UTF8.GetString(bytesToRead, 0, bytesRead));
            client.Close();
        }
    }
}