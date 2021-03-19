using System;
using System.Collections.Generic;
using System.Text;

namespace TriviaGame
{
    class GameManager
    {
        //Properties to keep track of game status
        private bool isGameWon;
        private bool gameInProgress;
        public bool IsGameWon { get; set; }
        public bool GameInProgress { get; set; }
        public int NumberOfQuestions { get; set; }
        private Player currentPlayer;

        private QuestionsLibrary currentQuestionLibrary;

        private QuestionsLibraryTransferObject[] QuestionArray;

        private GameIO currentgGameIO;


        /// <summary>
        /// Constructor for Game Manager
        /// </summary>
        /// <param name="player"></param>
        /// <param name="questions"></param>
        /// <param name="gameIO"></param>
        public GameManager(Player player, QuestionsLibrary questions, GameIO gameIO)
        {
            currentPlayer = player;
            currentQuestionLibrary = questions;
            currentgGameIO = gameIO;
        }


        /// <summary>
        /// Initiates game with welcome message, instructions and calls method to request trivia questions.
        /// </summary>
        public void InititateGame()
        {
            GameInProgress = true;
            IsGameWon = false;
            currentgGameIO.displayWelcomeMessage(MessageLibrary.logo);
            currentgGameIO.displayWelcomeMessage(MessageLibrary.welcome);
            Console.WriteLine(MessageLibrary.rules);
            //Console.WriteLine(MessageLibrary.menu);
            GetQuestionSet();
        }
        /// <summary>
        /// Collects the playes's input(count of question) from GameIO class.
        /// Fetches the array of questions from the QuestionsLibrary.
        /// </summary>
        public void GetQuestionSet()
        {
            int numberOfQuestions = currentgGameIO.getQuizOptions();
            currentPlayer.NumberOfQuestions = numberOfQuestions;
            QuestionArray = currentQuestionLibrary.ConvertListToArray(currentPlayer.NumberOfQuestions);
            
           // Console.WriteLine(currentPlayer.NumberOfQuestions);
            SelectQuestionToDisplay();
        }

        /// <summary>
        /// Supplies the question and answer set to GameIO class for displaying on console.
        /// </summary>
        private void SelectQuestionToDisplay()
        {
            //int count = NumberOfQuestions;
            for (int i = 0; i < QuestionArray.Length; i++)
            {
                Console.WriteLine();
                currentgGameIO.DisplayPlayerInformation(currentPlayer);
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine($"Question {i+1} of {currentPlayer.NumberOfQuestions}");
                Console.WriteLine();
                currentgGameIO.displayQuestion(QuestionArray[i]);
                currentgGameIO.displayMultipleChoices(QuestionArray[i].answers);
                char answer = currentgGameIO.getPlayerAnswer();
                EvaluateAnswers(answer, i);
            }
            EndTheGame();
        }
        
        /// <summary>
        /// Evaluates players selected answer comparing it to the actual answer
        /// </summary>
        /// <param name="selectedOption">players answer selection</param>
        /// <param name="questionIndex">index of question currently in play</param>
        public void  EvaluateAnswers(char selectedOption, int questionIndex)
        {
            QuestionsLibraryTransferObject q = QuestionArray[questionIndex];
            char correctAnswer=' ';
            char selectOptionInLowerCase = char.ToLower(selectedOption);

            Correct_Answers answers = q.correct_answers;

            if (answers.answer_a_correct == "true")
            {

                correctAnswer = 'a';
            }

            if (answers.answer_b_correct == "true")
            {
                correctAnswer ='b';
            }
            if (answers.answer_c_correct == "true")
            {
                correctAnswer = 'c';
            }
            if (answers.answer_d_correct == "true")
            {
                correctAnswer = 'd';
            }
            if (answers.answer_e_correct == "true")
            {
                correctAnswer = 'e';
            }
            if (answers.answer_f_correct == "true")
            {
                correctAnswer = 'f';
            }

            Console.WriteLine();
            if (selectOptionInLowerCase.Equals(correctAnswer))
            {
                
                currentgGameIO.displayPlayerAnswerFeedback("Correct Answer");
                currentPlayer.IncreasePlayerScore();
            }
            else
            {
                
                currentgGameIO.displayPlayerAnswerFeedback("Wrong Answer");
            }
            //GameIO input to reacive multiple choise qquestions, check if input is correct answer
            Console.WriteLine();
            Console.WriteLine("The correct answer is " + correctAnswer);
        }

        /// <summary>
        /// displays winning message if player gets all questions right
        /// </summary>
        public void EndTheGame()
        {
            int winningScore = currentPlayer.NumberOfQuestions * 10; 
            if(currentPlayer.Score == winningScore)
            {
                currentgGameIO.displayWinningMessage("You got 100% corret. You Win !!!");
            }
            else{
                currentgGameIO.displayWinningMessage($"Final score: {currentPlayer.Score}. Play again and try to get 100%");
            }

            

            Environment.Exit(0);

        }
    }
}
