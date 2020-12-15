using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniRPGLikeTESO
{
    interface IСreature
    {
        //Атакующие функции
        double WeaponAttack(double weaponDamage);
        void SpendStamina(double spendStamina);
        double MagicAttack(double magicDamage);
        void SpendMana(double spendMana);

        double UltaAttack();

        ///Защищающие функции
        void BeAttacked(double damage, double armor);

        ///Функции расчёта статуса
        void RestoreStamina();
        void RestoreMana();

        string ReturnHealth();
        string ReturnStamina();
        string ReturnMana();
    }
}
