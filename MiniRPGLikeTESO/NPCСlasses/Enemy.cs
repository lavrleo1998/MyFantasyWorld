using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniRPGLikeTESO.NPCСlasses
{
    public class Enemy : AbstractCreature
    {
        public Enemy()
        {
            this.Health = 200;
            this.Stamina = 150;
            this.Mana = 140;
            this.Damage = 20;
            this.Armor = 20;
        }

        public static Enemy Copy(Enemy enemy)
        {
            var result = new Enemy();
            result.Health = enemy.Health;
            result.Stamina = enemy.Stamina;
            result.Mana = enemy.Mana;
            result.Damage = enemy.Damage;
            result.Armor = enemy.Armor;
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
            this.Mana = 140;
        }
        public override void RestoreStamina()
        {
            this.Stamina = 150;
        }

    }
}
