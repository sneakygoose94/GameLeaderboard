using System;
using System.Collections.Generic;

namespace GameLeaderboardApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var player = new Player("Ducksu");
            
            player.AddScore(549);

            // player.ShowScoring();

            var score = player.GetScoring();

        }
    }
}
