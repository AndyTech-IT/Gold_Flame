using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gold_Flame.Assets
{
    public abstract class Inactive_Card
    {
        public int Power { get; private set; }
        public bool Actived { get; private set; }

        public void Update()
        {
            if (Actived == false)
                Power++;
            else
                On_Update();
        }

        public int Activate()
        {
            int power = Power + On_Activated();
            Power = 0;
            return power;
        }

        public int Destroy()
        {
            On_Destroed();
            return 1;
        }

        public Inactive_Card()
        {
            Power = 1;
            Actived = false;
        }

        protected abstract int On_Activated();
        protected abstract int On_Destroed();
        protected abstract int On_Update();
    }
}
