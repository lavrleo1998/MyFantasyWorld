using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniRPGLikeTESO.ArmorClasses
{
    class abstractArmor : IArmor
    {
        public string Name { get; set; }
        public double Protection { get; set; }
        public int Weight { get; set; }

        public virtual double ProtectionDamage()
        {
            return Protection;
        }
    }
}
