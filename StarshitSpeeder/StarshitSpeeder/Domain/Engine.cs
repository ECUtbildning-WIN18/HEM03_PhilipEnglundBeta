using System;
using System.Collections.Generic;
using System.Text;

namespace StarshitSpeeder.Domain
{
    class Engine
    {
        public int SerialNumber { get; }

        public int OutputKiloWatt { get; }
        
        public string Type { get; } 

        public bool EngineOnOff { get; set; } //On/Off

        public int UsingPower { get; set; } = 0;

        public Engine(string type, int outputKiloWatt)
        {
            OutputKiloWatt = outputKiloWatt;

            SerialNumber = new Random(345).Next(100000, 999999);

            Type = type;
        }

    }
}
