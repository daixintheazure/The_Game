using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using The_Game.Elements;

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

        public int useSkill()
        {

            return Damage;
        }
            

        
    }
}
