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

        public List<ShopItem> Items { get; set; }

        public Shop() { }
    }
}
