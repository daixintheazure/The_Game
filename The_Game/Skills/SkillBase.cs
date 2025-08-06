using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using The_Game.character;
using The_Game.Elements;
using The_Game.monsters;

namespace The_Game.Skills
{
    public class SkillBase
    {
        public string Name { get; set; }
        public string? Description { get; set; }
        public int Level { get; set; } = 0;
        public int FusionChance { get; set; }
        public bool IsBasic { get; set; }
        public int Damage { get; set; }
        public ElementTypes Element { get; set; } = ElementTypes.None;
        public List<SkillBase> Family = new List<SkillBase>();


        public SkillBase(string name, bool isBasic) {
            Name = name;
            IsBasic = isBasic;
        }

        public int genFusionChance ()
        {
            int percent = 0;

            if (this.IsBasic == true)
            {
                percent = 50;
            }
            else
            {
                percent = 100 / Family.Count;
            }

            return percent;
        }

        public int UseSkill(CharacterBase user , MonsterBase target)
        {
            Damage = user.Attributes.GetValue(Element) + (user.Level / 10);
            user.Attributes.GainXPFor(Element, 1);
            Console.WriteLine($"{user.Name} has dealt {Damage} to {target.Name}");
            return Damage;
        }

        public int UseSkill(MonsterBase user, CharacterBase target)
        { 
            Damage = user.Attributes.GetValue(Element) + (user.Level / 10);
            return Damage;
        }
            

        
    }
}
