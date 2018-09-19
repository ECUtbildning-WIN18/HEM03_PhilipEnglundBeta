using System;
using System.Collections.Generic;
using System.Text;

namespace StarshitSpeeder.Domain
{
    class Engine
    {
        public int SerialNumber { get; } 

        public string Type { get; }

        public int EngineOutput { get; }

        public int UsingEngineOutput { get; internal set; } 

        public bool IsOn { get; set; } 

        public Engine(string type, int engineOutput)
        {
            SerialNumber = new Random().Next(10000, 99999);

            Type = type;

            EngineOutput = engineOutput;
        }

        public void StartEngine()
        {
            IsOn = true;
        }

        public void StopEngine()
        {
            IsOn = false;
        }

        public virtual void Accelerate()
        {
            if (IsOn)
                UsingEngineOutput = EngineOutput;
        }

    }
}
