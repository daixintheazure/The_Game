using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using The_Game.character;

namespace The_Game.Shop
{
    public class Shop
    {
        public CharacterBase Character { get; set; }

        public static List<Item> Items { get; set; }

        public Shop(List<Item> initialItems) 
        {
            Items = initialItems;
        }

        public static void DisplayItems()
        {
            Console.WriteLine("Shop");
            foreach (ShopItem item in Items)
            {
                item.Display();
            }
        }

        public static void OpenShop()
        {
            Program.ShopOpen = true;
            bool shopping = true;

            while (shopping)
            {
                Console.Clear();
                Console.WriteLine("shop");
                DisplayItems();
                Console.WriteLine("enter 0 to exit");
                string input = Console.ReadLine();

                if (int.TryParse(input, out int choice))
                {
                    if (choice == 0)
                    {
                        Program.ShopOpen = false;
                        shopping = false;
                    }
                    else
                    {
                        Console.WriteLine("Invalid choice.");
                    }
                }
            }

        }
    }
}
