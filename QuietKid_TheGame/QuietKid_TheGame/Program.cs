using System;

namespace QuietKid_TheGame
{
    class Program
    {
        static void Main(string[] args)
        {
            bool answerInvalid = false;
            bool playing = false;
            Console.WriteLine("Welcome to Quiet Kid: The Game!");
            Console.WriteLine("\nEmil Edami is a quiet neumanner, living his life at the back of his class.\nWhat fate awaits him? Play to find out!\n");

            do
            {
                Console.Write("Play game?(y/n): ");
                string play = Console.ReadLine();
                switch (play)
                {
                    case "y":
                    case "yes": playing = true; answerInvalid = false;
                        break;
                    case "n":
                    case "no": playing = false; answerInvalid = false;
                        break;
                    default: answerInvalid = true;
                        break;
                }
            } while (answerInvalid);

            while (playing)
            {
                Console.WriteLine("game will be here");
                playing = false;
            }

            Console.WriteLine("\nGame ended. Exiting...");
        }
    }
}
