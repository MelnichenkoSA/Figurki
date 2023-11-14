using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figurki
{
    internal class Point : Figura
    {

        public Point ( int coords, int coords2, int coords3) : base ( coords, coords2, coords3)
        {    
            Name = "Точка";
        }

        override public double GetSize()
        { 
            return 0; 
        }
    }
}
