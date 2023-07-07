using Knowledge_Check_week_13;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing_week13_knolegde_check
{
    public class TestingQuestionTwo
    {
        [Fact]
        public void AlternateCase_EmptyString_ReturnsEmptyString()
        {
            // Arrange
            string input = "";

            // Act
            string result = QuestionTwo.AlternativeCase(input);

            // Assert
            Assert.Equal("", result);
        }

        [Fact]
        public void AlternateCase_AllLowerCase_ReturnsAllUpperCase()
        {
            // Arrange
            string input = "hello world";

            // Act
            string result = QuestionTwo.AlternativeCase(input);

            // Assert
            Assert.Equal("HELLO WORLD", result);
        }

        [Fact]
        public void AlternateCase_AllUpperCase_ReturnsAllLowerCase()
        {
            // Arrange
            string input = "HELLO WORLD";

            // Act
            string result = QuestionTwo.AlternativeCase(input);

            // Assert
            Assert.Equal("hello world", result);
        }

        [Fact]
        public void AlternateCase_MixedCase_ReturnsSwitchedCase()
        {
            // Arrange
            string input = "HeLlO wOrLd";

            // Act
            string result = QuestionTwo.AlternativeCase(input);

            // Assert
            Assert.Equal("hElLo WoRlD", result);
        }

        [Fact]
        public void AlternateCase_SingleCharacterLowerCase_ReturnsUpperCase()
        {
            // Arrange
            string input = "a";

            // Act
            string result = QuestionTwo.AlternativeCase(input);

            // Assert
            Assert.Equal("A", result);
        }

        [Fact]
        public void AlternateCase_SingleCharacterUpperCase_ReturnsLowerCase()
        {
            // Arrange
            string input = "Z";

            // Act
            string result = QuestionTwo.AlternativeCase(input);

            // Assert
            Assert.Equal("z", result);
        }

        [Fact]
        public void AlternateCase_NumericString_ReturnsSameString()
        {
            // Arrange
            string input = "12345";

            // Act
            string result = QuestionTwo.AlternativeCase(input);

            // Assert
            Assert.Equal("12345", result);
        }

        [Fact]
        public void AlternateCase_SpecialCharacters_ReturnsSameString()
        {
            // Arrange
            string input = "!@#$%^&*()";

            // Act
            string result = QuestionTwo.AlternativeCase(input);

            // Assert
            Assert.Equal("!@#$%^&*()", result);
        }

        [Fact]
        public void AlternateCase_WhitespaceString_ReturnsSameString()
        {
            // Arrange
            string input = "   ";

            // Act
            string result = QuestionTwo.AlternativeCase(input);

            // Assert
            Assert.Equal("   ", result);
        }

        [Fact]
        public void AlternateCase_StringWithLeadingAndTrailingWhitespace_ReturnsSameString()
        {
            // Arrange
            string input = "  Hello World  ";

            // Act
            string result = QuestionTwo.AlternativeCase(input);

            // Assert
            Assert.Equal("  hELLO wORLD  ", result);
        }

        [Fact]
        public void AlternateCase_StringWithMixedWhitespace_ReturnsSameStringWithSwitchedCase()
        {
            // Arrange
            string input = "\tHello \nWorld";

            // Act
            string result = QuestionTwo.AlternativeCase(input);

            // Assert
            Assert.Equal("\thELLO \nwORLD", result);
        }

        [Fact]
        public void AlternateCase_StringWithPunctuation_ReturnsSameString()
        {
            // Arrange
            string input = "Hello, World!";

            // Act
            string result = QuestionTwo.AlternativeCase(input);

            // Assert
            Assert.Equal("hELLO, wORLD!", result);
        }

        [Fact]
        public void AlternateCase_LongStringWithMixedCase_ReturnsSwitchedCase()
        {
            // Arrange
            string input = "Lorem Ipsum is simply dummy text of the printing and typesetting industry.";

            // Act
            string result = QuestionTwo.AlternativeCase(input);

            // Assert
            Assert.Equal("lOREM iPSUM IS SIMPLY DUMMY TEXT OF THE PRINTING AND TYPESETTING INDUSTRY.", result);
        }


        [Fact]
        public void AlternateCase_StringWithEmojis_ReturnsSameString()
        {
            // Arrange
            string input = "😀🌍";

            // Act
            string result = QuestionTwo.AlternativeCase(input);

            // Assert
            Assert.Equal("😀🌍", result);
        }

        [Fact]
        public void AlternateCase_StringWithAccentedCharacters_ReturnsSwitchedCase()
        {
            // Arrange
            string input = "Élève à l'École";

            // Act
            string result = QuestionTwo.AlternativeCase(input);

            // Assert
            Assert.Equal("éLÈVE À L'éCOLE", result);
        }

        [Fact]
        public void AlternateCase_StringWithMixedSymbolsAndLetters_ReturnsSameStringWithSwitchedCase()
        {
            // Arrange
            string input = "!@#$%^aBcDeF";

            // Act
            string result = QuestionTwo.AlternativeCase(input);

            // Assert
            Assert.Equal("!@#$%^AbCdEf", result);
        }

        [Fact]
        public void AlternateCase_StringWithMultipleSpacesBetweenWords_ReturnsSameStringWithSwitchedCase()
        {
            // Arrange
            string input = "Hello        World";

            // Act
            string result = QuestionTwo.AlternativeCase(input);

            // Assert
            Assert.Equal("hELLO        wORLD", result);
        }

        [Fact]
        public void AlternateCase_StringWithNonLetterCharacters_ReturnsSameString()
        {
            // Arrange
            string input = "123abc!@#";

            // Act
            string result = QuestionTwo.AlternativeCase(input);

            // Assert
            Assert.Equal("123ABC!@#", result);
        }

        [Fact]
        public void AlternateCase_StringWithSingleSpace_ReturnsSameString()
        {
            // Arrange
            string input = " ";

            // Act
            string result = QuestionTwo.AlternativeCase(input);

            // Assert
            Assert.Equal(" ", result);
        }

        [Fact]
        public void AlternateCase_StringWithTabs_ReturnsSameString()
        {
            // Arrange
            string input = "\t\t\t";

            // Act
            string result = QuestionTwo.AlternativeCase(input);

            // Assert
            Assert.Equal("\t\t\t", result);
        }

        [Fact]
        public void AlternateCase_StringWithMixedLineBreaksAndTabs_ReturnsSameString()
        {
            // Arrange
            string input = "Hello\n\tWorld";

            // Act
            string result = QuestionTwo.AlternativeCase(input);

            // Assert
            Assert.Equal("hELLO\n\twORLD", result);
        }

        [Fact]
        public void AlternateCase_StringWithLeadingDigits_ReturnsSameString()
        {
            // Arrange
            string input = "123Hello";

            // Act
            string result = QuestionTwo.AlternativeCase(input);

            // Assert
            Assert.Equal("123hELLO", result);
        }

        [Fact]
        public void AlternateCase_StringWithTrailingDigits_ReturnsSameString()
        {
            // Arrange
            string input = "Hello123";

            // Act
            string result = QuestionTwo.AlternativeCase(input);

            // Assert
            Assert.Equal("hELLO123", result);
        }

        [Fact]
        public void AlternateCase_StringWithDigitsInTheMiddle_ReturnsSameString()
        {
            // Arrange
            string input = "He1llo2Wo3rld";

            // Act
            string result = QuestionTwo.AlternativeCase(input);

            // Assert
            Assert.Equal("hE1LLO2wO3RLD", result);
        }

        [Fact]
        public void AlternateCase_StringWithOnlyNumbersAndWhitespace_ReturnsSameString()
        {
            // Arrange
            string input = "  123 456 789  ";

            // Act
            string result = QuestionTwo.AlternativeCase(input);

            // Assert
            Assert.Equal("  123 456 789  ", result);
        }
    }

}



