using MiniRPGLikeTESO.ArmorClasses;
using MiniRPGLikeTESO.NPCСlasses;
using MiniRPGLikeTESO.WeaponClasses;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniRPGLikeTESO
{
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
            progressBar1.Maximum = Convert.ToInt32(enemy.Health);
            progressBar2.Maximum = Convert.ToInt32(easyEnemy.Health);
            progressBar3.Maximum = Convert.ToInt32(heavyEnemy.Health);
            progressBar4.Maximum = Convert.ToInt32(player.Mana);
            progressBar5.Maximum = Convert.ToInt32(player.Health);
            progressBar6.Maximum = Convert.ToInt32(player.Stamina);
            status();
        }

        Player player = new Player();
        HeavyEnemy heavyEnemy = new HeavyEnemy();
        Enemy enemy = new Enemy();
        EasyEnemy easyEnemy = new EasyEnemy();
        Sword steelSword = new Sword("Стальной мечь", 90, 2);
        Cuirass steelCuirass = new Cuirass("Стальная кираса", 23, 23);


        void status()
        {
            progressBar1.Value = Convert.ToInt32(enemy.Health);
            progressBar2.Value = Convert.ToInt32(easyEnemy.Health);
            progressBar3.Value = Convert.ToInt32(heavyEnemy.Health);
            progressBar4.Value = Convert.ToInt32(player.Mana);
            progressBar5.Value = Convert.ToInt32(player.Health);
            progressBar6.Value = Convert.ToInt32(player.Stamina);
        }
        void check()
        {
            if (heavyEnemy.Health == 0 & easyEnemy.Health == 0 & enemy.Health == 0)
            {
                pictureBox1.Enabled = true;
                pictureBox2.Enabled = true;
                pictureBox3.Enabled = true;
            }
        }

        void Attack(string attackedCreature)
        {
            //Надо заменить магические значения на нормальные. Добавь функцию присвоения предмета персонажу через инвентарь
            if (attackedCreature == "heavyEnemy")
            {
                heavyEnemy.BeAttacked(player.WeaponAttack(steelSword.Damage), steelCuirass.Protection);
                if (heavyEnemy.Health < 0) heavyEnemy.Health = 0;
            }
            if (attackedCreature == "enemy")
            {
                enemy.BeAttacked(player.WeaponAttack(steelSword.Damage), steelCuirass.Protection);
                if (enemy.Health < 0) enemy.Health = 0;
            }
            if (attackedCreature == "easyEnemy")
            {
                easyEnemy.BeAttacked(player.WeaponAttack(steelSword.Damage), steelCuirass.Protection);
                if (easyEnemy.Health < 0) easyEnemy.Health = 0;
            }

            if (attackedCreature == "player")
            {
                player.BeAttacked(heavyEnemy.WeaponAttack(steelSword.Damage), steelCuirass.Protection);
                player.BeAttacked(enemy.WeaponAttack(steelSword.Damage), steelCuirass.Protection);
                player.BeAttacked(easyEnemy.WeaponAttack(steelSword.Damage), steelCuirass.Protection);
            }
            status();
            check();
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Attack("heavyEnemy");
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Attack("enemy");
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Attack("easyEnemy");
        }

        private void NPCAttack()
        {
            Attack("player");
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            var jsonStr = JsonConvert.SerializeObject(player);
            using (FileStream fstream = new FileStream("Player.txt", FileMode.Create))
            {
                byte[] array = System.Text.Encoding.Default.GetBytes(jsonStr);
                await fstream.WriteAsync(array, 0, array.Length);
            }
        }
    }
}
