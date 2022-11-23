using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadderProblem
{
    class UC3NoPlay
    {
        public static void NoPlay()
        {
            int position = 0;
            int current_position = 0;
            int start_position = 0;
            const int Winning = 100;
            const int NoPlay = 0;
            const int Ladder = 1;
            const int Snake = 2;
            Random r = new Random();
            while (position < Winning)
            {
                int random = r.Next(1, 7);
                int opt = r.Next(0, 3);
                switch (opt)
                {
                    case NoPlay:
                        Console.WriteLine("You Got No Play");
                        Console.WriteLine("--------------------------");
                        break;
                    case Ladder:
                        position = current_position;
                        if (position < Winning)
                        {
                            current_position = current_position + random;
                            Console.WriteLine("Player Climbed Ladder By:" + random);
                            if (current_position > Winning)
                            {
                                current_position = position;
                            }
                        }
                        break;
                    case Snake:
                        if (current_position > 0)
                        {
                            Console.WriteLine("Player Is Bitten By Snake By:" + random);
                            current_position = current_position - random;
                        }
                        else if (current_position <= 0)
                        {
                            current_position = start_position;
                            current_position = position;
                        }
                        break;
                }
            }

        }
    }
}