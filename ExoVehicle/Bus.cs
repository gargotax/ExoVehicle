using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExoVehicle
{
    public class Bus : Vehicle, ILivreur
    {
        public Bus(string marque, string couleur) : base(marque, couleur)
        {
        }

        public override void Demarrer()
        {
            Console.WriteLine("Le bus démarre.");
        }
        public void FaireLivraison(Destination destination)
        {
            throw new NotImplementedException();
        }
    }
}
