using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using The_Game.Skills;

namespace The_Game.Shop
{
    public static class ItemDatabase
    {
        public static Item FireSkill = new Item("Fire Skill", 10, null, null, SkillDatabase.CloneSkill(SkillDatabase.Fire))
        {
            IsBuy = true 
        };

        public static Item WaterSkill = new Item("Water Skill", 10, null, null, SkillDatabase.CloneSkill(SkillDatabase.Water))
        {
            IsBuy= true
        };

        public static Item EarthSkill = new Item("Earth Skill", 10, null, null, SkillDatabase.CloneSkill(SkillDatabase.Earth))
        {
            IsBuy=(true)
        };

        public static Item AirSkill = new Item("Air Skill", 10, null, null, SkillDatabase.CloneSkill(SkillDatabase.Air))
        {
            IsBuy=(true)
        };


        public static List<Item> AllItems = new List<Item>
        {
            FireSkill, WaterSkill, EarthSkill, AirSkill
        };
    }
}
