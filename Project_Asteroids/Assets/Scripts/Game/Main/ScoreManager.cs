using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vkimow.Tools.Single;

namespace Game.Main
{
    class ScoreManager : Singleton<ScoreManager>
    {
        public event Action<int> OnScoreChanged;
        public event Action<int> OnHighScoreChanged;

        public int Score
        {
            get
            {
                return _score;
            }
            set
            {
                _score = value;
                OnScoreChanged?.Invoke(value);
            }
        }
        public int HighScore
        {
            get
            {
                return _highScore;
            }
            set
            {
                _highScore = value;
                OnHighScoreChanged?.Invoke(value);
            }
        }


        private int _score;
        private int _highScore;

        public ScoreManager()
        {
            Reset();
            HighScore = 0;
        }

        public void Reset()
        {
            Score = 0;
        }

        public void Add(int value)
        {
            Score += value;

            if (Score > HighScore)
            {
                HighScore = Score;
            }
        }
    }
}
