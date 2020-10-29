using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyserProblem;
namespace MoodAnalyserTest
{
    [TestClass]
    public class MoodAnalyzerTest
    {
        /// <summary>
        /// Givens the I am in sad mood should return sad.
        /// </summary>
        [TestMethod]
        public void GivenIAmInSadMood_ShouldReturnSad()
        {
            //Arrange
            string message = "I am in sad mood.";
            string expectedValue = "SAD";
            MoodAnalyser moodAnalyser = new MoodAnalyser(message);
            //Act
            string result = moodAnalyser.AnalyseMood(message);
            //Assert
            Assert.AreEqual(expectedValue, result);
        }
        /// <summary>
        /// Givens the I am in any mood should return happy.
        /// </summary>
        [TestMethod]
        public void GivenIAmInAnyMood_ShouldReturnHappy()
        {
            //Arrange
            string message = "I am in happy mood.";
            string expectedValue = "HAPPY";
            MoodAnalyser moodAnalyzer = new MoodAnalyser(message);
            //Act
            string result = moodAnalyzer.AnalyseMood(message);
            //Assert
            Assert.AreEqual(expectedValue, result);
        }
        /// <summary>
        /// Given the null should return happy.
        /// </summary>
        /// <returns></returns>
        [TestMethod]
        [DataRow(null)]
        public void GivenNull_ShouldReturnHappy(string message)
        {
            ///Arrange
            string ecpectedValue = "HAPPY";
            MoodAnalyser moodAnalyser = new MoodAnalyser(message);
            ///Act
            string result = moodAnalyser.AnalyseMood(message);

            ///Assert
            Assert.AreEqual(result, ecpectedValue);

        }
    }
}
