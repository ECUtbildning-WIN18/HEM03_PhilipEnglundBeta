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

        public Person(string firstName, string lastName)
        {
            Random RandomNumber = new Random(42);

            FirstName = firstName;

            LastName = lastName;

            ImperialSoldierID = RandomNumber.Next(1000, 9999);
        }
    }
}
