using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniRPGLikeTESO.NPCСlasses
{
    public class HeavyEnemy : AbstractCreature
    {
        public HeavyEnemy()
        {
            this.Health = 300;
            this.Stamina = 180;
            this.Mana = 170;
            this.Damage = 30;
            this.Armor = 30;
        }

        public static HeavyEnemy Copy(HeavyEnemy heavyEnemy)
        {
            var result = new HeavyEnemy();
            result.Health = heavyEnemy.Health;
            result.Stamina = heavyEnemy.Stamina;
            result.Mana = heavyEnemy.Mana;
            result.Damage = heavyEnemy.Damage;
            result.Armor = heavyEnemy.Armor;
            return result;
        }

        public override void BeAttacked(double damage, double armor)
        {
            this.Health -= damage - armor;
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
            this.Mana = 170;
        }
        public override void RestoreStamina()
        {
            this.Stamina = 180;
        }

    }
}
