using System;

namespace SharedProgram
{
    public class UserInterface
    {
        static void Main()
        {
            Console.WriteLine("Please enter a number: ");
            string stringUserInput = Console.ReadLine();
            int userInput = int.Parse(stringUserInput);
            PingPong pingPonger = new PingPong();
            pingPonger.PingPongGenerator(userInput);
        }
    }
}
