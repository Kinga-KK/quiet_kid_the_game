using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuietKid_TheGame
{
    //todo: add option to save and load from local files
    class Game
    {
        private bool answerInvalid { get; set; }
        public bool playing { get; private set; }
        private Emil emil { get; set; }
        private int day { get; set; }
        public Game()
        {
            answerInvalid = false;
            playing = false;
            emil = new Emil();
            day = 1;
        }
        public static void Greetings()
        {
            Console.WriteLine("Welcome to Quiet Kid: The Game!");
            Console.WriteLine("\nEmil Edami is a quiet neumanner, living his life at the back of his class.\nWhat fate awaits him? Play to find out!\n");
        }
        public void ToPlayOrNotToPlay()
        {
            do
            {
                Console.Write("Play game?(y/n): ");
                string play = Console.ReadLine();
                switch (play)
                {
                    case "y":
                    case "yes":
                        playing = true; answerInvalid = false;
                        break;
                    case "n":
                    case "no":
                        playing = false; answerInvalid = false;
                        break;
                    default:
                        answerInvalid = true;
                        break;
                }
            } while (answerInvalid);
        }
        public void NewDay()
        {
            Console.WriteLine("game will be here");
            playing = false;
        }
        public static void Goodbye()
        {
            Console.WriteLine("\nGame ended. Exiting...");
        }
    }
}
