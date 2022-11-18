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

        public Room_Form(LAN_Player player)
        {
            InitializeComponent();
            _player = player;
            player.Me_Leave_Room += Me_Leave_Room;
        }

        private void Me_Leave_Room()
        {
            if (_im_host)
            {
                return;
            }
            DialogResult = DialogResult.Abort;
            Invoke(Close);
        }

        public DialogResult Show_Room(LAN_Member? server = null)
        {
            if (server is null)
            {
                LAN_Room.Open(_player.Player_Data);
                _server = LAN_Room.Room_Data;
                _im_host = true;
            }
            else
            {
                _player.TryConect(server.Value.EndPoint);
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
                if (DialogResult != DialogResult.Abort)
                    _player.Disconect();
            }
            DialogResult = DialogResult.OK;
        }
    }
}
