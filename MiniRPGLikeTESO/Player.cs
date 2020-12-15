using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniRPGLikeTESO.NPCСlasses
{
    public class Player : AbstractCreature
    {
        public Player()
        {
            this.Health = 100;
            this.Stamina = 100;
            this.Mana = 100;
            this.Damage = 10;
            this.Armor = 10;
        }

        public override void BeAttacked(double damage, double armor)
        {
            if (damage>armor)
            {
                this.Health -= damage - armor;
            }
        }
        public override double UltaAttack()
        {
            return 100;
        }
        public override double WeaponAttack(double weaponDamage)
        {
            return weaponDamage;
        }
        public override double MagicAttack(double magicDamage)
        {
            return magicDamage;
        }
        public override void SpendMana(double spendMana)
        {
            this.Mana -= 10;
        }
        public override void SpendStamina(double spendStamina)
        {
            this.Stamina -= 10;
        }
        public override void RestoreMana()
        {
            this.Mana = 100;
        }
        public override void RestoreStamina()
        {
            this.Stamina = 100;
        }

    }
}
