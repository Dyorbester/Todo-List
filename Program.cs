using System;
using System.Collections.Generic;


class Program
{
    static void Main()
    {
        bool running = true;
        List<string> todo = new List<string>();

        while(running == true)
        {
            Console.Clear();
            Console.WriteLine("====================");
            Console.WriteLine("Welcome to the To-Do List");
            Console.WriteLine("====================");
            Console.WriteLine("\n");
            Console.WriteLine("Choose an Option: ");
            Console.WriteLine("\n");
            Console.WriteLine("[1] Show List");
            Console.WriteLine("[2] Add Item");
            Console.WriteLine("[3] Delete Item");
            Console.WriteLine("[4] Exit");

            string input = Console.ReadLine();

            switch(input)
            {
                case "1":

                    Console.Clear();
                    Console.WriteLine("Your To-Do List : ");

                    if (todo.Count == 0)
                    {
                        Console.Clear();

                        Console.WriteLine("The List is Empty");
                        Console.WriteLine("\n");
                    }
                    else
                    {
                        for (int i = 0; i < todo.Count; i++)
                        {
                            Console.WriteLine($"{i + 1}. {todo[i]}");

                        }

                    }
                    Console.WriteLine("\nPress any key to continue...");
                    Console.ReadKey(); 
                    break;

                case "2":
                    Console.Clear();

                    Console.WriteLine("Which item do u want to add?: ");

                    string add = Console.ReadLine();

                    if (!string.IsNullOrWhiteSpace(add))
                    {
                        todo.Add(add);
                        Console.WriteLine("Item added");
                    }
                    else
                    {
                        Console.WriteLine("Empty input was ignored.");

                    }
                    Console.WriteLine("\nPress any key to continue...");
                    Console.ReadKey();


                        break;
                case "3":
                    Console.Clear();
                    Console.WriteLine("Enter the number of the item to delete:  ");

                    for (int i = 0; i < todo.Count; i++)
                    {
                        Console.WriteLine($"{i + 1}. {todo[i]}");
                    }
                    string choice = Console.ReadLine();

                    if (int.TryParse(choice, out int index))

                    {

                        if (index > 0 && index <= todo.Count)
                        {
                            todo.RemoveAt(index - 1);
                            Console.WriteLine("Item Deleted!");
                        }
                        else
                        {
                            Console.WriteLine("Invalid Number!");
                        }
                    }
                    Console.WriteLine("\nPress any key to continue...");

                    Console.ReadKey();

                        break;
                case "4":
                    Console.Clear();
                    Console.WriteLine("Have a Nice Day and thanks for using our To-Do List!");
                    running = false;
                    break;

                default:
                    Console.WriteLine("Invalid input");
                    break;
            }
        }
    }
}