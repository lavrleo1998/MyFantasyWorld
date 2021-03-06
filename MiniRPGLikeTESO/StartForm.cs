﻿using MiniRPGLikeTESO.ArmorClasses;
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
using MiniRPGLikeTESO.Storages;

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
            Status();
        }

        Player player = new Player();
        HeavyEnemy heavyEnemy = new HeavyEnemy();
        Enemy enemy = new Enemy();
        EasyEnemy easyEnemy = new EasyEnemy();
        Sword steelSword = new Sword("Стальной мечь", 90, 2);
        Cuirass steelCuirass = new Cuirass("Стальная кираса", 23, 23);
        List<HistoryFight> historyFightsList = new List<HistoryFight>();
                
        void Attack(string attackedCreature)
        {
            //Надо заменить магические значения на нормальные. Добавь функцию присвоения предмета персонажу через инвентарь
            if (attackedCreature == "heavyEnemy")
            {
                heavyEnemy.BeAttacked(player.WeaponAttack(steelSword.Damage), steelCuirass.Protection);
                if (heavyEnemy.Health <= 0)
                {
                    heavyEnemy.Health = 0;
                    History("heavyEnemy");
                }
            }
            if (attackedCreature == "enemy")
            {
                enemy.BeAttacked(player.WeaponAttack(steelSword.Damage), steelCuirass.Protection);
                if (enemy.Health <= 0)
                {
                    enemy.Health = 0;
                    History("enemy");
                }
            }
            if (attackedCreature == "easyEnemy")
            {
                easyEnemy.BeAttacked(player.WeaponAttack(steelSword.Damage), steelCuirass.Protection);
                if (easyEnemy.Health <= 0)
                {
                    easyEnemy.Health = 0;
                    History("easyEnemy");
                }
            }
            if (attackedCreature == "player")
            {
                player.BeAttacked(heavyEnemy.WeaponAttack(steelSword.Damage), steelCuirass.Protection);
                player.BeAttacked(enemy.WeaponAttack(steelSword.Damage), steelCuirass.Protection);
                player.BeAttacked(easyEnemy.WeaponAttack(steelSword.Damage), steelCuirass.Protection);
                if (player.Health <= 0)
                {
                    player.Health = 0;
                    History("player");
                }
            }
            
            Status();
        }
        void History(string who)
        {
            var history = new HistoryFight()
            {
                IdBattle = 1,
                Time = DateTime.Now,
                Who = who
            };
            Storage.Save(history);
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
        private void Button2_Click(object sender, EventArgs e)
        {
            HistoriForm HistoryForm = new HistoriForm();
            HistoryForm.Show();
        }
        void Status()
        {
            progressBar1.Value = Convert.ToInt32(enemy.Health);
            progressBar2.Value = Convert.ToInt32(easyEnemy.Health);
            progressBar3.Value = Convert.ToInt32(heavyEnemy.Health);
            progressBar4.Value = Convert.ToInt32(player.Mana);
            progressBar5.Value = Convert.ToInt32(player.Health);
            progressBar6.Value = Convert.ToInt32(player.Stamina);
        }
    }
}
