using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figurki
{
    internal class Point : Figura
    {
        public string Name;
        public int[] Coords = { 0, 0 };

        public Point (int coords, int coords2)
        {
            Coords = { coords, coords2 };
            Name = "Точка";
        }

        override public int GetSize()
        { 
            return 0; 
        }
    }
}
