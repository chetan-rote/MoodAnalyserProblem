using System;
using System.Collections.Generic;
using System.Text;

namespace MoodAnalyserProblem
{
    public class MoodAnalysisCustomException : Exception
    {
        /// <summary>
        /// Enum with different exception types.
        /// </summary>
        public enum ExceptionType
        { 
            NULL_MESSAGE,
            EMPTY_MESSAGE,
            NO_SUCH_FIELD,
            NO_SUCH_METHOD,
            NO_SUCH_CLASS,
            OBJECT_CREATION_ISSUE
        }
        ExceptionType type;
        /// <summary>
        /// Initializes a new instance of the <see cref="MoodAnalysisCustomException"/> class.
        /// </summary>
        /// <param name="type">The type.</param>
        /// <param name="message">The message.</param>
        public MoodAnalysisCustomException(ExceptionType type, string message) : base(message)
        { 
            this.type = type;            
        }
    }
}
