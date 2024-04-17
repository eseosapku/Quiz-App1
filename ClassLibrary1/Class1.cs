using NUnit.Framework;
using Quiz_App1;
using QuizApp;

namespace QuizApp.Tests
{
    [TestFixture]
    public class QuizSelectionFormTests
    {
        [Test]
        public void LoadQuestion_ShouldLoadFirstQuestion_WhenFormInitialized()
        {
            // Arrange
            var form = new QuizSelectionForm(null); // Pass null as the parent form for testing purposes

            // Act
            form.LoadQuestion();

            // Assert
            Assert.AreEqual("What is the fastest land animal?", form.lblQuestion.Text);
        }

        [Test]
        public void GetSelectedAnswer_ShouldReturnCorrectAnswer_WhenOption1Checked()
        {
            // Arrange
            var form = new QuizSelectionForm(null); // Pass null as the parent form for testing purposes
            form.Option1.Checked = true;

            // Act
            var selectedAnswer = form.GetSelectedAnswer();

            // Assert
            Assert.AreEqual("A", selectedAnswer);
        }

        [Test]
        public void GetSelectedAnswer_ShouldThrowException_WhenNoOptionChecked()
        {
            // Arrange
            var form = new QuizSelectionForm(null); // Pass null as the parent form for testing purposes
            form.Option1.Checked = false;
            form.Option2.Checked = false;
            form.Option3.Checked = false;
            form.Option4.Checked = false;

            // Act & Assert
            Assert.Throws<InvalidOperationException>(() => form.GetSelectedAnswer());
        }

        // Add more tests for other methods and scenarios as needed
    }
}
