using System;
using System.Collections.Generic;
using System.Text;


namespace StarshitSpeeder.Domain
{
    class GolfCar : Vehicle
    {
        public string WheelColor { get; }

        public Person Owner { get; }

        public GolfCar(string wheelColor, string brand, string registrationNumber, string color, Person owner, Engine engine)
        {
            WheelColor = wheelColor;

            Brand = brand;

            RegistrationNumber = registrationNumber;

            Color = color;

            Owner = owner;

            Engine = engine;
        }
     
    }
    class FlyingShip : Vehicle
    {
       public bool HyperDrive { get; set; }
       
        public Person Owner { get; }

        public FlyingShip(string brand, string registrationNumber, string color, Person owner, Engine engine)
        {
            Brand = brand;

            RegistrationNumber = registrationNumber;

            Color = color;

            Owner = owner;

            Engine = engine;
        }
       
    }
}
