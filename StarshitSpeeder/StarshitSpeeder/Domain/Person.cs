using System;
using System.Collections.Generic;
using System.Text;

namespace StarshitSpeeder.Domain
{
    class Person
    {
        public string FirstName { get; }

        public string LastName { get; }

        public int ImperialSoldierID { get; }

        Random RandomNumber = new Random();

        public Person(string firstName, string lastName)
        {
            FirstName = firstName;

            LastName = lastName;

            ImperialSoldierID = RandomNumber.Next(1000, 9999);
        }
    }
}
