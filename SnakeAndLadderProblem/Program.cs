using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadderProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            UC1Position.Position();
            Console.ReadLine();

            UC2Roll.Roll();
            Console.ReadLine();

            UC3NoPlay.NoPlay();
            Console.ReadLine();

            UC4Repeat.Repeat();
            Console.ReadLine();

            UC5Winning.Winning();
            Console.ReadLine();

            UC6Report.Report();
            Console.ReadLine();

            UC7TwoPlayer.TwoPlayer();
            Console.ReadLine();
        }
    }
}