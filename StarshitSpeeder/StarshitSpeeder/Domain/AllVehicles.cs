using System;
using System.Collections.Generic;
using System.Text;


namespace StarshitSpeeder.Domain
{
    class GolfCar : Vehicle
    {
        public Engine Engine { get; }

        public GolfCar() : base(new Person("Adama", "Commander"), "Golf Car", "ATH960", "Green")
        {
            Engine = new Engine("Yamaha G19", 70);
        }
    }
    class FlyingShip : Vehicle
    {
        public Engine Engine { get; }

        public Person FirstOfficer { get; }

        public FlyingShip() : base(new Person("Adama", "Commander"), "Battlestar Galactica", "GHX470", "Green")
        {
            Engine = new Engine("FTL", 5000);
            FirstOfficer = new Person("Han", "Solo");
        }
    }
}
