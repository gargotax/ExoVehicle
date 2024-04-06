using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExoVehicle
{
    internal class Voiture : Vehicle
    {
        public Voiture(string marque, string couleur) : base(marque, couleur)
        {
        }

        public override void Demarrer()
        {
            Console.WriteLine("La voiture démarre.");
        }
    }
}
