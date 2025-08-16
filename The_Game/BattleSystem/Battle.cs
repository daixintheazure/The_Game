using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using The_Game.character;
using The_Game.character.Att;
using The_Game.Utils;

namespace The_Game.BattleSystem
{
    public class Battle
    {
        
        public Battle() {}

        public void Start(CharacterBase monster)
        {
            Attributes.ResetBattleGains();
            GameLogger.WriteLine($"You have encountered a level {monster.Level} {monster.Name}");
        }

        public void Victory(CharacterBase player, CharacterBase monster)
        {
            GameLogger.WriteLine($"" +
                   $"******************************************************\n" +
                   $"*                                                    *\n" +
                   $"*                  You have won!                     *\n" +
                   $"*                                                    *\n" +
                   $"******************************************************\n");
            monster.OnDeath(player);
            GameLogger.WriteLine(Attributes.GetBattleReport());
            GameLogger.WriteLine($"============================================\n");
        }

        public void Defeat()
        {
            GameLogger.WriteLine($"" +
                    $"******************************************************\n" +
                    $"*                                                    *\n" +
                    $"*                  You have die!                     *\n" +
                    $"*                                                    *\n" +
                    $"******************************************************\n");
            GameLogger.WriteLine(Attributes.GetBattleReport());
            GameLogger.WriteLine($"==============================================\n");
        }
        

        public void Fight(CharacterBase player, CharacterBase monster)
        {
            Start(monster);
            while (player.Health > 0 && monster.Health > 0)
            {
                player.Attack(monster);
                if (monster.Health <= 0)
                {
                    Victory(player, monster);
                    break;
                }
                
                monster.Attack(player);
                if (player.Health <= 0)
                {
                    Defeat();
                    player.Health = player.MaxHealth;
                    break;
                }
            }
            
            
            
            //ShowBattleSummary(result);
        }
    }
}
