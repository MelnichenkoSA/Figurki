using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figurki
{
    internal class PointOkrug 
    {
        public int radius;
        public Point center;

        public PointOkrug(int radius, Point center) 
        {
            this.radius = radius;
            this.center = center;
        }

        public double GetSize()
        {
            return 2 * Math.PI * radius;
        }

    }
}
