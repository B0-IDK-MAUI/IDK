using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fallabda_javitott
{
    internal class Player
    {
        public string Name { get; set; }
        public string Point { get; set; }
       
        public string Level { get; set; }

        public string Time { get; set; }

        public Player(string name, string point, string time, string level)
        {
            Name = name;
            Point = point;
            Level = level;
            Time = time;
        }
    }
}
