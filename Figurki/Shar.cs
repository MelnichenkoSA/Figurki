using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figurki
{
    internal class Shar:Krug
    {
        public Shar(int radius, int coords, int coords2, int coords3) : base(radius, coords, coords2, coords3)
        {

        }

        override public double GetSize()
        {
            return 4.0/3.0 * Math.PI * Math.Pow(radius, 3);
        }
    }
}
