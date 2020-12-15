using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniRPGLikeTESO.WeaponClasses
{
    class Sword : abstractWeapon
    {
        public Sword(string n, double d, int w)
        {
            this.Name = n;
            this.Damage = d;
            this.Weight = w;
        }
    }
}
