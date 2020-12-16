using MiniRPGLikeTESO.NPCСlasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniRPGLikeTESO
{
    public class HistoryFight
    {
        public long Id { get; set; }
        public Player Player { get; set; }
        public Enemy Enemy { get; set; }
        public HeavyEnemy HeavyEnemy { get; set; }
        public EasyEnemy EasyEnemy { get; set; }

        public HistoryFight() { }
        public HistoryFight(long id, Player player, Enemy enemy, HeavyEnemy heavyEnemy, EasyEnemy esyEnemy)
        {
            Id = id;
            Player = player;
            Enemy = enemy;
            HeavyEnemy = heavyEnemy;
            EasyEnemy = esyEnemy;
        }
    }
}
