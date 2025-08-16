using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace The_Game.Shop
{
    public abstract class ShopItem
    {
        private static int nextId = 1;
        public int Id { get; private set; }

        public string Name { get; set; }
        public int? Cost { get; set; }
        public int? ExpCost { get; set; }
        public string? Description { get; set; }

        public bool IsBuy { get; set; }

        public ShopItem(string name, int? cost, int? expCost, string? description) 
        {
            Name = name;
            Cost = cost;
            ExpCost = expCost;
            Description = description;
            Id = nextId++;
        }

        public virtual void Display()
        {
            Console.WriteLine($"[{Id}] {Name}");
            //if (Cost.HasValue)
                Console.WriteLine($"  Gold Cost: {Cost ?? 0}");
            //if (ExpCost.HasValue)
                Console.WriteLine($"  EXP Cost: {ExpCost ?? 0}");
            //if (!string.IsNullOrWhiteSpace(Description))
                Console.WriteLine($"  Description: {Description}");
            Console.WriteLine();
        }
    }
}
