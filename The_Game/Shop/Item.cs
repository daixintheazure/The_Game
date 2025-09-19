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
        public Item(string name, int? cost, int? expCost, string? description)
            : base(name, cost, expCost, description) { }


        public SkillBase Skill { get; set; }

        public override void Buy(PlayerCharacter player)
        {
            player.Skills.Add(Skill);
        }
    }
}

