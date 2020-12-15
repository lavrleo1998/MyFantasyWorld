using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MiniRPGLikeTESO;

namespace MiniRPGLikeTESO.NPCСlasses
{
    public abstract class AbstractCreature : IСreature

    {
        public double Health { get; set; }
        public double Stamina { get; set; }
        public double Mana { get; set; }
        public double Damage { get; set; }
        public double Armor { get; set; }

        //Атакующие функции
        public abstract double WeaponAttack(double weaponDamage);
        public abstract void SpendStamina(double spendStamina);
        public abstract double MagicAttack(double magicDamage);
        public abstract void SpendMana(double spendMana);

        public abstract double UltaAttack();

        ///Защищающие функции
        public abstract void BeAttacked(double damage, double armor);

        ///Функции расчёта статуса
        public abstract void RestoreStamina();
        public abstract void RestoreMana();

        public string ReturnHealth() => Convert.ToString(this.Health);
        public string ReturnStamina() => Convert.ToString(this.Stamina);
        public string ReturnMana() => Convert.ToString(this.Mana);
    }
}
