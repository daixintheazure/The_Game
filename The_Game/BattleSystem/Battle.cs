using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using The_Game.character;
using The_Game.character.Att;

namespace The_Game.BattleSystem
{
    public class Battle
    {
        
        public Battle() {}

        public void Start(CharacterBase monster)
        {
            Attributes.ResetBattleGains();
            Console.WriteLine($"You have encountered a level {monster.Level} {monster.Name}");
        }

        public void Victory(CharacterBase player, CharacterBase monster)
        {
            Console.WriteLine($"" +
                   $"******************************************************\n" +
                   $"*                                                    *\n" +
                   $"*                  You have won!                     *\n" +
                   $"*                                                    *\n" +
                   $"******************************************************\n");
            monster.OnDeath(player);
            Console.WriteLine(Attributes.GetBattleReport());
            Console.WriteLine($"============================================\n");
        }

        public void Defeat()
        {
            Console.WriteLine($"" +
                    $"******************************************************\n" +
                    $"*                                                    *\n" +
                    $"*                  You have die!                     *\n" +
                    $"*                                                    *\n" +
                    $"******************************************************\n");
        }
        

        public void Fight(CharacterBase player, CharacterBase monster)
        {
            Start(monster);
            while (player.Health > 0 && monster.Health > 0)
            {
                player.Attack(monster);
                monster.Attack(player);
            }
            if (player.Health <= 0)
            {
                Defeat();
            }
            
            if (monster.Health <= 0)
            {
                Victory(player, monster);
            }
            //ShowBattleSummary(result);
        }
    }
}
