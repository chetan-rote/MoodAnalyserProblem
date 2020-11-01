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
        ///UC4
        /// <summary>
        /// Givens the mood analyser class name should return mood analyser object.
        /// </summary>
        [TestMethod]
        public void GivenMoodAnalyserClassName_ShouldReturnMoodAnalyserObject()
        {
            ///Act
            object expected = new MoodAnalyser();
            object obj = MoodAnalyserFactory.CreateMoodAnalyserObject("MoodAnalyserProblem.MoodAnalyser", "MoodAnalyser");
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
                ///Act
                object expected = new MoodAnalyser();
                object obj = MoodAnalyserFactory.CreateMoodAnalyserObject("ClassNameSpace.MoodAnalyser", "MoodAnalyser");
            }
            catch (MoodAnalysisCustomException exception)
            {
                //Assert
                Assert.AreEqual("class not found", exception.Message);
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
                ///Act
                object obj = MoodAnalyserFactory.CreateMoodAnalyserObject("MoodAnalyserProblem.MoodAnalyser", "Constructor");
            }
            catch (MoodAnalysisCustomException exception)
            {
                ///Assert
                Assert.AreEqual("constructor not found", exception.Message);
            }
        }
        /// <summary>
        /// Givens the mood analyser class name should return mood analyser object using parametrized constructor.
        /// </summary>
        /// UC5
        [TestMethod]
        public void GivenMoodAnalyserClassName_ShouldReturnMoodAnalyser_ObjectUsingParametrizedConstructor()
        {
            //Act
            MoodAnalyser expectedObj = new MoodAnalyser("HAPPY");
            object resultObj = MoodAnalyserFactory.CreateMoodAnalyserUsingParameterizedConstructor("MoodAnalyserProblem.MoodAnalyser", "MoodAnalyser", "HAPPY");
            //Assert
            expectedObj.Equals(resultObj);
        }
        /// <summary>
        /// Givens the improper class name should throw mood analysis exception for parameterized constructor.
        /// </summary>
        [TestMethod]
        public void GivenImproperClassName_ShouldThrow_MoodAnalysisExceptionFor_ParameterizedConstructor()
        {
            try
            {
                ///Act
                MoodAnalyser expectedObj = new MoodAnalyser("HAPPY");
                object resultObj = MoodAnalyserFactory.CreateMoodAnalyserObject("Namespace.MoodAnalyser", "MoodAnalyser");
            }
            catch (MoodAnalysisCustomException exception)
            {
                ///Assert
                Assert.AreEqual("class not found", exception.Message);
            }
        }
        /// <summary>
        /// Givens the improper constructor name should throw mood analysis exception for parameterized constructor.
        /// </summary>
        [TestMethod]
        public void GivenImproperConstructorName_ShouldThrowMoodAnalysisException_ForParameterizedConstructor()
        {
            try
            {
                ///Act
                object resultObj = MoodAnalyserFactory.CreateMoodAnalyserObject("MoodAnalyse.MoodAnalyser", "ConstructorName");
            }
            catch (MoodAnalysisCustomException exception)
            {
                ///Assert
                Assert.AreEqual("constructor not found", exception.Message);
            }
        }

        /// <summary>
        /// Givens the happy message using reflection when proper should return happy.
        /// </summary>        
        [TestMethod]
        public void GivenHappyMessageUsingReflection_WhenProper_ShouldReturnHappy()
        {
            ///Arrange
            string messgae = "HAPPY";

            ///Act
            string result = MoodAnalyserFactory.InvokeAnalyseMood(messgae, "AnalyseMood");

            ///Assert
            Assert.AreEqual(messgae, result);

        }
        /// <summary>
        /// Given improper method name should throw mood analysis exception.
        /// </summary>
        [TestMethod]
        public void GivenImproperMethodName_Should_ThrowMoodAnalysisException()
        {
            try
            {
                ///Arrange
                string message = "HAPPY";
                string methodName = "AnalysisMood";
                ///Act
                string result = MoodAnalyserFactory.InvokeAnalyseMood(message, methodName);
            }
            catch (MoodAnalysisCustomException exception)
            {
                ///Assert
                Assert.AreEqual("Method not found.", exception.Message);
            }
        }
    }
}
