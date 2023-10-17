using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figurki
{
    internal class Figura
    {
        public string Name;
        public int[] Coords;

        virtual public int GetSize()
        {
            return 0;
        }
    }
}
