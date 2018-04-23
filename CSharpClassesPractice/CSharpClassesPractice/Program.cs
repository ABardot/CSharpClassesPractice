using System;


namespace CSharpClassesPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Would you prefer to be behind door number 1, 2, or 3?");
            string userValue = Console.ReadLine();

            string message = "";
            if (userValue == "1")
            {                  
                message = "You have won a car!";
            }
            else if (userValue == "2")
            {
                message = "You win a boat!";
            }
            else if (userValue == "3")
            {
                message = "You won an airplane!";
            }
            else
            {
                message = "Sorry you didn't win a prize.";
            }

            Console.WriteLine(message);
        }
    }
}
