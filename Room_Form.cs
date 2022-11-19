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

        public Room_Form(LAN_Player player)
        {
            InitializeComponent();
            _player = player;
            player.Me_Leave_Room += Me_Leave_Room;
            player.Rject_Enter_In_Room += Rject_Enter_In_Room;
            player.Me_Enter_In_Room += Me_Enter_In_Room;
            player_Hand1.Card_Selected += Card_Selected;
        }

        private void Card_Selected(string card)
        {
            cards_Table1.Curent_Card = card;
        }

        private void Me_Enter_In_Room()
        {
            _online = true;
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
