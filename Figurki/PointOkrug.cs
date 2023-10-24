using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figurki
{
    internal class PointOkrug : Figura
    {
        public int radius;
        public Point center;

        public PointOkrug(int radius, int coords, int coords2, int coords3) : base(coords, coords2, coords3)
        {
            this.radius = radius;
            center = new Point(coords, coords2, coords3);
        }

        override public double GetSize()
        {
            return 2 * Math.PI * radius;
        }

    }
}
