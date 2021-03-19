
namespace TriviaGame
{
    /// <summary>
    /// This class represents the Player
    /// Name: string
    /// Score: int
    /// </summary>
    public class Player
    {
        public string Name { get; set; }
        public int Score { get; set; }

        public int NumberOfQuestions { get; set; }
        public Player(string name)
        {
            Name = name;
        }

        /// <summary>
        /// Increase score by specified number of points
        /// </summary>
        /// <param name="points"></param>
        public void IncreasePlayerScore()
        {
            Score += 10;
        }
    }
}
