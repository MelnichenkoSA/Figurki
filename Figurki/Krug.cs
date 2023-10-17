using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figurki
{
    internal class Krug : Okrug
    {
        public Krug(int radius, int coords, int coords2, int coords3) : base(radius,coords, coords2, coords3)
        {

        }
        override public double GetSize()
        {
            return Math.PI * Math.Pow(radius, 2);
        }
    }
}
