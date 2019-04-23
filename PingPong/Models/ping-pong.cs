using System;

namespace SharedProgram
{
    public class PingPong
    {
        public void PingPongGenerator(int userInput)
        {
            for (int i = 1; i <= userInput; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("pingpong");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("ping");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("pong");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
