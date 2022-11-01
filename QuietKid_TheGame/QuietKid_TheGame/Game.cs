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
        private Random r = new Random();
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
        private void Reset()
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
                "Another day of school. It passes without much action.",
                "You went to school and sat next to your friend. He's a quiet kid too. Sometimes you wonder if he thinks the same way as you, but you don't dare ask.",
                "One of your teachers made a rude comment about you.",
                "You got praised by your favourite teacher today.",
                "You managed to score a good mark today.",
                "You got a bad mark.",
                "You heard a couple arguing in the hallways.",
                "Some students were protesting in front of the school today.",
                "All the teachers went on strike. You had a free day.",
                "A student was playing a guitar in the breaks today.",
                "You got told \"Buddy, I knew you were scamming before I even touched the bat, bats don't break from getting dropped from someone's hands. I said all that jargon just so I can flex all my knowledge about baseball.\" today.",
                "Nothing.",
                "You had to drag yourself to school and were thinking of going home all day.",
                "You got humiliated in front of class. Again.",
                "The only thing in your wallet today was despair.",
                "You got disqualified on an exam because you had to go to the toilet.",
                "You wasted all your money on snacks. It was worth it.",
                "You got lost on the way to schooll today.",
                "You \"got lost\" on the way to school today.",
                "All your classes were online today. You were perfectly comfortable. Which means you weren't paying attention.",
                "You almost died in school today.",
                "You wake up and decide to become a cereal killer.",
                "You wake up and decide to put milk before the cereal.",
                "You pulled an all nighter to finish a group project, but found out you have a test today. It was your worst subject.",
                "You slipped on a banana peel at 4:15 AM at Disneyland. You almost die because you're lactose intolerant.",
                "Nobody helps you work on a group project and you all end up failing. They push the blame on you.",
                "You eat cereal with edami cheese today.",
                "You mix soggy cereal with crispy cereal.",
                "No one knows but you were in the military for 3 months in Africa."
            };
        }
        private void setEndings()
        {
            endings = new string[]
            {
                //todo: add more endings
                "That was it. Yet another month. You guess not much changes during a month for Emil."
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
                switch (play.ToLower())
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
            Console.WriteLine($"\n> Day {day} <\n");
            Console.WriteLine("> " + days[r.Next(0,days.Count())] + " <");
            if (r.Next(0,10) == 7)
            {
                LifeChangingChoices();
            }
            else
            {
                BasicChoices();
            }
            CheckEnd();
        }
        private void BasicChoices()
        {
            Console.WriteLine("\n>>> What will you do tonight? <<<");
            Console.WriteLine("T - Train" +
                "\nC - Code" +
                "\nS - Seethe in repressed rage");
            do
            {
                Console.Write("\nMake your choice: ");
                switch (Console.ReadLine().ToLower())
                {
                    case "t":
                    case "train": emil.Train(); answerInvalid = false;
                        break;
                    case "c":
                    case "code": emil.Code(); answerInvalid = false;
                        break;
                    case "s":
                    case "seethe":
                    case "seethe in repressed rage": emil.Seethe(); answerInvalid = false;
                        break;
                    default: Console.WriteLine("There's no choice like that."); answerInvalid = true;
                        break;
                }
            } while (answerInvalid);
        }
        private void LifeChangingChoices()
        {
            Console.WriteLine("\n !Today you decide to do something different. Something life-changing...!");
            Console.WriteLine("\n>>> What shall it be? <<<");
            Console.WriteLine("B - Do something with your body" +
                "\nC - Do something with your coding skills" +
                "\nR - Do something with your rage" +
                "\nX - Do something ordinary instead");
            do
            {
                Console.Write("\nMake your choice: ");
                switch (Console.ReadLine().ToLower())
                {
                    case "b":
                    case "body":
                        Body(); answerInvalid = false;
                        break;
                    case "c":
                    case "code":
                    case "coding skills":
                        CodeSkills(); answerInvalid = false;
                        break;
                    case "r":
                    case "rage":
                        Rage(); answerInvalid = false;
                        break;
                    case "x":
                        BasicChoices(); answerInvalid = false;
                        break;
                    default:
                        Console.WriteLine("There's no choice like that."); answerInvalid = true;
                        break;
                }
            } while (answerInvalid);
        }
        private void Body()
        {
            Console.WriteLine("\n");
            Console.WriteLine("\n>>> What action will you take? <<<");
            Console.WriteLine("" +
                "\n" +
                "\n" +
                "\nX - Go back");
            do
            {
                Console.Write("\nMake your choice: ");
                switch (Console.ReadLine().ToLower())
                {
                    case "x": LifeChangingChoices(); answerInvalid = false;
                        break;
                    default:
                        Console.WriteLine("There's no choice like that."); answerInvalid = true;
                        break;
                }
            } while (answerInvalid);
        }
        private void CodeSkills()
        {
            Console.WriteLine("\n");
            Console.WriteLine("\n>>> What action will you take? <<<");
            Console.WriteLine("" +
                "\n" +
                "\n" +
                "\nX - Go back");
            do
            {
                Console.Write("\nMake your choice: ");
                switch (Console.ReadLine().ToLower())
                {
                    case "x":
                        LifeChangingChoices(); answerInvalid = false;
                        break;
                    default:
                        Console.WriteLine("There's no choice like that."); answerInvalid = true;
                        break;
                }
            } while (answerInvalid);
        }
        private void Rage()
        {
            Console.WriteLine("\n");
            Console.WriteLine("\n>>> What action will you take? <<<");
            Console.WriteLine("" +
                "\n" +
                "\n" +
                "\nX - Go back");
            do
            {
                Console.Write("\nMake your choice: ");
                switch (Console.ReadLine().ToLower())
                {
                    case "x":
                        LifeChangingChoices(); answerInvalid = false;
                        break;
                    default:
                        Console.WriteLine("There's no choice like that."); answerInvalid = true;
                        break;
                }
            } while (answerInvalid);
        }
        private void CheckEnd()
        {
            if (day == 31)
            {
                Ending(0);
            }
            else
            {
                ++day;
            }
        }
        private void Ending(int whichending)
        {
            Console.WriteLine("\n\t!!!Congratulations, you've reached an ending!!!\n" +
                    $"\t---\n{"\t" + endings[whichending]}\n\t---");
            Console.WriteLine($"\tFinal stats:\n" +
                    $"\n\tPhysique: {emil.Physique}" +
                    $"\n\tCoding: {emil.Coding}" +
                    $"\n\tBloodlust: {emil.BloodLust}\n");
            EasterEgg();
            Console.WriteLine("\nWould you like to play another time?"); ;
            Reset();
            ToPlayOrNotToPlay();
        }
        private void EasterEgg()
        {
            if (emil.Physique == 5 && emil.Coding == 5 && emil.BloodLust == 5)
            {
                Console.WriteLine("\nYou really know how to balance your life out!" +
                    "\n\tSome physical exercise, some mental, and some healthy rage..." +
                    "\n\tYou've found the 'Jack of All Trades' easter egg!\n");
            }
            if (emil.Physique == 8)
            {
                Console.WriteLine("\nYou really love working out. It fills you with bliss when you can experience the fruits of your own labor." +
                    "\n\tAnd showing off your muscles.\n" +
                    "\n\tYou've found the 'Buff Guy' easter egg!\n");
            }
            if (emil.Coding == 8)
            {
                Console.WriteLine("\n\tYou love coding. You much rather click-clack on your keyboard than anything else.\n" +
                    "\n\tYou've found the 'Bit Lover' easter egg!\n");
            }
            if (emil.BloodLust == 8)
            {
                Console.WriteLine("\n\tYou seethe with rage. This world isn't right. Something needs to be done..." +
                    "\n\tOr at least there needs to be a punchbag in your arm's reach. At all times.\n" +
                    "\n\tYou've found the 'Angry Boy' easter egg!\n");
            }
        }
        public static void Goodbye()
        {
            Console.WriteLine("\n\tCredits\n\n\tCode: K. Kinga\n\n\tMany thanks to Jyll, Jony and YoursTrulyTheReaper for the daily text ideas!");
            Console.WriteLine("\nGame ended. Exiting...");
        }
    }
}
