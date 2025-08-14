using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace The_Game.character.Att
{
    public class AttributesStat
    {
        public string Name { get; set; }
        public int Value { get; set; } = 1;
        public int Experience { get; private set; } = 0;
        private int xpToLevel = 10;

        public AttributesStat(string name)
        {
            Name = name;
        }

        public void GainXP(int amount)
        {
            Experience += amount;
            //Console.WriteLine($"{this.Name} Gained {amount} XP");

            while ( Experience >= xpToLevel )
            {
                //Experience -= amount;
                Value++;
                xpToLevel = (int)(xpToLevel * 1.5);
                //Console.WriteLine($"{this.Name} Attribute increased to: {Value}");
            }
        }
    }
}
