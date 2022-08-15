using System;

namespace SnakeAndLadder
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Snake and Ladder Problem");

            //method is non-static so we need to instantiate method
            SnakeNLadder obj=new SnakeNLadder();
            obj.SnakeLadder();

        }
    }
}