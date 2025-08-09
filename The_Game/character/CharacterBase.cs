using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using The_Game.character.Att;
using The_Game.Elements;
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
        public ElementTypes Element { get; set; } = ElementTypes.None;
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

        protected CharacterBase(string name, int level) 
        {
            Name = name;
            Level = level;
            Health = MaxHealth;
        }
        public void Attack(CharacterBase target)
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
        public abstract void AttributeGainXP(CharacterBase user, SkillBase skill, int exp);

        public abstract void TakeDamage(int amount, CharacterBase target);

        public abstract void OnDeath(CharacterBase target);

        public void GenMonsterStats(int level)
        {
            this.Attributes.GenValues(level);
            
        }
    }
}
