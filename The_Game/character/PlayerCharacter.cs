using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using The_Game.monsters;
using The_Game.Skills;

namespace The_Game.character
{
    public class PlayerCharacter : CharacterBase
    {
        public PlayerCharacter(string name, int health, int level, int experience, int coins)
            : base(name, health, level, experience, coins)
        { 
        
        }
        
        public override void EarnCoins(int amount)
            {
            this.Coins += amount;
            Console.WriteLine($"{this.Name} now has {this.Coins} coins.");
            }

        public override void OnDeath(CharacterBase target)
        {
            throw new NotImplementedException();
        }

        public override void AttributeGainXP(CharacterBase user, SkillBase skill, int exp)
        {
            user.Attributes.GainXPFor(skill.Element, exp);
        }

       

        public override void TakeDamage(int amount, CharacterBase target)
        {
            Health -= amount;
            Console.WriteLine($"{this.Name} has take {amount} damage!" +
                $"{this.Name} has {this.Health} health remaining.");

            if (Health <= 0)
            {
                //Console.WriteLine("You have died!");
                //Console.WriteLine("Resetting Health to max");
                //Health = MaxHealth;
            }
        }



    }

        
}


