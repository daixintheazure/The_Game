using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using The_Game.character;
using The_Game.Skills;

namespace The_Game.Shop
{
    
    public class Item : ShopItem
    {
        public SkillBase? UnlockSkill {  get; set; }
        public Item(string name, int? cost, int? expCost, string? description, SkillBase? unlockSkill = null)
            : base(name, cost, expCost, description)
        {
            UnlockSkill = unlockSkill;
        }

    }
}

