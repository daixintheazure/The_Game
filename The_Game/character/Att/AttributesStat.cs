using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Game.character.Att
{
    public class AttributesStat
    {
        public int Value { get; set; } = 1;
        public int Experience { get; private set; } = 0;
        private int xpToLevel = 10;

        public void GainXP(int amount)
        {
            Experience += amount;
            Console.WriteLine($"Gained {amount} XP");

            while ( Experience >= xpToLevel )
            {
                Experience -= amount;
                Value++;
                xpToLevel = (int)(xpToLevel * 1.5);
                Console.WriteLine($"Attribute increased to: {Value}");
            }
        }
    }
}
