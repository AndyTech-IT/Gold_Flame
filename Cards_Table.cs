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
    public partial class Cards_Table : UserControl
    {
        public event Action<string>? Card_Selected;

        [Category("Game"), Description("Placement card")]
        public string Curent_Card
        {
            get => _curent_card;
            set
            {
                Card_Selected?.Invoke(value);
                Add_Left_B.Visible = Add_Right_B.Visible = value != "";
                _curent_card = value;
            }
        }

        [Category("Game"), Description("Card width")]
        public int Card_Width
        {
            get;set;
        }

        private string _curent_card;
        private GameCard[] _cards;
        const int _side_width = 100;

        public Cards_Table()
        {
            InitializeComponent();
            _curent_card = "";
            _cards = new GameCard[0];
            GameCard.Card_Overwrited += GameCard_Card_Overwrited;
        }

        private void GameCard_Card_Overwrited()
        {
            Curent_Card = "";
        }

        private void Add_Right_B_Click(object sender, EventArgs e)
        {
            GameCard card = new GameCard(this, Curent_Card);
            _cards = _cards.Append(card).ToArray();
            Curent_Card = "";
            Chainge_Table();
        }

        private void Add_Left_B_Click(object sender, EventArgs e)
        {
            GameCard card = new GameCard(this, Curent_Card);
            _cards = new[] { card }.Concat(_cards).ToArray();
            Curent_Card = "";
            Chainge_Table();
        }

        private void Chainge_Table()
        {
            Cards_TLP.Controls.Clear();
            Cards_TLP.ColumnStyles.Clear();
            Cards_TLP.ColumnCount++;

            Cards_TLP.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, _side_width));
            Cards_TLP.Controls.Add(Add_Left_B, 0, 0);

            for (int i = 0; i < _cards.Length; i++)
            {

                Cards_TLP.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, Card_Width));
                Cards_TLP.Controls.Add(_cards[i], i + 1, 0);
            }

            Cards_TLP.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, _side_width));
            Cards_TLP.Controls.Add(Add_Right_B, _cards.Length + 1, 0);
        }
    }
}
