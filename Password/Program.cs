using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Password
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter A Password: ");
            string password = "Csharp";
            string input = Console.ReadLine();
            string admin = "Tanczos";
            

            switch (input)
            {
                case "Csharp": Console.WriteLine("\nPassword Valid\n");
                   Console.WriteLine("...................");
                   Console.WriteLine("...................");
                   Console.Write("\nEnter Your Username: \n");
                    string username = Console.ReadLine();

                    if (1 == 1)
                    {
                        if (username == "Tanczos")
                        {
                            Console.WriteLine("\nHello Administrator {0}\n", admin);
                            while (username == "Tanczos")
                            {
                                Console.Write("\nType \"P1\" For Program 1:\n");
                                string choice = Console.ReadLine();
                                if (choice == "P1")
                                {
                                    Console.Write("\nEnter The Program Password: \n");
                                    break;
                                }

                                else
                                {
                                    Console.Write("\nTry Again\n");
                                }

                            }
                        }

                        else
                        {
                            if (username == "Tanczos")
                        {
                            Console.WriteLine("\nHello {0}\n", username);
                            while (username == username)
                            {
                                Console.Write("\nType \"P1\" For Program 1:\n");
                                string choice = Console.ReadLine();
                                if (choice == "P1")
                                {
                                    Console.Write("\nEnter The Program Password: \n");
                                    break;
                                }

                                else
                                {
                                    Console.Write("\nTry Again\n");
                                }

                            }
                            
                        }
                    }

                    break;
                default: Console.WriteLine("\nPassword Invalid. Please Try Again\n");
                    Console.Write("Enter A Password: ");
                    bool invalid = true;
                    while (invalid)
                    {
                        string attempt1 = Console.ReadLine();

                        if (attempt1 == "Csharp")
                        {
                            Console.WriteLine("\nPassword Valid\n");
                            Console.WriteLine("...................");
                            Console.WriteLine("...................");
                            Console.Write("\nEnter Your Username: \n");
                            string username1 = Console.ReadLine();

                            if (1 == 1)
                            {
                                Console.WriteLine("\nHello {0}\n", username1);
                            }
                            else if (username1 == "Tanczos")
                            {
                                Console.WriteLine("\nHello {0}\n", admin);
                            }


                        }

                        else
                            Console.WriteLine("\nSorry To Many Attempts\n");
                        break;
                            

                    }
                    break;

            }

            Console.Read();
        }   
    }
    }
}