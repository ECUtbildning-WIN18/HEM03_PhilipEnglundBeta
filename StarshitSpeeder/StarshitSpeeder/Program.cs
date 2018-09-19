using System;
using StarshitSpeeder.Domain;
namespace StarshitSpeeder
{
    class Program
    {
        static void Main(string[] args)
        {
            FlyingShip battlestar = new FlyingShip();

            GolfCar golfCar = new GolfCar();

            golfCar.Engine.StartEngine();
            golfCar.Engine.Accelerate();

            battlestar.Engine.StartEngine();
            battlestar.Engine.Accelerate();


            battlestar.FirstOfficer.PickNose();
        }
    }
}
