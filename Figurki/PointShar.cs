using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figurki
{
    internal class PointShar : Figura
    {
        public PointKrug krug;
        public PointShar(int radius, int coords, int coords2, int coords3) : base(coords, coords2, coords3)
        {
            krug = new PointKrug(radius, coords, coords2, coords3);
        }

        override public double GetSize()
        {
            return 4.0 / 3.0 * Math.PI * Math.Pow(krug.okrug.radius, 3);
        }
    }
}
