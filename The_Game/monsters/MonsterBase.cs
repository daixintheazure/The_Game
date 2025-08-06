using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using The_Game.character;
using The_Game.Elements;
using The_Game.Skills;

namespace The_Game.monsters
{
    public abstract class MonsterBase
    {
        public string Name { get; set; }
        public string? Description { get; set; }
        public int Level { get; set; } = 1;
        public int MaxHealth { get; set; } = 20;
        public int Health { get; set; }
        public List<ElementTypes> Elements { get; set; } = new List<ElementTypes> { ElementTypes.None };
        public List<SkillBase> Skills { get; set; } = new List<SkillBase> { SkillDatabase.CloneSkill(SkillDatabase.Attack) };

        public MonsterBase(string name) {
            Name = name;
            Health = MaxHealth;
        }

        public void Attack(CharacterBase target)
        {
            target.TakeDamage(Skills[0].useSkill());
            Console.WriteLine($"{this.Name} has attaked {target.Name}!");
           
        }

        public void TakeDamage(int amount, CharacterBase target)
        {
            Health = Health - amount;

            if(Health <= 0)
            {
                OnDeath(target);
            }
        }

        public void OnDeath(CharacterBase target)
        {
            target.GainExperience(50);
            target.EarnCoins(10);
        }
    }
}
