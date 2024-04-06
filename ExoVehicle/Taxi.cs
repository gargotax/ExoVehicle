using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExoVehicle
{
    public class Taxi : Vehicle, ILivreur
    {
        public Taxi(string marque, string couleur) : base(marque, couleur)
        {
        }

        public override void Demarrer()
        {
            Console.WriteLine("Le taxi démarre.");
        }

        public void FaireLivraison(Destination destination)
        {
            throw new NotImplementedException();
        }
    }
}
