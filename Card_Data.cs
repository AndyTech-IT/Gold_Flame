using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gold_Flame
{
    public struct Card_Data
    {
        public readonly string Title;
        public readonly int Plased_Power;
        public Card_Data(string title, int power)
        {
            Title = title;
            Plased_Power = power;
        }
    }
}
