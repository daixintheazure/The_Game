using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using The_Game.character;

namespace The_Game.monsters
{
    public abstract class MonsterBase
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int Level { get; set; } = 1;
        public int MaxHealth { get; set; } = 20;
        public int Health { get; set; }

        public MonsterBase(string name) {
            Name = name;
            Health = MaxHealth;
        }

        public void Attack(CharacterBase target)
        {
            target.TakeDamage(1);
            Console.WriteLine($"{this.Name} has attaked {target.Name}!");
           
        }

        public void TakeDamage(int amount, CharacterBase target)
        {
            Health = Health - 1;

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
