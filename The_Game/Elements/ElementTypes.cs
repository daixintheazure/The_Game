using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Game.Elements
{
    [Flags]
    public enum ElementTypes
    {
        None = 0,
        Fire = 1 << 0,
        Water = 1 << 1,
        Earth = 1 << 2,
        Air = 1 << 3,
        Light = 1 << 4,
        Dark = 1 << 5,
        Physical = 1 << 6
    }
}
