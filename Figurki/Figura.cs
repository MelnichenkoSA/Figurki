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
        public int x;
        public int y;
        public int z;

        public Figura (string name, int coords, int coords2) 
        {

        }
        public Figura(int coords, int coords2, int coords3)
        {
            x = coords;
            y = coords2;
            z = coords3;
        }
        virtual public double GetSize()
        {
            return 0;
        }
    }
}
