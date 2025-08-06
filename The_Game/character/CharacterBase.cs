using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using The_Game.character.Att;
using The_Game.monsters;
using The_Game.Skills;

namespace The_Game.character
{
    public abstract class CharacterBase
    {
        public string Name { get; set; }
        public int Health { get; set; }
        public int MaxHealth { get; set; }
        public int Level { get; set; }
        public int Experience { get; set; }
        public int ToLevel {  get; set; }
        public int Coins { get; set; }
        public Attributes Attributes { get; set; } = new Attributes();
        public List<SkillBase> Skills { get; set; } = new List<SkillBase> { SkillDatabase.CloneSkill(SkillDatabase.Attack) };

        protected CharacterBase(string name, int maxHealth, int level, int experience, int coins)
        {
            Name = name;
            MaxHealth = maxHealth;
            Health = maxHealth;
            Level = level;
            Experience = experience;
            Coins = coins;
            ToLevel = 100;
        }
        public void Attack(MonsterBase target)
        {
            target.TakeDamage(Skills[0].UseSkill(this, target), this);
        }
        public void LevelUp()
        {
            Level += 1;
            Console.WriteLine(this.Name + " has reached level " + Level);
        }
        public abstract void EarnCoins(int amount);

        public void GainExperience(int amount)
        {
            Experience += amount;
            Console.WriteLine(this.Name + " Has gained " + amount + " experiance!");

            if (Experience >= ToLevel)
            {
                LevelUp();
                ToLevel += ToLevel*2;
            }

        }

        public void TakeDamage(int amount)
        {
            Health -= amount;
            Console.WriteLine($"{this.Name} has take {amount} damage!" +
                $"{this.Name} has {this.Health} health remaining.");

            if (Health <= 0)
            {
                Console.WriteLine("You have died!");
                Console.WriteLine("Resetting Health to max");
                Health = MaxHealth;
            }
        }
    }
}
