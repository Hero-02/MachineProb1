using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MachineProb1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 0;
            int y = 0;
            int playeranswer;
            int points = 0;
            char operation;
            Random rnd = new Random();

            Console.WriteLine("\nEnter the difficulty:\n [0] Easy\n [1] Medium\n [2] Hard\n");
            operation = Convert.ToChar(Console.ReadLine());

            if (operation == '0')
            {
                for (int i = 1; i <= 25; i++)
                {
                    x = rnd.Next(0, 99);
                    y = rnd.Next(0, 99);

                    // Select a random operation
                    char[] operators = { '+', '-', '*', '/' };
                    char op = operators[rnd.Next(0, operators.Length)];

                    Console.Write(i + ". What is " + x + " " + op + " " + y + " = "); // Print the counter
                    double ans = 0;
                    if (op == '+')
                    {
                        ans = x + y;
                    }
                    else if (op == '-')
                    {
                        ans = x - y;
                    }
                    else if (op == '*')
                    {
                        ans = x * y;
                    }
                    else if (op == '/')
                    {
                        // Make sure y is not 0 for division
                        y = (y == 0) ? 1 : y;
                        ans = (double)x / y;
                    }

                    // Loop until valid input is provided
                    while (!int.TryParse(Console.ReadLine(), out playeranswer))
                    {
                        Console.WriteLine("Invalid input! Please enter a valid integer.");
                    }

                    if (ans == playeranswer)
                    {
                        Console.WriteLine("Correct!");
                        points++;
                    }
                    else
                    {
                        Console.WriteLine("Incorrect!");
                    }
                }
                Console.WriteLine("\nYou got " + points + " /25!");
            }
            else if (operation == '1')
            {
                for (int i = 1; i <= 15; i++)
                {
                    x = rnd.Next(100, 999);
                    y = rnd.Next(100, 999);

                    // Select a random operation
                    char[] operators = { '+', '-', '*', '/' };
                    char op = operators[rnd.Next(0, operators.Length)];

                    Console.Write(i + ". What is " + x + " " + op + " " + y + " = "); // Print the counter
                    double ans = 0;
                    if (op == '+')
                    {
                        ans = x + y;
                    }
                    else if (op == '-')
                    {
                        ans = x - y;
                    }
                    else if (op == '*')
                    {
                        ans = x * y;
                    }
                    else if (op == '/')
                    {
                        // Make sure y is not 0 for division
                        y = (y == 0) ? 1 : y;
                        ans = (double)x / y;
                    }

                    // Loop until valid input is provided
                    while (!int.TryParse(Console.ReadLine(), out playeranswer))
                    {
                        Console.WriteLine("Invalid input! Please enter a valid integer.");
                    }

                    if (ans == playeranswer)
                    {
                        Console.WriteLine("Correct!");
                        points++;
                    }
                    else
                    {
                        Console.WriteLine("Incorrect!");
                    }
                }
                Console.WriteLine("\nYou got " + points + " /15!");
            }
            else if (operation == '2')
            {
                for (int i = 1; i <= 10; i++)
                {
                    x = rnd.Next(1000, 9999);
                    y = rnd.Next(1000, 9999);

                    // Select a random operation
                    char[] operators = { '+', '-', '*', '/' };
                    char op = operators[rnd.Next(0, operators.Length)];

                    Console.Write(i + ". What is " + x + " " + op + " " + y + " = "); // Print the counter
                    double ans = 0;
                    if (op == '+')
                    {
                        ans = x + y;
                    }
                    else if (op == '-')
                    {
                        ans = x - y;
                    }
                    else if (op == '*')
                    {
                        ans = x * y;
                    }
                    else if (op == '/')
                    {
                        // Make sure y is not 0 for division
                        y = (y == 0) ? 1 : y;
                        ans = (double)x / y;
                    }

                    // Loop until valid input is provided
                    while (!int.TryParse(Console.ReadLine(), out playeranswer))
                    {
                        Console.WriteLine("Invalid input! Please enter a valid integer.");
                    }

                    if (ans == playeranswer)
                    {
                        Console.WriteLine("Correct!");
                        points++;
                    }
                    else
                    {
                        Console.WriteLine("Incorrect!");
                    }
                }

                Console.WriteLine("\nYou got " + points + " /10!");

            }

            Console.ReadKey();
        }
    }
}
