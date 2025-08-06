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
        };

        public static SkillBase CloneSkill(SkillBase skill)
        {
            return new SkillBase(skill.Name, skill.IsBasic)
            {
                Description = skill.Description,
                Level = skill.Level,
                FusionChance = skill.FusionChance,
                Damage = skill.Damage,
                Family = new List<SkillBase>(skill.Family) 
            };
        }
    }
}
