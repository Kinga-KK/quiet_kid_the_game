using System;

namespace QuietKid_TheGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Game.Greetings();

            Game game = new Game();
            game.ToPlayOrNotToPlay();

            while (game.playing)
            {
                game.NewDay();
            }

            Game.Goodbye();
        }
    }
}
