using System;
using StarshitSpeeder.Domain;
namespace StarshitSpeeder
{
    class Program
    {
        static void Main(string[] args)
        {
            Engine golfCarEngine = new Engine(70, "Electric");

            GolfCar golfCar = new GolfCar(
                "Brown",
                "Golf Car Makers",
                "ABc123",
                "White",
                golfCarEngine);

            Engine battlestarEngine = new Engine(500000, "Fusion");

            FlyingShip battleStarGalactica = new FlyingShip(
                "Imperial",
                "ABC124",
                "Poop-Brown",
                battlestarEngine);

            Console.WriteLine();
        }
    }
}
