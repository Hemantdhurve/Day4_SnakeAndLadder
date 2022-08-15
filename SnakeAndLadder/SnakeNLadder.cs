using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadder
{
    public class SnakeNLadder
    {
        public void SnakeLadder()
        {
            int position1 = 0;
            int dieRoll=0;
            Console.WriteLine("Initial Position of Player 1 is :" + position1 );

            //Random function to roll die 1 to 6
            Random random = new Random();
            dieRoll = random.Next(1,7);                 //range taken from 1 to 7 due to die have 1 to 6 numbers

            Console.WriteLine("Die Roll :" + dieRoll);
            position1=dieRoll;
            Console.WriteLine("Position1 of player after dieRoll is :" + position1);
            Console.ReadLine();

        }
    }

}
