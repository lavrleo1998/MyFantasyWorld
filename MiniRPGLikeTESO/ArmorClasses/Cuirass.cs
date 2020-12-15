using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniRPGLikeTESO.ArmorClasses
{
    class Cuirass : abstractArmor
    {
        public Cuirass(string n, double p, int w)
        {
            this.Name = n;
            this.Protection = p;
            this.Weight = w;
        }
    }
}
