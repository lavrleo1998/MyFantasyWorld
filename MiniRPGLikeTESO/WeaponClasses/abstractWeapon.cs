using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniRPGLikeTESO.WeaponClasses
{
    public abstract class abstractWeapon : IWeapon
    {
        public string Name { get; set; }
        public double Damage { get; set; }
        public int Weight { get; set; }

        public virtual double WeaponDamage()
        {
            return Damage;
        }
    }
}
