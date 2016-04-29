using System.Models;
using Xunit;

namespace MeriEDucation.Tests
{
    public class QuizTest
    {
        [Fact]
        public void GetGradeTest()
        {
            //Arrange
            var quiz = new Quiz();

            quiz.Grade = 7;

            //Act
            var result = quiz.Grade;

            //Assert
            Assert.Equal(7, result);
        }
    }
}