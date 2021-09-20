using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceActivity
{
    class Pickup
    {
        private int x;
        private int y;
        private bool isPickedUp;
        public Pickup(int x, int y)
        {
            Random random = new Random();


            x = random.Next(0, 10);
            y = random.Next(0, 10);


            isPickedUp = false;
        }

        public bool IsPickedUp()
        {


            get{ return isPickedUp; }

        }
    }
}
