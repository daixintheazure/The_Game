using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Game.Shop
{
    public class Item : ShopItem
    {
        public Item(string name, int? cost, int? expCost, string? description) 
            : base(name, cost, expCost, description) { }
    }
}
