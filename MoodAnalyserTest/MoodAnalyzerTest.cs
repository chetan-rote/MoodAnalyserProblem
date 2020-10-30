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
            string result = moodAnalyser.AnalyseMood();
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
            string result = moodAnalyzer.AnalyseMood();
            //Assert
            Assert.AreEqual(expectedValue, result);
        }
        /// <summary>
        /// If given null mood will throw exception "Mood cannot be null"
        /// </summary>
        [TestMethod]        
        public void GivenNullMood_ShouldReturnMoodCannotBeNull()
        {
            try
            {
                ///Arrange
                string message = null;
                MoodAnalyser moodAnalyser = new MoodAnalyser(message);
                ///Act
                string result = moodAnalyser.AnalyseMood();
            }
            catch (MoodAnalysisCustomException exception)
            {
                ///Assert
                Assert.AreEqual("Mood cannot be null", exception.Message);
            }
        }
        /// <summary>
        /// If given empty mood will throw exception "Mood cannot be empty".
        /// </summary>
        [TestMethod]
        public void GivenEmptyMood_ShouldThrowMoodCannotBeEmpty()
        {
            try
            {
                ///Arrange
                string message = "";
                MoodAnalyser moodAnalyser = new MoodAnalyser(message);
                ///Act
                string result = moodAnalyser.AnalyseMood();
            }
            catch (MoodAnalysisCustomException exception)
            {
                ///Assert
                Assert.AreEqual("Mood should not be empty", exception.Message);
            }
        }
        /// <summary>
        /// Givens the mood analyser class name should return mood analyser object.
        /// </summary>
        [TestMethod]
        public void GivenMoodAnalyserClassName_ShouldReturnMoodAnalyserObject()
        {
            ///Arrange
            string className = "MoodAnalyserProblem.MoodAnalyser";
            string constructorName = "MoodAnalyser";
            ///Act
            object expected = new MoodAnalyser();
            object obj = MoodAnalyserFactory.CreateMoodAnalyserObject(className, constructorName);
            ///Assert
            expected.Equals(obj);
        }
        /// <summary>
        /// Givens the improper class name should throw mood analysis exception.
        /// </summary>
        [TestMethod]
        public void GivenImproperClassName_ShouldThrowMoodAnalysisException()
        {
            try
            {
                ///Arrange
                string className = "ClassNameSpace.MoodAnalyser";
                string constructorName = "MoodAnalyser";
                ///Act
                object expected = new MoodAnalyser();
                object obj = MoodAnalyserFactory.CreateMoodAnalyserObject(className, constructorName);
            }
            catch (MoodAnalysisCustomException exception)
            {
                //Assert
                Assert.AreEqual("class not found.", exception.Message);
            }
        }
        /// <summary>
        /// Givens the improper constructor should throw mood analysis exception.
        /// </summary>
        [TestMethod]
        public void GivenImproperConstructor_ShouldThrowMoodAnalysisException()
        {
            try
            {
                ///Arrange
                string className = "MoodAnalyserProblem.MoodAnalyser";
                string constructorName = "Constructor";
                ///Act
                object obj = MoodAnalyserFactory.CreateMoodAnalyserObject(className, constructorName);
            }
            catch (MoodAnalysisCustomException exception)
            {
                ///Assert
                Assert.AreEqual("constructor not found.", exception.Message);
            }
        }
    }
}
