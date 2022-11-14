using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using NetworkGame_Asset;
using static Gold_Flame.GameServer;

namespace Gold_Flame
{
    public partial class Form1 : Form
    {
        GameClient user = new();
        public Form1()
        {
            InitializeComponent();
            GameServer.Client_Response += On_Client_Response;
            user.Server_Response += On_Server_Response;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Refresh_Servers_Click(sender, e);
        }

        void On_Client_Response((int message_type, byte[] data) response)
        {
            MessageBox.Show(response.data.Decode_String());
        }

        void On_Server_Response(GameMessage response)
        {
            GameServer.Info info = response.Data.ToArray().Decode_GameServer_Info();
            Invoke(Add_Server, new object[] { response.Hostname, info.Players_Count, info.Max_Players_Count });
        }

        void Add_Server(string name, int players, int max)
        {
            var item = new ListViewItem(new[] { name, players.ToString(), max.ToString() });
            Servers_LV.Items.Add(item);
        }

        private void Add_Player_Click(object sender, EventArgs e)
        {
            new Form1().Show();
        }

        private void TouglleServer_Click(object sender, EventArgs e)
        {
            if (GameServer.Enabled)
            {
                TouglleServer.Text = "Включить сервер";
                GameServer.Stop();
            }
            else
            {
                TouglleServer.Text = "Выключить сервер";
                GameServer.Start();
            }
        }

        private void ServerTitle_TB_Leave(object sender, EventArgs e)
        {
            ServerTitle_TB.Text = GameServer.Server_Title;
        }

        private void ServerTitle_TB_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    GameServer.Server_Title = ServerTitle_TB.Text;
                    break;
                case Keys.Escape:
                    ServerTitle_TB.Text = GameServer.Server_Title;
                    break;
            }
        }

        private void Refresh_Servers_Click(object sender, EventArgs e)
        {
            Servers_LV.Clear();
            Servers_LV.Columns.Add("Название", 120);
            Servers_LV.Columns.Add("Онлайн", 70);
            Servers_LV.Columns.Add("Максимум", 70);
            user.SearchServers();
        }
    }
}