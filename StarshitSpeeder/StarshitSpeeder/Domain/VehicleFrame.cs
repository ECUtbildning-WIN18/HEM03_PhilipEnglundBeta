using System;
using System.Collections.Generic;
using System.Text;

namespace StarshitSpeeder.Domain
{
    class Vehicle
    {
        public string Brand { get; protected set; }

        public string RegistrationNumber { get; protected set; }

        public string Color { get; protected set; }

        private string CoffeeHolder = "A holder for your Coffee";

        public Engine Engine { get; protected set; }

        public void StartEngine()
        {
            Engine.EngineOnOff = true;
        }

        public void StopEngine()
        {
            Engine.EngineOnOff = false;
        }

        public void Accelerate()
        {
            if (Engine.EngineOnOff)
                Engine.UsingPower += Engine.OutputKiloWatt;
        }
        
    }
}
