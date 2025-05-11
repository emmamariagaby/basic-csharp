using System;

namespace BasicCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Console.ReadLine();

            // Variables
          /*   int x;
            int y;

            x = 7;
            y = x + 3;

            Console.WriteLine(y);
            Console.ReadLine(); */

            // User Input
          /*   Console.WriteLine("What is your name?");
            Console.Write("Type your first name: ");
            string myFirstName;
            myFirstName = Console.ReadLine() ?? "";

            string myLastName;
            Console.Write("Type your last name: ");
            myLastName = Console.ReadLine() ?? "";

            Console.WriteLine("Hello, " + myFirstName + " " + myLastName);
            Console.ReadLine(); */

            // if Statement with multiple conditions
       /*      Console.WriteLine("Emma's Big Giveaway");
            Console.Write("Choose a door: 1, 2, or 3: ");
            string userValue = Console.ReadLine() ?? "";

            string message = "";

            if (userValue == "1")
            {
                message = "You won a new car!";
            }
            else if (userValue == "2")
            {
                message = "You won a new boat!";
            }
             else if (userValue == "3")
            {
                message = "You won a trip!";
            }
               else
            {
                message = "Sorry, we didn't understand";
            }
            Console.WriteLine(message);
            Console.ReadLine(); */

            // if Statement using ternary operator
         /*    Console.WriteLine("Emma's Big Giveaway");
            Console.Write("Choose a door: 1, 2, or 3: ");
            string userValue = Console.ReadLine() ?? "";

            string message = (userValue == "1") ? "car" : "trip";

            Console.WriteLine("You entered: {0}, therefor you won a {1}.", userValue, message);
            Console.ReadLine(); */

            // for Iteration statements
        /*     for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
                if (i == 9)
                {
                    Console.WriteLine("Found number nine!");
                    break;
                }
            }
            Console.ReadLine(); */

            // Array with numbers
         /*    int[] numbers = new int[5];

            numbers[0] = 4;
            numbers[1] = 8;
            numbers[2] = 15;
            numbers[3] = 16;
            numbers[4] = 23;

            Console.WriteLine(numbers[1]);
            Console.WriteLine(numbers.Length);
            Console.ReadLine(); */

            // Array with strings
        /*     string[] names = new string[] { "Ada", "Beda", "Eva", "Birgit" };

            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine(names[i]);
            }
            Console.ReadLine(); */
        }
    }
}
