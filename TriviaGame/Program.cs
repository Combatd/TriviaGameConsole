using System;
using System.Drawing;
using System.Resources;

namespace TriviaGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player("Yoda");
            QuestionsLibrary library = new QuestionsLibrary();
            GameIO gameIO = new GameIO();
            GameManager gameManager = new GameManager(player, library, gameIO);
            gameManager.InititateGame();

            Console.ReadLine();
        }
    }
}
