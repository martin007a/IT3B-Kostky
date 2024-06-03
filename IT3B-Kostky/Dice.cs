using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IT3B_Kostky
{
    public class Dice
    {
        public int Hodit { get; set; }

        public Dice()
        { 
            Random random = new Random();
            Hodit = random.Next(1,7);
        }
    }
}
