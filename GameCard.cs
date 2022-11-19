using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.DirectoryServices.ActiveDirectory;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gold_Flame
{
    public partial class GameCard : UserControl
    {
        public static event Action? Card_Overwrited;

        string _curent_card;
        Card_Data[] _cards;
        public GameCard(Cards_Table table, string first)
        {
            InitializeComponent();
            _cards = new Card_Data[] { new Card_Data(first, 0) };
            _curent_card = "";
            table.Card_Selected += Table_Card_Selected;
            Show_Card();
        }

        private void Show_Card()
        {
            Card_Text.Text = _cards.Last().Title;
        }

        private void Table_Card_Selected(string card)
        {
            _curent_card = card;
            Overwrite_B.Visible = card != "";
        }

        public void Add_Card(Card_Data card)
        {
            _cards = _cards.Append(card).ToArray();
            Show_Card();
        }

        private void Overwrite_B_Click(object sender, EventArgs e)
        {
            Add_Card(new Card_Data(_curent_card, 0));
            Card_Overwrited?.Invoke();
        }
    }
}
