using Microsoft.VisualBasic;
using System;
using The_Game.character;

public class Program
{

    //static int coins = 0;
    //static int coinsPerTick = 1;
    //static int upgradeCost = 10;
    static bool running = true;

    static PlayerCharacter dai = new PlayerCharacter("Dai Xin", 100, 1, 0, 0);
    

    public static async Task Main()
    {
        Task generator = PassiveIncome();
        

        while (running)
        {
            string input = Console.ReadLine()?.Trim().ToLower();

            if (input == "buy")
            {
                //if (coins >= upgradeCost)
                //{
                //    coins -= upgradeCost;
                //    coinsPerTick += 1;
                //    upgradeCost += 5;
                //    Console.WriteLine($"Upgrade purchased! Coins/tick: {coinsPerTick}, Next upgrade cost: {upgradeCost}");
                //}
                //else
                //{
                //    Console.WriteLine($"Not enough coins. You have {coins}, but need {upgradeCost}.");
                //}
            }
            else if (input == "exit")
            {
                running = false;
            }
            else
            {
                Console.WriteLine("Unknown command. Try 'buy' or 'exit'.");
            }
        }

        Console.WriteLine("Thanks for playing!");
    }



    static async Task PassiveIncome()
    {
        while (running)
        {
            await Task.Delay(2000);
            //dai.EarnCoins(1);
            dai.GainExperience(50);
            Console.WriteLine("dai gained a coin!");
        }

    }
}
