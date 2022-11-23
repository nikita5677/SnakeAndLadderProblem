using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadderProblem
{
    class UC2Roll
    {
        static int RollTheDice(Random rndObject)
        {
            Random dice = new Random();
            int nr = dice.Next(1, 7);
            // if user requests to roll multiple dices how
            // do you make all the rolls random and not the same
            return nr;
        }
        public static void Roll()
        {
            Random rnd = new Random();
            List<int> dices = new List<int>();

            Console.WriteLine("Welcome to the dicegenerator!");


            bool go = true;
            while (go)
            {
                Console.WriteLine("\n\t[1] Roll the dice\n" + "\t[2] Look what you rolled\n");
                Console.Write("\tChoose: ");
                int chose;
                int.TryParse(Console.ReadLine(), out chose);

                switch (chose)
                {
                    case 1:
                        Console.Write("\n\tHow many dices do you want to roll?: ");
                        bool input = int.TryParse(Console.ReadLine(), out int n);

                        if (input)
                        {
                            for (int i = 0; i < n; i++)
                            {
                                dices.Add(RollTheDice(rnd));
                            }
                        }
                        break;
                    case 2:
                        Console.WriteLine("\n\tDices rolled: ");
                        foreach (int dice in dices)
                        {
                            Console.WriteLine("\t" + dice);
                        }
                        break;

                    default:
                        Console.WriteLine("\n\tChoose between 1-2 in the menu.");
                        break;
                }
            }
        }
    }
}