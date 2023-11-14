using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figurki
{
    internal class PointShar 
    {
        public PointKrug krug;
        public PointShar(PointKrug krug) 
        {
            this.krug = krug;
        }

        public double GetSize()
        {
            return 4.0 / 3.0 * Math.PI * Math.Pow(krug.okrug.radius, 3);
        }
    }
}
