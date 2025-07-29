using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace The_Game.character
{
    public class PlayerCharacter : CharacterBase
    {
        public PlayerCharacter(string name, int health, int level, int experience, int coins)
            : base(name, health, level, experience, coins)
        { 
        
        }
        public override void Attack(CharacterBase target)
            {
                throw new NotImplementedException();
            }

        public override void EarnCoins(int amount)
            {
            this.Coins += 1;
            Console.WriteLine($"{this.Name} now has {this.Coins} coins.");
            }

        public override void LevelUp()
        {
            throw new NotImplementedException();
        }
        
       
            
    }

        
}


