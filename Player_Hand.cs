using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gold_Flame
{
    public partial class Player_Hand : UserControl
    {
        private static event Action? FirstMove_Seted;

        public event Action<string>? Card_Selected;

        [Category("Game"), Description("This player move first")]
        public bool FirstMove
        {
            get => FirstMove_RB.Checked;
            set
            {
                if (value)
                    FirstMove_Seted?.Invoke();
                FirstMove_RB.Checked = value;
            }
        }

        [Category("Game"), Description("This player login")]
        public string Login
        {
            get => Login_L.Text;
            set => Login_L.Text = value;
        }

        [Category("Game"), Description("This player power score")]
        public int Power_Score
        {
            get => int.Parse(Power_L.Text);
            set => Power_L.Text = value.ToString();
        }

        [Category("Game"), Description("This player active cards")]
        public string[] Active_Cards
        {
            get
            {
                string[] result = new string[ActiveCards_LB.Items.Count];
                for (int i = 0; i < ActiveCards_LB.Items.Count; i++)
                {
                    result[i] = ActiveCards_LB.Items[i].ToString()!;
                }
                return result;
            }
            set
            {
                ActiveCards_LB.Items.Clear();
                ActiveCards_LB.Items.AddRange(value);
            }
        }

        [Category("Game"), Description("This player passive cards")]
        public string[] Passive_Cards
        {
            get
            {
                string[] result = new string[PassiveCards_LB.Items.Count];
                for (int i = 0; i < PassiveCards_LB.Items.Count; i++)
                {
                    result[i] = PassiveCards_LB.Items[i].ToString()!;
                }
                return result;
            }
            set
            {
                PassiveCards_LB.Items.Clear();
                PassiveCards_LB.Items.AddRange(value);
            }
        }

        [Category("Flash"), Description("Flip player")]
        public bool Invert
        { 
            get => _invert; 
            set
            {
                if (_invert == value)
                    return;

                _invert = value;
                if (value)
                {
                    Main_TLP.Controls.Clear();
                    Main_TLP.Controls.Add(Login_L, 0, 0);
                    Main_TLP.Controls.Add(ActiveCards_LB, 0, 1);
                    Main_TLP.Controls.Add(PassiveCards_LB, 1, 1);
                    Main_TLP.Controls.Add(Power_L, 0, 2);
                    Main_TLP.Controls.Add(FirstMove_RB, 1, 2);
                }
                else
                {
                    Main_TLP.Controls.Clear();
                    Main_TLP.Controls.Add(Power_L, 0, 0);
                    Main_TLP.Controls.Add(FirstMove_RB, 1, 0);
                    Main_TLP.Controls.Add(ActiveCards_LB, 0, 1);
                    Main_TLP.Controls.Add(PassiveCards_LB, 1, 1);
                    Main_TLP.Controls.Add(Login_L, 0, 2);
                }
            }
        }

        private bool _invert = false;
        private bool _prev_state;
        public Player_Hand()
        {
            InitializeComponent();
            FirstMove_Seted += On_FirstMove_Seted;
        }

        private void On_FirstMove_Seted()
        {
            FirstMove_RB.Checked = false;
        }

        private void FirstMove_RB_MouseUp(object sender, MouseEventArgs e)
        {
            FirstMove_RB.Checked = _prev_state;
        }

        private void FirstMove_RB_MouseDown(object sender, MouseEventArgs e)
        {
            _prev_state = FirstMove_RB.Checked;
        }

        private void ActiveCards_LB_DoubleClick(object sender, EventArgs e)
        {
            string card = ActiveCards_LB.SelectedItem?.ToString()??"";
            Card_Selected?.Invoke(card);
        }
    }
}
