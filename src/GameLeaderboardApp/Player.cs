using System;
using System.Collections.Generic;

namespace GameLeaderboardApp
{
    public class Player
    {
        private string _nickname;
        private List<int> _scores = new List<int>();

        public Player(string nickname)
        {
            this._nickname = nickname;
        }

        public void AddScore(int score)
        {
            this._scores.Add(score);
        }

        public Scoring GetScoring()
        {
            var result = new Scoring();

            result.Average = 0;
            result.High = int.MinValue;
            result.Low = int.MaxValue;

            foreach (var score in _scores)
            {
                result.Low = Math.Min(score, result.Low);
                result.High = Math.Max(score, result.High);
                result.Average += score;
            }

            result.Average /= _scores.Count;

            return result;

            //result /= _scores.Count;

        }
    }
}