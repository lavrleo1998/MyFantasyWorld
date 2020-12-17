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
        public long IdBattle { get; set; }
        public string Who { get; set; } 
        public DateTime Time { get; set; }
        public HistoryFight() { }
        public HistoryFight(long idBattle, string who, DateTime time)
        {
            IdBattle = idBattle;
            Who = who;
            Time = time;
        }
    }
}
