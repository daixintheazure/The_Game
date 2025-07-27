using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Game.character
{
    public abstract class CharacterBase
    {
        public string Name { get; set; }
        public int Health { get; set; }
        public int Level { get; set; }
        public int Experience { get; set; }
        public int Coins { get; set; }
        protected CharacterBase(string name, int health, int level, int experience, int coins)
        {
            Name = name;
            Health = health;
            Level = level;
            Experience = experience;
            Coins = coins;
        }
        public abstract void Attack(CharacterBase target);
        public abstract void LevelUp();
        public abstract void EarnCoins(int amount);
    }
}
