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
        private string[] days { get; set; }
        private string[] endings { get; set; }
        public Game()
        {
            Reset();
        }
        public void Reset()
        {
            answerInvalid = false;
            playing = false;
            emil = new Emil();
            day = 1;
            setDays();
            setEndings();
        }
        private void setDays()
        {
            days = new string[] 
            {
                "Your first day of school. It passes without much action since you don't have any friends."
            };
        }
        private void setEndings()
        {
            endings = new string[]
            {
                "\nThat was it. Yet another month. You guess not much changes during a month for Emil.\n"
            };
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
            Console.WriteLine($"\nDay {day}\n");
            Console.WriteLine(days[day - 1]);
            CheckEnd();
        }
        public void CheckEnd()
        {
            if (day == days.Count())
            {
                Console.WriteLine("\nCongratulations, you've reached an ending!\n" +
                    $"---{endings[0]}---" +
                    "\nWould you like to play another time?");
                Reset();
                ToPlayOrNotToPlay();
            }
            else
            {
                ++day;
            }
        }
        public static void Goodbye()
        {
            Console.WriteLine("\nGame ended. Exiting...");
        }
    }
}
