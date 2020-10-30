using System;
using System.Collections.Generic;
using System.Text;

namespace MoodAnalyserProblem
{
    public class MoodAnalyser
    {
        string message;
        /// <summary>
        /// Initializes a new instance of the <see cref="MoodAnalyser"/> class.
        /// </summary>
        public MoodAnalyser()
        {
            
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="MoodAnalyser"/> class.
        /// </summary>
        /// <param name="message">The message.</param>
        public MoodAnalyser(string message)
        {
            this.message = message;
        }
        /// <summary>
        /// Analyses user's mood.
        /// </summary>
        /// <param name="message">The message.</param>
        /// <returns>Sad else Happy</returns>
        public string AnalyseMood()
        {
            try
            {
                //checks if user gives empty message.
                if (this.message.Equals(string.Empty))
                {
                    throw new MoodAnalysisCustomException(MoodAnalysisCustomException.ExceptionType.EMPTY_MESSAGE, 
                        "Mood should not be empty");
                } 
                ///Checks if user mood is sad will return sad,
                ///if user mood is happy will return happy.
                if (message.ToUpper().Contains("SAD"))
                {
                    return "SAD";
                }
                else
                {
                    return "HAPPY";

                }
            }
            catch(NullReferenceException)
            {
                throw new MoodAnalysisCustomException(MoodAnalysisCustomException.ExceptionType.NULL_MESSAGE,
                    "Mood cannot be null");
            }
        }
    }
}
