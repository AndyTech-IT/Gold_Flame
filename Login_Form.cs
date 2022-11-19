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
    public partial class Login_Form : Form
    {
        public string Login { get; private set; }
        public string Password { get; private set; }

        public Login_Form()
        {
            InitializeComponent();
            Login = "";
            Password = "";
        }

        public DialogResult Show_Login(string login)
        {
            Name_TB.Text = login;
            DialogResult = DialogResult.None;

            return ShowDialog();
        }

        private void Submit_B_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Login = Name_TB.Text;
            Password = Password_TB.Text;

            Close();
        }

        private void Login_Form_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (DialogResult == DialogResult.OK)
                return;
            DialogResult = DialogResult.Cancel;
        }
    }
}
