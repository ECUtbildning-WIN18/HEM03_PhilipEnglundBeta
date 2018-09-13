using System;
using System.Collections.Generic;
using System.Text;


namespace StarshitSpeeder.Domain
{
    class GolfCar : Vehicle
    {
        public string WheelColor { get; }

        public GolfCar(string wheelColor, string brand, string registrationNumber, string color, Engine engine)
        {
            Brand = brand;

            RegistrationNumber = registrationNumber;

            Color = color;

            Engine = engine;

            WheelColor = wheelColor;
        }
    }
    class FlyingShip : Vehicle
    {
       public bool HyperDrive { get; set; }
       
        public Person Owner { get; }

        public FlyingShip(string brand, string registrationNumber, string color, Engine engine, Person owner)
        {
            Brand = brand;

            RegistrationNumber = registrationNumber;

            Color = color;

            Engine = engine;

            Owner = owner;
        }

    }
}
