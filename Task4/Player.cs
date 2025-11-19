using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    internal class Player
    {
        // creating instance fields
        public string? playerName;
        public int level;
        public string? health;


        // creating default constructor
        public Player()
        { 
            Console.WriteLine("Default Constructor has been called");
        }

        // creating parameterized constructor
        public Player(string playerName, int level, string health)
        { 
            this.playerName = playerName;
            this.level = level;
            this.health = health;
        }
    }
}
