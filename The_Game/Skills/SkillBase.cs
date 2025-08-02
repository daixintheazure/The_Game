using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace The_Game.Skills
{
    public class SkillBase
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int Level { get; set; }
        public int FusionChance { get; set; }
        public bool IsBasic { get; set; }

        public int Damage { get; set; }

        public List<SkillBase> family = new List<SkillBase>();
        public SkillBase(string name, int level, bool isBasic) {
            Name = name;
            Level = level;
            IsBasic = isBasic;
        }

        public int genFussionChaance ()
        {
            int percent = 0;

            if (this.IsBasic == true)
            {
                percent = 50;
            }
            else
            {
                percent = 100 / family.Count;
            }

            return percent;
        }

        public int useSkill()
        {

            return Damage;
        }
            

        
    }
}
