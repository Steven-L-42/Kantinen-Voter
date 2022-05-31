using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MazeWalker
{
    public class PlayerScore
    {
        public int Score { get; set; }

        public string Name { get; set; }

        public override string ToString()
        {
            return $"{Name}:{Score}";
        }

        public static PlayerScore Parse(string str)
        {
            var parts = str.Split(':');

            return new PlayerScore
            {
                Score = int.Parse(parts[1]),
                Name = parts[0]
            };
        }
    }

    static class ScoreUtils
    {
        private static string ScorePath = "./scores.txt";

        public static void WriteScore(PlayerScore score)
        {
            if (File.Exists(ScorePath))
            {
                using (var stream = File.AppendText(ScorePath))
                {
                    stream.WriteLine(score);

                    stream.Flush();
                }
            }
            else
            {
                using (var stream = File.CreateText(ScorePath))
                {
                    stream.WriteLine(score);

                    stream.Flush();
                }

            }
        }

        public static List<PlayerScore> ReadTopScores()
        {
            List<PlayerScore> scores = new List<PlayerScore>();
            using (var file = File.Open(ScorePath, FileMode.OpenOrCreate))
            using (var stream = new StreamReader(file))
            {
                while (!stream.EndOfStream)
                {
                    scores.Add(PlayerScore.Parse(stream.ReadLine()));
                }
            }

            return scores;
        }
    }
}
