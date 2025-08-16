using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Game.Utils
{
    public static class GameLogger
    {
        public static void WriteLine(string message)
        {
            if (!Program.ShopOpen)
            { 
                Console.WriteLine(message);
            }
        }
    }
}
