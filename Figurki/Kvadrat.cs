using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figurki
{
    internal class Kvadrat : Figura
    {
        public string Name;
        public int[,] Coords = { { 0, 0 }, { 0, 0 } };

        public Kvadrat(int coords, int coords2)
        {
            Coords[0,0] = coords;
            Coords[0,1] = coords2;
            Name = "Линия";
        }

        override public int GetSize()
        {
            return Coords[1] - Coords[0];
        }
    }
}
