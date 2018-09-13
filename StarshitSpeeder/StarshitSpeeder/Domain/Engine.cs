using System;
using System.Collections.Generic;
using System.Text;

namespace StarshitSpeeder.Domain
{
    class Engine
    {
        public int SerialNumber { get; }

        public int OutputKiloWatt { get; set; } = 50;

        public string Type { get; } 

        Random RandomNumber = new Random();

        public Engine(int outputKiloWatt, string type)
        {
            SerialNumber = RandomNumber.Next(1000000, 9999999);
            OutputKiloWatt = outputKiloWatt;
            Type = type;
        }
    }
}
