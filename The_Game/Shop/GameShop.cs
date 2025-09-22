using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using The_Game.character;

namespace The_Game.Shop
{
    public class GameShop
    {
        public CharacterBase _character { get; set; }

        public List<Item> Items { get; set; }

        public GameShop(CharacterBase character, List<Item> initialItems) 
        {
            _character = character;
            Items = initialItems;
        }

        public void DisplayItems()
        {
            Console.WriteLine("=== Shop ===");
            foreach (ShopItem item in Items)
            {
                if (item.IsBuy == true)
                { 
                    item.Display();
                }
                
            }
        }

        public void OpenShop()
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
                        var item = Items.FirstOrDefault(i => i.Id == choice);
                        if (item != null && item.IsBuy)
                        {
                            BuyItem(item);
                        }
                        else
                        {
                            Console.WriteLine("Invalid Choice");
                            Console.ReadKey();
                        }
                    
                    }
                }
            }

        }

        private void BuyItem(Item item)
        {
            if (item.Cost.HasValue && _character.Coins >= item.Cost.Value)
            {
                _character.Coins -= item.Cost.Value;

                if (item.UnlockSkill != null)
                {
                    _character.Skills.Add(item.UnlockSkill);
                    Console.WriteLine($"{_character.Name} learned {item.UnlockSkill.Name}!");
                }

                Console.WriteLine($"{_character.Name} bought {item.Name} for {item.Cost} coins.");
            }
            else
            {
                Console.WriteLine("Not enough coins!");
            }

            Console.ReadKey();
        }
    }
}
