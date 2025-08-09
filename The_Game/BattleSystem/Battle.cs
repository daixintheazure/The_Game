using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using The_Game.character;

namespace The_Game.BattleSystem
{
    public class Battle
    {
        private BattleResult result;
        public Battle() {
            this.result = new BattleResult();
        }

        private void ShowBattleSummary(BattleResult result)
        {
            Console.WriteLine("\n===== Battle Summary =====");
            Console.WriteLine($"Coins Earned: {result.CoinsEarned}");
            Console.WriteLine($"EXP Earned: {result.ExpEarned}");

            if (result.AttributeExpGained.Count > 0)
            {
                Console.WriteLine("Attribute EXP Gains:");
                foreach (var kvp in result.AttributeExpGained)
                {
                    Console.WriteLine($"  {kvp.Key}: {kvp.Value} EXP");
                }
            }
            Console.WriteLine("==========================\n");
        }
        public void Fight(CharacterBase player, CharacterBase monster)
        {
            Console.WriteLine($"You have encountered a level {monster.Level} {monster.Name}");
            while (player.Health > 0 && monster.Health > 0)
            {
                player.Attack(monster);
                monster.Attack(player);
            }
            if (player.Health <= 0)
            {
                Console.WriteLine($"" +
                    $"******************************************************\n" +
                    $"*                                                    *\n" +
                    $"*                  You have die!                     *\n" +
                    $"*                                                    *\n" +
                    $"******************************************************\n");
            }
            
            if (monster.Health <= 0)
            {
                Console.WriteLine($"" +
                    $"******************************************************\n" +
                    $"*                                                    *\n" +
                    $"*                  You have won!                     *\n" +
                    $"*                                                    *\n" +
                    $"******************************************************\n");
                monster.OnDeath(player);
            }
            //ShowBattleSummary(result);
        }
    }
}
