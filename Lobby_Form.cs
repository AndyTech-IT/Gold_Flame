using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Numerics;
using System.Text;
using System.Windows.Forms;
using LAN_Game;

namespace Gold_Flame
{
    public partial class Lobby_Form : Form
    {
        static readonly LAN_Player player = new();
        static readonly Room_Form room = new(player);
        static readonly Login_Form login = new();

        public Lobby_Form()
        {
            InitializeComponent();
            player.Room_Get_Info += Player_Room_Get_Info;
        }

        private void Player_Room_Get_Info(LAN_Message message)
        {
            Invoke(Add_Room, message);
        }

        private void Add_Room(LAN_Message message)
        {
            var players_count = message.Data.Decode_Int();
            var max_players = message.Data.Decode_Int(players_count.EndIndex);
            Rooms_LV.Items.Add(new ListViewItem(new[]
            {
                message.Hostname, message.address!.ToString(), players_count.Result.ToString(), max_players.Result.ToString()
            }));
        }

        private void Enter_B_Click(object sender, EventArgs e)
        {
            if (Rooms_LV.SelectedItems.Count == 0)
                return;

            if (login.Show_Login(player.Name) != DialogResult.OK)
                return;

            player.Name = login.Login;
            var item = Rooms_LV.SelectedItems[0];
            IPAddress address = IPAddress.Parse(item.SubItems[1].Text);
            LAN_Member server = new(item.Text, address, LAN_Room.PORT);

            room.Show_Room(server, login.Password);
        }

        private void Refresh_B_Click(object sender, EventArgs e)
        {
            Rooms_LV.Items.Clear();
            player.Search_Servers();
        }

        private void Lobby_Form_Load(object sender, EventArgs e)
        {
            Refresh_B_Click(sender, e);
        }

        private void Host_B_Click(object sender, EventArgs e)
        {
            if (login.Show_Login(player.Name) == DialogResult.OK)
            {
                player.Name = login.Login;
                room.Show_Room(password:login.Password);
            }
        }
    }
}