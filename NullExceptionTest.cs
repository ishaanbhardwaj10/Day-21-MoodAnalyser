using MoodAnalyserExceptionProblem;

namespace MoodAnalyserExceptionTest
{
    [TestClass]
    public class NullExceptionTest
    {
        [TestMethod]
        [DataRow(null)]
        public void NullSenarioReturnHappy(string message)
        {
            //Arrange
            string expected = "HAPPY";

            //Act
            MoodAnalyser moodAnalyser = new MoodAnalyser(message);
            var result = moodAnalyser.analyseMood();

            //Assert
            Assert.AreEqual(expected, result);
        }
    }
}