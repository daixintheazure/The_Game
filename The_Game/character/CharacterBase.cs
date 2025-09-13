using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using The_Game.character.Att;
using The_Game.Elements;
using The_Game.monsters;
using The_Game.Skills;
using The_Game.Utils;

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
        public SkillBase[] combatSkills; 

        protected CharacterBase(string name, int maxHealth, int level, int experience, int coins)
        {
            Name = name;
            MaxHealth = maxHealth;
            Health = maxHealth;
            Level = level;
            Experience = experience;
            Coins = coins;
            ToLevel = 100;

            combatSkills = new SkillBase[1];
            combatSkills[0] = Skills[0];


            GenCombatSkillList(level);
            
        }

        protected CharacterBase(string name, int level) 
        {
            Name = name;
            Level = level;
            Health = MaxHealth;

            combatSkills = new SkillBase[1];
            combatSkills[0] = Skills[0];


            GenCombatSkillList(level);
        }

        public void GenCombatSkillList(int level)
        { 
            switch(level)
                {
                case 5:

                    CombatSkillCheckOnLevel();
                    break;

                case 10:
                    CombatSkillCheckOnLevel();
                    break;
                

                case 20:
                    CombatSkillCheckOnLevel();
                    break;
                

                case 40:
                    CombatSkillCheckOnLevel();
                    break;

                default:
                    combatSkills = new SkillBase[1];
                    if (Skills != null)
                    { 
                        combatSkills[0] = Skills[0];
                    }
                    
                    break;
            }

        }

        public SkillBase[] CombatSkillCheckOnLevel()
        { 
            var temp = this.combatSkills;
            var size = temp.Length + 1;

            combatSkills = new SkillBase[size];

            for(int i = 0; i < temp.Length; i++)
            {
                combatSkills[i] = temp[i];
            }

            return combatSkills;
        }
        public void Attack(CharacterBase target)
        {
            target.TakeDamage(combatSkills[0].UseSkill(this, target), this);
        }
        public void LevelUp()
        {
            Level += 1;
            GameLogger.WriteLine(this.Name + " has reached level " + Level);
        }
        public abstract void EarnCoins(int amount);

        public void GainExperience(int amount)
        {
            Experience += amount;
            GameLogger.WriteLine(this.Name + " Has gained " + amount + " experiance!");

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
