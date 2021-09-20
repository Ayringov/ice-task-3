using System;

namespace InheritanceActivity
{
    class Program
    {
        static void Main(string[] args)
        {
            Pickup pickUp = new Pickup();
            HealthPickup healthPickUp = new HealthPickup();
            Console.WriteLine(pickUp);
            Console.WriteLine(healthPickUp);
        }
    }
}
