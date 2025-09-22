using Microsoft.VisualBasic;
using System;
using The_Game.BattleSystem;
using The_Game.character;
using The_Game.monsters;
using The_Game.Shop;

public class Program
{

    //static int coins = 0;
    //static int coinsPerTick = 1;
    //static int upgradeCost = 10;
    static bool running = true;

    static PlayerCharacter dai = new PlayerCharacter("Dai Xin", 100, 1, 0, 0);
    //static SmallMonster slime = new SmallMonster("Slime", dai.Level);
    static Battle Battle = new Battle();
    
    public static bool ShopOpen = false;
    

    public static async Task Main()
    {
        Task generator = StartGame();
        GameShop shop = new GameShop (dai, ItemDatabase.AllItems);

        while (running)
        {
            string input = Console.ReadLine()?.Trim().ToLower();

            if (input == "shop")
            {
                shop.OpenShop();   
                
            }
            else if (input == "exit")
            {
                running = false;
            }
            else
            {
                Console.WriteLine("Unknown command. Try 'shop' or 'exit'.");
            }
        }

        Console.WriteLine("Thanks for playing!");
    }



    static async Task StartGame()
    {
        //SmallMonster slime = new SmallMonster("Slime", dai.Level);
        while (running)
        {
            
            await Task.Delay(2000);
            Battle.Fight(dai,  new SmallMonster("Slime", dai.Level));
        }

    }
}
