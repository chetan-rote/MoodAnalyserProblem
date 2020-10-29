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
