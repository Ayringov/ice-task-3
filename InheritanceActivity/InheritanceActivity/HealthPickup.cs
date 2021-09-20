using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceActivity
{
    class HealthPickup : Pickup
    {
        private int hpBoost = 10;

        public int HpBoost()
        {
            get{ return hpBoost; }
        }
    }
}
