using System;
using System.Collections.Generic;
using System.Text;

namespace TriviaGame
{

    /// <summary>
    /// class GameIO
    /// Takes player input and outputs messages to the console.
    /// </summary>

    public class GameIO
    {

        // constructor function
        //public GameIO
        //{

        //}
        
        /// <summary>
        /// #getQuizOptions
        /// 
        /// Takes in and returns an Object of quiz options.
        /// </summary>
        /// <param name="questionsLibrary"></param>
        public int getQuizOptions()
        {
            Console.WriteLine("Please enter the number of Questions you would like to answer in Trivia Game");
            int count = Convert.ToInt32(Console.ReadLine());
            return count;
        }
        
        /// <summary>
        /// #getPlayerName
        /// 
        /// Returns a string from the console.
        /// </summary>
        /// <param name=""></param>
        
        public string getPlayerName()
        {
            string playerNameFromInput = Console.ReadLine();
            return playerNameFromInput;
        }
        
        /// <summary>
        /// #getPlayerAnswer
        /// 
        /// Returns a char type from the console.
        /// </summary>
        /// <param name=""></param>

        public char getPlayerAnswer()
        {
             char playerAnswerFromInput = (char)Console.ReadLine()[0];
             return playerAnswerFromInput;
        }
        
        /// <summary>
        /// #displayWelcomeMessage
        /// 
        /// Takes in a string from resources and writes it to the console
        /// </summary>
        /// <param name="welcomeMessage"></param>

        public void displayWelcomeMessage(string welcomeMessage)
        { 
            Console.WriteLine(welcomeMessage);
        }
        
        /// <summary>
        /// #displayScore
        /// 
        /// Takes in a player score from and writes it to the console
        /// </summary>
        /// <param name="playerScore"></param>
        
        public void DisplayPlayerInformation(Player player) 
        {
            Console.WriteLine($"Name: {player.Name}  Score: {player.Score}   Questions: {player.NumberOfQuestions} ");
            
        }

        /// <summary>
        /// #displayScore
        /// 
        /// Takes in a question of type string and prints it to the console
        /// </summary>
        /// <param name="questionToDisplay"></param>
        
        public void displayQuestion(QuestionsLibraryTransferObject question)
        { 
            Console.WriteLine($"Question: {question.question}");
        }
        
         /// <summary>
        /// #displayMultipleChoices
        /// 
        /// Takes in an object of multiple choices, and prints values of answer keys to the console.
        /// The user is first prompted to make an answer selection, followed by a list of possible letter answers and their values.
        /// </summary>
        /// <param name="multipleChoices"></param>
        
        public void displayMultipleChoices(Answers answers)
        { 
            Console.WriteLine("Make an Answer Selection: ");
            Console.WriteLine($"A: {answers.answer_a}");
            Console.WriteLine($"B: {answers.answer_b}");
            
            
            if (answers.answer_c != null)
            {
                Console.WriteLine($"C: {answers.answer_c}");
            }

            if (answers.answer_d != null)
            {
                Console.WriteLine($"D: {answers.answer_d}");
            }
            if (answers.answer_e != null)
            {
                Console.WriteLine($"E: {answers.answer_e}");
            }

            if (answers.answer_f != null)
            {
                Console.WriteLine($"F: {answers.answer_f}");
            }
            
        }
        
        /// <summary>
        /// #displayWinningMessage
        /// 
        /// Takes in a winning message of type string from resources and prints it to the console
        /// </summary>
        /// <param name="winningMessage"></param>

        public void displayWinningMessage(string winningMessage)
        {
            Console.WriteLine(winningMessage);
        }

        /// <summary>
        /// #displayPlayerAnswerFeedback
        /// 
        /// Takes in a string containing feedback regarding a player's answer and prints it to the console
        /// </summary>
        /// <param name="answerFeedbackToPlayer"></param>

        public void displayPlayerAnswerFeedback(string answerFeedbackToPlayer)
        {
            Console.WriteLine(answerFeedbackToPlayer);
        }

        /// <summary>
        /// #validateInput
        /// 
        /// Returns a bool result of an evaluation of a player's answer.
        /// <param name="gameManagerAnswerEvaluatione"></param>

        public bool validateInput(bool gameManagerAnswerEvaluation)
        {
            return gameManagerAnswerEvaluation;
        }

    }
}
