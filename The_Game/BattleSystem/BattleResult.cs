using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using The_Game.Elements;

namespace The_Game.BattleSystem
{
    public class BattleResult
    {
        public int CoinsEarned {  get; set; }
        public int ExpEarned { get; set; }
        public Dictionary<ElementTypes, int> AttributeExpGained { get; set; } = new();

        public void AddAttributeExp(ElementTypes type, int exp)
        {
            if(!AttributeExpGained.ContainsKey(type))
                AttributeExpGained[type] = 0;
            
            AttributeExpGained[type] += exp;

        }
    }
}
