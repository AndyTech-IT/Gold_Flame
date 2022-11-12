using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using UDP_Server;

namespace Gold_Flame
{
    public class GameServer
    {
        public const int Port = 80;
        private TCP_Listener _listener;
        private string Server_Title;

        public int Players_Count { get; private set; }
        public int Max_Players_Count { get; private set; }

        public enum MessageType
        {
            Server_Info = -1,
            Give_Server_Info = 0,
            I_Want_Enter,
            I_Want_Leave,
        }


        public GameServer(string server_title, int max_players = 4)
        {
            _listener = new();
            _listener.Data_Received += On_Message_Received;
            UDP_Listener.Data_Received += On_Broadcast_Received;
            Players_Count = 0;
            Max_Players_Count = max_players;
            Server_Title = server_title;
        }

        private void On_Message_Received(IPEndPoint? ip, byte[] data)
        {

        }

        private void On_Broadcast_Received(byte[] data, IPAddress? ip)
        {
            Message_Header header = Message_Header.Get_Header(ref data);
            IPEndPoint endPoint = new(ip!, header.Port);
            TcpClient client = new();
            client.Connect(endPoint);
            client.Client.Send(Encode_Server_Data());
        }

        private byte[] Encode_Server_Data()
        {
            byte[] data = Message_Header.Encode_Header((int)MessageType.Server_Info, Server_Title, Port);
            data = data
                .Concat(Max_Players_Count.Encode())
                .Concat(Players_Count.Encode())
                .ToArray();
            return data;
        }
    }
}
