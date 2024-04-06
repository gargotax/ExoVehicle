using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExoVehicle
{
    public class Vehicle
    {
        public string Marque { get; }
        public string Couleur { get; }
        public Vehicle(string marque, string couleur)
        {
            Marque = marque;
            Couleur = couleur;
        }

        public virtual void Demarrer()
        {

        }
    }
}
