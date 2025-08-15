using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Game.Skills
{
    public static class SkillDatabase
    {
        //public static ActiveSkill ExampleSkill = new ActiveSkill("Example", true)
        //{
        //    Description = "An example of how to setup a new skill with duel elements.",
        //    Damage = 10,
        //    Element = Elements.ElementTypes.Fire | Elements.ElementTypes.Water
        //};

        public static ActiveSkill Attack = new ActiveSkill("Attack", true)
        {
            Description = "Basic Attck.",
            Damage = 10,
            Element = Elements.ElementTypes.Physical
        };

        public static ActiveSkill Fire = new ActiveSkill("Fire Attack", true)
        {
            Description = "Basic Fire Attck.",
            Damage = 10,
            Element = Elements.ElementTypes.Fire
        };

        public static ActiveSkill Water = new ActiveSkill("Water Attack", true)
        {
            Description = "Basic Water Attck.",
            Damage = 10,
            Element = Elements.ElementTypes.Water
        };

        public static ActiveSkill Earth = new ActiveSkill("Earth Attack", true)
        {
            Description = "Basic Earth Attck.",
            Damage = 10,
            Element = Elements.ElementTypes.Earth
        };

        public static ActiveSkill Air = new ActiveSkill("Air Attack", true)
        {
            Description = "Basic Air Attck.",
            Damage = 10,
            Element = Elements.ElementTypes.Air
        };

        public static SkillBase CloneSkill(SkillBase skill)
        {
            return new SkillBase(skill.Name, skill.IsBasic)
            {
                Description = skill.Description,
                Level = skill.Level,
                FusionChance = skill.FusionChance,
                Damage = skill.Damage,
                Element = skill.Element,
                Family = new List<SkillBase>(skill.Family) 
            };
        }
    }
}
