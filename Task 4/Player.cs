using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{
    internal class Player
    {
        public string playerName;
        public int level;
        public int health;


        public Player()
        {
            Console.WriteLine("Default constructor has been called");
        }

        public Player(string name, int lvl, int hp)
        {
            playerName = name;
            level = lvl;
            health = hp;
            Console.WriteLine("Parameterized constructor has been called");
        }
    }
}
