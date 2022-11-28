using LAN_Game;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gold_Flame
{
    public partial class Room_Form : Form
    {
        LAN_Player _player;
        LAN_Member _server;
        bool _im_host;
        bool _online;

        Player_Hand[] hands;

        public Room_Form(LAN_Player player)
        {
            InitializeComponent();
            _player = player;
            Text = player.Name;
            player.Other_Enter_In_Room += On_Other_Enter_In_Room;
            player.Other_Leave_Room += Other_Leave_Room;
            player.Me_Leave_Room += Me_Leave_Room;
            player.Rject_Enter_In_Room += Rject_Enter_In_Room;
            player.Me_Enter_In_Room += Me_Enter_In_Room;
            player_Hand1.Card_Selected += Card_Selected;
            hands = new[] { player_Hand1, player_Hand2, player_Hand3, player_Hand4, player_Hand5 };
        }

        private void Other_Leave_Room(Player_Login obj)
        {
            Invoke(Refresh_Players);
        }

        private void On_Other_Enter_In_Room(Player_Login player)
        {
            Invoke(Refresh_Players);
        }

        private void Card_Selected(string card)
        {
            cards_Table1.Curent_Card = card;
        }

        private void Me_Enter_In_Room()
        {
            _online = true;
            Invoke(Refresh_Players);
        }

        private void Refresh_Players()
        {
            for (int i = 0; i < hands.Length; i++)
            {
                hands[i].Power_Score = 0;
                hands[i].Login = "";
            }
            foreach (var player in _player.Room_Players)
            {
                hands[player.ID].Login = player.Name;
            }
            hands[_player.ID].Login = _player.Name;
        }

        private void Rject_Enter_In_Room(LAN_Message message)
        {
            MessageBox.Show(message.Data.Decode_String().Result);
        }

        private void Me_Leave_Room()
        {
            _online = false;
            MessageBox.Show("You leave room");
        }

        public DialogResult Show_Room(LAN_Member? server = null, string password = "")
        {
            _online = false;
            if (server is null)
            {
                LAN_Room.Open(_player.Player_Data, _player.Name + "`s room", password, 5, 3);
                _server = LAN_Room.Room_Data;
                _im_host = true;
            }
            else
            {
                _player.TryConect(server.Value.EndPoint, password);
                _server = server.Value;
                _im_host = false;
            }
            Text = _player.Name;
            DialogResult = DialogResult.None;
            DialogResult result = ShowDialog();

            return result;
        }

        private void Room_Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_im_host)
            {
                LAN_Room.Close();
            }
            else
            {
                if (_online == true)
                    _player.Disconect();
            }
        }
    }
}
