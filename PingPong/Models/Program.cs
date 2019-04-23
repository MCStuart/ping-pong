using System;

namespace PingPong
{
    public class UserInterface
    {
        static void Main()
        {
            Console.WriteLine("Please enter a number: ");
            int userInput = Console.ReadLine();
            PingPongGen(userInput);
        }
    }
}
