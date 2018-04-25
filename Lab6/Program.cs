using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Welcome to the Grand Circus Casino! Roll the dice? (y/n): ");
                string Continue = Console.ReadLine().ToUpper();

                if(Continue== "N")
                {
                    break;
                }
                else if (Continue == "Y")
                {
                    while (true)
                    {
                        Console.WriteLine("How many slides should each die have?");
                        string dieSides = Console.ReadLine();

                        bool conv = int.TryParse(dieSides, out int sides);

                        if (!conv)
                        {
                            Console.WriteLine("\nInvalid input, Please try again\n");
                            continue;
                        }
                        Console.WriteLine("Roll Results Below");
                        if (conv)
                        {
                            Random random = new Random();

                            int dice1 = random.Next(1, sides);
                            Console.WriteLine($"Dice 1 landed {dice1}");

                            int dice2 = random.Next(1, sides);
                            Console.WriteLine($"Dice 2 landed {dice2}");

                            int sum = dice1 + dice2;

                            if(dice1 == 1 && dice2 == 1)
                            {
                                Console.WriteLine("\nHoly Moly, you hit a Snake Eyes!!!\n");
                            }
                            else if (dice1 == 6 && dice2 == 6)
                            {
                                Console.WriteLine("\nYou're moving in the fast lane, you hit a Box Cars!!\n");
                            }
                            else if (sum == 7 || sum == 11)
                            {
                                Console.WriteLine("\nYou're not going to have a bad day since your dice are already crap, you hit a Craps =)\n");
                            }
                            else if (dice1 == dice2)
                            {
                                Console.WriteLine("\nDouble Trouble!\n");
                            }
                        }

                        Console.WriteLine("Roll again? (y/n): ");

                        string jump = Console.ReadLine().ToUpper();

                        if (jump == "N")
                        {
                            return;
                        }
                        else if (jump == "Y")
                        {
                            continue;
                        }
                        else
                        {
                            Console.WriteLine("Input was not \"y\" or \"n\", We'll take that as a \"y\"\n");
                        }
                    }
                }
                else
                {
                    Console.WriteLine("\nYour input was invalid");
                    continue;
                }
            }
        }
    }
}
