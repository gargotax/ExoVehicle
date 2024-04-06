using System.Security.Cryptography.X509Certificates;

namespace ExoVehicle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Destination destination = new Destination();

            Voiture voiture = new Voiture("fiat", "bleue");
            voiture.Demarrer();
            Taxi taxi = new Taxi("taxi", "rouge");
            taxi.Demarrer();
            Bus bus = new Bus("bus", "jaune");
            bus.Demarrer();
            bus.FaireLivraison(destination.CoordonneeX);

        }
    }
}
