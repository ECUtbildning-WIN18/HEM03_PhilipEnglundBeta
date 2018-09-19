using System;
using System.Collections.Generic;
using System.Text;

namespace StarshitSpeeder.Domain
{
    class Vehicle
    {
        public Person Owner { get; set; }

        private string Model { get; }

        private string RegistrationNumber { get; }  

        private string Color { get; }

        public Vehicle(Person owner, string model, string registrationNumber, string color)
        {
            Owner = owner;

            Model = model;

            RegistrationNumber = registrationNumber;

            Color = color;
        }
    }
}
