using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figurki
{
    internal class PointKrug
    {
        public PointOkrug okrug;
        public PointKrug(PointOkrug okrug)
        {
            this.okrug = okrug;
        }
        public double GetSize()
        {
            return Math.PI * Math.Pow(okrug.radius, 2);
        }
    }
}
