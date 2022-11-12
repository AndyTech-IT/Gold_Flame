using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UDP_Server;

namespace Gold_Flame
{
    public class GameClient
    {
        public void SearchServers(int port)
        {
            byte[] data = new byte[0];
            UDP_Sender.SendBroadcast(data, port);
        }
    }
}
