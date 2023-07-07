using Knowledge_Check_week_13;

namespace Testing_week13_knolegde_check
{
    public class TestingQuestionOne
    {
        [Fact]

        public void ArrangeString_ValidInput_ReturnsArrangedString()
        {
            // Arrange
            int[] arr = { 1, 0, 3, 2 };
            string message = "abcd";

            // Act
            string result = QuestionOne.ArrangeTheStringAccordingToTheIndex(arr, message);

            // Assert
            Assert.Equal("badc", result);
        }

        [Fact]
        public void ArrangeString_EmptyInput_ReturnsErrorMessage()
        {
            // Arrange
            int[] arr = { };
            string message = "";

            // Act
            string result = QuestionOne.ArrangeTheStringAccordingToTheIndex(arr, message);

            // Assert
            Assert.Equal("Can't use the message", result);
        }

        [Fact]
        public void ArrangeString_DifferentLengths_ReturnsErrorMessage()
        {
            // Arrange
            int[] arr = { 0, 1, 2 };
            string message = "abcde";

            // Act
            string result = QuestionOne.ArrangeTheStringAccordingToTheIndex(arr, message);

            // Assert
            Assert.Equal("Can't use the message", result);
        }

        [Fact]
        public void ArrangeString_NullInput_ReturnsErrorMessage()
        {
            // Arrange
            int[] arr = null;
            string message = "abcd";

            // Act
            string result =QuestionOne.ArrangeTheStringAccordingToTheIndex(arr, message);

            // Assert
            Assert.Equal("Can't use the message", result);
        }

        [Fact]
        public void ArrangeString_WhitespaceInput_ReturnsErrorMessage()
        {
            // Arrange
            int[] arr = new int[] { 0, 1, 2 };
            string message = "   ";

            // Act
            string result = QuestionOne.ArrangeTheStringAccordingToTheIndex(arr, message);

            // Assert
            Assert.Equal("Can't use the message", result);
        }

        [Fact]
        public void ArrangeString_ValidInputWithRepeatingIndices_ReturnsArrangedString()
        {
            // Arrange
            int[] arr = { 0, 1, 0, 1 };
            string message = "abcd";

            // Act
            string result = QuestionOne.ArrangeTheStringAccordingToTheIndex(arr, message);

            // Assert
            Assert.Equal("Can't use the message", result);
        }

        [Fact]
        public void ArrangeString_ValidInputWithOutOfRangeIndex_ReturnsErrorMessage()
        {
            // Arrange
            int[] arr = { 0, 1, 4, 2 };
            string message = "abcd";

            // Act
            string result = QuestionOne.ArrangeTheStringAccordingToTheIndex(arr, message);

            // Assert
            Assert.Equal("Can't use the message", result);
        }

        [Fact]
        public void ArrangeString_ValidInputWithNegativeIndex_ReturnsErrorMessage()
        {
            // Arrange
            int[] arr = { 0, -1, 3, 2 };
            string message = "abcd";

            // Act
            string result = QuestionOne.ArrangeTheStringAccordingToTheIndex(arr, message);

            // Assert
            Assert.Equal("Can't use the message", result);
        }

        [Fact]
        public void ArrangeString_ValidInputWithEmptyString_ReturnsEmptyString()
        {
            // Arrange
            int[] arr = { 0, 1, 2, 3 };
            string message = "";

            // Act
            string result = QuestionOne.ArrangeTheStringAccordingToTheIndex(arr, message);

            // Assert
            Assert.Equal("Can't use the message", result);
        }

        [Fact]
        public void ArrangeString_ValidInputWithSameIndices_ReturnsOriginalString()
        {
            // Arrange
            int[] arr = { 0, 0, 0, 0 };
            string message = "abcd";

            // Act
            string result = QuestionOne.ArrangeTheStringAccordingToTheIndex(arr, message);

            // Assert
            Assert.Equal("Can't use the message", result);
        }

        [Fact]
        public void ArrangeString_NullArray_ReturnsErrorMessage()
        {
            // Arrange
            int[] arr = null;
            string message = "abcd";

            // Act
            string result = QuestionOne.ArrangeTheStringAccordingToTheIndex(arr, message);

            // Assert
            Assert.Equal("Can't use the message", result);
        }

        [Fact]
        public void ArrangeString_ValidInputWithDuplicateIndices_ReturnsArrangedString()
        {
            // Arrange
            int[] arr = { 0, 1, 0, 2 };
            string message = "abcd";

            // Act
            string result = QuestionOne.ArrangeTheStringAccordingToTheIndex(arr, message);

            // Assert
            Assert.Equal("Can't use the message", result);
        }

        [Fact]
        public void ArrangeString_ValidInputWithSortedIndices_ReturnsArrangedString()
        {
            // Arrange
            int[] arr = { 0, 1, 2, 3 };
            string message = "dcba";

            // Act
            string result = QuestionOne.ArrangeTheStringAccordingToTheIndex(arr, message);

            // Assert
            Assert.Equal("dcba", result);
        }

        [Fact]
        public void ArrangeString_ValidInputWithReverseSortedIndices_ReturnsArrangedString()
        {
            // Arrange
            int[] arr = { 3, 2, 1, 0 };
            string message = "abcd";

            // Act
            string result = QuestionOne.ArrangeTheStringAccordingToTheIndex(arr, message);

            // Assert
            Assert.Equal("dcba", result);
        }

        [Fact]
        public void ArrangeString_ValidInputWithNegativeIndices_ReturnsErrorMessage()
        {
            // Arrange
            int[] arr = { 0, -1, 2, 3 };
            string message = "abcd";

            // Act
            string result = QuestionOne.ArrangeTheStringAccordingToTheIndex(arr, message);

            // Assert
            Assert.Equal("Can't use the message", result);
        }

        [Fact]
        public void ArrangeString_ValidInputWithOutOfRangeIndices_ReturnsErrorMessage()
        {
            // Arrange
            int[] arr = { 0, 1, 2, 4 };
            string message = "abcd";

            // Act
            string result = QuestionOne.ArrangeTheStringAccordingToTheIndex(arr, message);

            // Assert
            Assert.Equal("Can't use the message", result);
        }

        [Fact]
        public void ArrangeString_ValidInputWithEmptyMessage_ReturnsEmptyString()
        {
            // Arrange
            int[] arr = { 0, 1, 2, 3 };
            string message = "";

            // Act
            string result = QuestionOne.ArrangeTheStringAccordingToTheIndex(arr, message);

            // Assert
            Assert.Equal("Can't use the message", result);
        }

        [Fact]
        public void ArrangeString_ValidInputWithWhiteSpaceMessage_ReturnsArrangedString()
        {
            // Arrange
            int[] arr = { 0, 1, 2, 3 };
            string message = "   abcd   ";

            // Act
            string result = QuestionOne.ArrangeTheStringAccordingToTheIndex(arr, message);

            // Assert
            Assert.Equal("abcd", result);
        }

        [Fact]
        public void ArrangeString_ValidInputWithLargeArraySize_ReturnsArrangedString()
        {
            // Arrange
            int[] arr = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            string message = "abcdefghij";

            // Act
            string result = QuestionOne.ArrangeTheStringAccordingToTheIndex(arr, message);

            // Assert
            Assert.Equal("abcdefghij", result);
        }

        [Fact]
        public void ArrangeString_ValidInputWithLargeMessageSize_ReturnsArrangedString()
        {
            // Arrange
            int[] arr = { 0, 1, 2, 3 };
            string message = "abcdefghijklmnopqrstuvwxyz";

            // Act
            string result = QuestionOne.ArrangeTheStringAccordingToTheIndex(arr, message);

            // Assert
            Assert.Equal("Can't use the message", result);
        }
    }

}


