using Knowledge_Check_week_13;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing_week13_knolegde_check
{
    public class TestingQUestionThree
    {

        [Fact]
        public void CountDistinctItems_EmptyString_ReturnsEmptyDictionary()
        {
            // Arrange
            string input = "";

            // Act
            var result = QuestionThree.CountDistinctItems(input);

            // Assert
            Assert.Empty(result);
        }

        [Fact]
        public void CountDistinctItems_SingleCharacterString_ReturnsDictionaryWithSingleItem()
        {
            // Arrange
            string input = "a";

            // Act
            var result = QuestionThree.CountDistinctItems(input);

            // Assert
            Assert.Single(result);
            Assert.Equal(1, result['a']);
        }

        [Fact]
        public void CountDistinctItems_SingleCharacterStringWithDuplicates_ReturnsDictionaryWithSingleItem()
        {
            // Arrange
            string input = "aaaaa";

            // Act
            var result = QuestionThree.CountDistinctItems(input);

            // Assert
            Assert.Single(result);
            Assert.Equal(5, result['a']);
        }

        [Fact]
        public void CountDistinctItems_MultipleCharactersString_ReturnsDictionaryWithCorrectCounts()
        {
            // Arrange
            string input = "abcde";

            // Act
            var result = QuestionThree.CountDistinctItems(input);

            // Assert
            Assert.Equal(5, result.Count);
            Assert.Equal(1, result['a']);
            Assert.Equal(1, result['b']);
            Assert.Equal(1, result['c']);
            Assert.Equal(1, result['d']);
            Assert.Equal(1, result['e']);
        }

        [Fact]
        public void CountDistinctItems_MultipleCharactersStringWithDuplicates_ReturnsDictionaryWithCorrectCounts()
        {
            // Arrange
            string input = "aabbcc";

            // Act
            var result = QuestionThree.CountDistinctItems(input);

            // Assert
            Assert.Equal(3, result.Count);
            Assert.Equal(2, result['a']);
            Assert.Equal(2, result['b']);
            Assert.Equal(2, result['c']);
        }

        [Fact]
        public void CountDistinctItems_StringWithSpecialCharacters_ReturnsDictionaryWithCorrectCounts()
        {
            // Arrange
            string input = "Hello, World!";

            // Act
            var result = QuestionThree.CountDistinctItems(input);

            // Assert
            Assert.Equal(10, result.Count);
            Assert.Equal(1, result['H']);
            Assert.Equal(1, result['e']);
            Assert.Equal(3, result['l']);
            Assert.Equal(2, result['o']);
            Assert.Equal(1, result[',']);
            Assert.Equal(1, result[' ']);
            Assert.Equal(1, result['W']);
            Assert.Equal(1, result['r']);
            Assert.Equal(1, result['d']);
            Assert.Equal(1, result['!']);
        }

        [Fact]
        public void CountDistinctItems_StringWithNumbers_ReturnsDictionaryWithCorrectCounts()
        {
            // Arrange
            string input = "1234567890";

            // Act
            var result = QuestionThree.CountDistinctItems(input);

            // Assert
            Assert.Equal(10, result.Count);
            Assert.Equal(1, result['1']);
            Assert.Equal(1, result['2']);
            Assert.Equal(1, result['3']);
            Assert.Equal(1, result['4']);
            Assert.Equal(1, result['5']);
            Assert.Equal(1, result['6']);
            Assert.Equal(1, result['7']);
            Assert.Equal(1, result['8']);
            Assert.Equal(1, result['9']);
            Assert.Equal(1, result['0']);
        }
  
        [Fact]
        public void CountDistinctItems_LongStringWithRepeatedPattern_ReturnsDictionaryWithCorrectCounts()
        {
            // Arrange
            string input = "abcabcabcabc";

            // Act
            var result = QuestionThree.CountDistinctItems(input);

            // Assert
            Assert.Equal(3, result.Count);
            Assert.Equal(4, result['a']);
            Assert.Equal(4, result['b']);
            Assert.Equal(4, result['c']);
        }

        [Fact]
        public void CountDistinctItems_StringWithMixedCase_ReturnsDictionaryWithCorrectCounts()
        {
            // Arrange
            string input = "AbCdeFGhiJKlmNoPqRsTUVwxyZ";

            // Act
            var result = QuestionThree.CountDistinctItems(input);

            // Assert
            Assert.Equal(26, result.Count);
            Assert.Equal(1, result['A']);
            Assert.Equal(1, result['b']);
            Assert.Equal(1, result['C']);
            Assert.Equal(1, result['d']);
            Assert.Equal(1, result['e']);
            Assert.Equal(1, result['F']);
            Assert.Equal(1, result['G']);
            Assert.Equal(1, result['h']);
            Assert.Equal(1, result['i']);
            Assert.Equal(1, result['J']);
            Assert.Equal(1, result['K']);
            Assert.Equal(1, result['l']);
            Assert.Equal(1, result['m']);
            Assert.Equal(1, result['N']);
            Assert.Equal(1, result['o']);
            Assert.Equal(1, result['P']);
            Assert.Equal(1, result['q']);
            Assert.Equal(1, result['R']);
            Assert.Equal(1, result['s']);
            Assert.Equal(1, result['T']);
            Assert.Equal(1, result['U']);
            Assert.Equal(1, result['V']);
            Assert.Equal(1, result['w']);
            Assert.Equal(1, result['x']);
            Assert.Equal(1, result['y']);
            Assert.Equal(1, result['Z']);
        }
      



        [Fact]
        public void CountDistinctItems_StringWithDuplicateCharacters_ReturnsDictionaryWithCorrectCounts()
        {
            // Arrange
            string input = "aabbccddee";

            // Act
            var result = QuestionThree.CountDistinctItems(input);

            // Assert
            Assert.Equal(5, result.Count);
            Assert.Equal(2, result['a']);
            Assert.Equal(2, result['b']);
            Assert.Equal(2, result['c']);
            Assert.Equal(2, result['d']);
            Assert.Equal(2, result['e']);
        }

 

        [Fact]
        public void CountDistinctItems_StringWithMultipleSpecialCharacters_ReturnsDictionaryWithCorrectCounts()
        {
            // Arrange
            string input = "!@#$%^&*()";

            // Act
            var result = QuestionThree.CountDistinctItems(input);

            // Assert
            Assert.Equal(10, result.Count);
            Assert.Equal(1, result['!']);
            Assert.Equal(1, result['@']);
            Assert.Equal(1, result['#']);
            Assert.Equal(1, result['$']);
            Assert.Equal(1, result['%']);
            Assert.Equal(1, result['^']);
            Assert.Equal(1, result['&']);
            Assert.Equal(1, result['*']);
            Assert.Equal(1, result['(']);
            Assert.Equal(1, result[')']);
        }

        [Fact]
        public void CountDistinctItems_StringWithDuplicateSpecialCharacters_ReturnsDictionaryWithCorrectCounts()
        {
            // Arrange
            string input = "!!!&&&";

            // Act
            var result = QuestionThree.CountDistinctItems(input);

            // Assert
            Assert.Equal(2, result.Count);
            Assert.Equal(3, result['!']);
            Assert.Equal(3, result['&']);
        }

        [Fact]
        public void CountDistinctItems_StringWithNumbersAndLetters_ReturnsDictionaryWithCorrectCounts()
        {
            // Arrange
            string input = "a1b2c3d4e5";

            // Act
            var result = QuestionThree.CountDistinctItems(input);

            // Assert
            Assert.Equal(10, result.Count);
            Assert.Equal(1, result['a']);
            Assert.Equal(1, result['1']);
            Assert.Equal(1, result['b']);
            Assert.Equal(1, result['2']);
            Assert.Equal(1, result['c']);
            Assert.Equal(1, result['3']);
            Assert.Equal(1, result['d']);
            Assert.Equal(1, result['4']);
            Assert.Equal(1, result['e']);
            Assert.Equal(1, result['5']);
        }

        [Fact]
        public void CountDistinctItems_StringWithDuplicateNumbers_ReturnsDictionaryWithCorrectCounts()
        {
            // Arrange
            string input = "1122334455";

            // Act
            var result = QuestionThree.CountDistinctItems(input);

            // Assert
            Assert.Equal(5, result.Count);
            Assert.Equal(2, result['1']);
            Assert.Equal(2, result['2']);
            Assert.Equal(2, result['3']);
            Assert.Equal(2, result['4']);
            Assert.Equal(2, result['5']);
        }

        [Fact]
        public void CountDistinctItems_StringWithMixedCharacters_ReturnsDictionaryWithCorrectCounts()
        {
            // Arrange
            string input = "abc123!@#";

            // Act
            var result = QuestionThree.CountDistinctItems(input);

            // Assert
            Assert.Equal(9, result.Count);
            Assert.Equal(1, result['a']);
            Assert.Equal(1, result['b']);
            Assert.Equal(1, result['c']);
            Assert.Equal(1, result['1']);
            Assert.Equal(1, result['2']);
            Assert.Equal(1, result['3']);
            Assert.Equal(1, result['!']);
            Assert.Equal(1, result['@']);
            Assert.Equal(1, result['#']);
        }

     

        [Fact]
        public void CountDistinctItems_StringWithDuplicateEmptyStringCharacter_ReturnsDictionaryWithCorrectCounts()
        {
            // Arrange
            string input = "\0\0\0\0\0";

            // Act
            var result = QuestionThree.CountDistinctItems(input);

            // Assert
            Assert.Equal(1, result.Count);
            Assert.Equal(5, result['\0']);
        }

     

        [Fact]
        public void CountDistinctItems_StringWithDuplicateLineBreakCharacters_ReturnsDictionaryWithCorrectCounts()
        {
            // Arrange
            string input = "\n\n\n\n";

            // Act
            var result = QuestionThree.CountDistinctItems(input);

            // Assert
            Assert.Equal(1, result.Count);
            Assert.Equal(4, result['\n']);
        }


        [Fact]
        public void CountDistinctItems_StringWithSingleCharacter_ReturnsDictionaryWithSingleItem()
        {
            // Arrange
            string input = "a";

            // Act
            var result = QuestionThree.CountDistinctItems(input);

            // Assert
            Assert.Single(result);
            Assert.Equal(1, result['a']);
        }

        [Fact]
        public void CountDistinctItems_StringWithDuplicateSpecialCharactersAndWhitespace_ReturnsDictionaryWithCorrectCounts()
        {
            // Arrange
            string input = "!@#  !@#  ";

            // Act
            var result = QuestionThree.CountDistinctItems(input);

            // Assert
            Assert.Equal(4, result.Count);
            Assert.Equal(2, result['!']);
            Assert.Equal(2, result['@']);
            Assert.Equal(2, result['#']);
            Assert.Equal(4, result[' ']);
        }

      
        [Fact]
        public void CountDistinctItems_StringWithEmptyString_ReturnsEmptyDictionary()
        {
            // Arrange
            string input = string.Empty;

            // Act
            var result = QuestionThree.CountDistinctItems(input);

            // Assert
            Assert.Empty(result);
        }


     
    }

}




