using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using RestSharp;
using Newtonsoft.Json;


namespace TriviaGame
{
   public class QuestionsLibrary
    {
       
        private List<QuestionsLibraryTransferObject> quizQuestionSet;

        /// <summary>
        /// Makes API call to retrieve trivia questions
        /// </summary>
        /// <param name="limit">number of questions requrested from API</param>
        private void requestTriviaQuestionData(int limit)
        {

            string questionLimit = limit.ToString();
            string basePath = "https://quizapi.io/api/v1/questions?apiKey=xMIenQI1Av41dDkHGvVSVFyjQ730nNMu4z0qOWIS&limit=";
            string completePath = basePath + questionLimit;

            var client = new RestClient(completePath);
            var request = new RestRequest();
            var response = client.Execute(request);
       

           quizQuestionSet = new List<QuestionsLibraryTransferObject>();

            if (response.StatusCode == HttpStatusCode.OK)
            {
                string rawResponse = response.Content;
                quizQuestionSet = JsonConvert.DeserializeObject<List<QuestionsLibraryTransferObject>>(rawResponse);   

            }

        }

        /// <summary>
        /// Calls another method responsible for setting quizQuestionSet variable, converts it to an array so it can be easily iterated, and returns the array
        /// </summary>
        /// <param name="limit">number of questions player requests</param>
        /// <returns></returns>
        public QuestionsLibraryTransferObject[] ConvertListToArray(int limit)
        {
            requestTriviaQuestionData(limit);
            return quizQuestionSet.ToArray(); ;
        }






    }
}
