using System;
using StarshitSpeeder.Domain;
namespace StarshitSpeeder
{
    class Program
    {
        static void Main(string[] args)
        {
            Person adama = new Person("Adama", "Commander");


            GolfCar golfCar = new GolfCar
                ("Brown",
                "Golf Car",
                "ABc123",
                "Green", 
                adama,
                new Engine("Yamaha G19", 50));

            FlyingShip battleStarGalactica = new FlyingShip
                ("Battlestar Galactica",
                "ABC124",
                "Green",
                adama,
                new Engine("FTL", 5000));

            battleStarGalactica.StartEngine();
            battleStarGalactica.Accelerate();


            Console.WriteLine();
        }
    }
}
