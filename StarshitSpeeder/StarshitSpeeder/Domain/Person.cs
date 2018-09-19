using System;
using System.Collections.Generic;
using System.Text;

namespace StarshitSpeeder.Domain
{
    class Person
    {
        public string FirstName { get; }

        public string LastName { get; }

        public int ImperialSoldierNumber { get; }

        public bool IsDisgusting { get; set; }

        public Person(string firstName, string lastName)
        {
            FirstName = firstName;

            LastName = lastName;

            ImperialSoldierNumber = new Random().Next(1000, 9999);
        }

        public void PickNose()
        {
            IsDisgusting = true;
        }
    }
}
