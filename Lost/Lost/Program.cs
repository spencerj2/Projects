using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Game
{
    class Program
    {
        static void Main(string[] args)
        {
            bool quit = false;
            int health = 100;
            Console.WriteLine("\nYour Health Is : {0}\n", health);
            Console.WriteLine("Press A To Attack");
            Console.WriteLine("Press D To Defend");
            Console.WriteLine("Press R To Run");
            Console.WriteLine("Press Q To Quit");
            string input = Console.ReadLine();

            while (quit == false)
            {
                switch (input)
                {
                    case "A":
                        Console.WriteLine("You Attacked");
                        quit = true;
                        quit = false;
                        break;
                    case "D":
                        Console.WriteLine("You Defended");
                        quit = true;
                        break;
                    case "R":
                        Console.WriteLine("You Ran");
                        quit = true;
                        break;
                    case "Q":
                        quit = true;
                        break;
                    default:
                        Console.WriteLine("Please Enter A Valid Input");
                        break;
                }


                if (quit == true)
                {
                    Console.Read();
                }
            }
        } 
    }
}
