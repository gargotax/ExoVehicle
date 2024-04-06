using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExoVehicle
{
    public class Destination
    {
        public string Name { get; set; }
        public double CoordonneeX { get; set; }
        public double CoordonneeY { get; set; }

        public override string ToString()
        {
            return Name;
        }

        public double Distance(Destination dest1, Destination dest2)
        {
            return Distance(dest1, dest2);
        }
    }

}