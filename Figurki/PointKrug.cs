using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figurki
{
    internal class PointKrug : Figura
    {
        public PointOkrug okrug;
        public PointKrug(int radius, int coords, int coords2, int coords3) : base(coords, coords2, coords3)
        {
            okrug = new PointOkrug(radius, coords, coords2, coords3);
        }
        override public double GetSize()
        {
            return Math.PI * Math.Pow(okrug.radius, 2);
        }
    }
}
