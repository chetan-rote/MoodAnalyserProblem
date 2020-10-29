using System;
using System.Collections.Generic;
using System.Text;

namespace MoodAnalyserProblem
{
    class MoodAnalyser
    {
        /// <summary>
        /// Analyses user's mood.
        /// </summary>
        /// <param name="message">The message.</param>
        /// <returns>Sad else Happy</returns>
        public string AnalyseMood(string message)
        {
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
    }
}
