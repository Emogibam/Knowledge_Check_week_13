using Knowledge_Check_week_13;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing_week13_knolegde_check
{
    public class TestingQuestionFour
    {

        [Fact]
        public void EmptyArray_ReturnsZero()
        {
            int[] collection = { };
            int result = QuestionFour.MostFrequentItemCount(collection);
            Assert.Equal(0, result);
        }

        [Fact]
        public void SingleItemArray_ReturnsOne()
        {
            int[] collection = { 5 };
            int result = QuestionFour.MostFrequentItemCount(collection);
            Assert.Equal(1, result);
        }

        [Fact]
        public void ArrayWithUniqueItems_ReturnsOne()
        {
            int[] collection = { 1, 2, 3, 4, 5 };
            int result = QuestionFour.MostFrequentItemCount(collection);
            Assert.Equal(1, result);
        }

        [Fact]
        public void ArrayWithMultipleOccurrences_ReturnsCorrectCount()
        {
            int[] collection = { 1, 2, 2, 3, 3, 3, 4, 4, 4, 4 };
            int result = QuestionFour.MostFrequentItemCount(collection);
            Assert.Equal(4, result);
        }

        [Fact]
        public void ArrayWithNegativeItems_ReturnsCorrectCount()
        {
            int[] collection = { -1, -1, -1, -2, -2, -3 };
            int result = QuestionFour.MostFrequentItemCount(collection);
            Assert.Equal(3, result);
        }

        [Fact]
        public void ArrayWithZero_ReturnsOne()
        {
            int[] collection = { 0, 0, 0, 0, 0 };
            int result = QuestionFour.MostFrequentItemCount(collection);
            Assert.Equal(5, result);
        }

        [Fact]
        public void ArrayWithAllEqualItems_ReturnsCountOfAllItems()
        {
            int[] collection = { 9, 9, 9, 9, 9, 9, 9, 9, 9 };
            int result = QuestionFour.MostFrequentItemCount(collection);
            Assert.Equal(9, result);
        }

        [Fact]
        public void ArrayWithMostFrequentItemAtBeginning_ReturnsCorrectCount()
        {
            int[] collection = { 3, 3, 3, 2, 2, 1 };
            int result = QuestionFour.MostFrequentItemCount(collection);
            Assert.Equal(3, result);
        }

        [Fact]
        public void ArrayWithMostFrequentItemAtEnd_ReturnsCorrectCount()
        {
            int[] collection = { 1, 2, 2, 3, 3, 3 };
            int result = QuestionFour.MostFrequentItemCount(collection);
            Assert.Equal(3, result);
        }

        [Fact]
        public void ArrayWithMostFrequentItemAtMiddle_ReturnsCorrectCount()
        {
            int[] collection = { 1, 2, 2, 3, 3, 3, 2 };
            int result = QuestionFour.MostFrequentItemCount(collection);
            Assert.Equal(3, result);
        }

        [Fact]
        public void ArrayWithNegativeAndPositiveItems_ReturnsCorrectCount()
        {
            int[] collection = { -1, 1, -1, 1, -1, 1, -1 };
            int result = QuestionFour.MostFrequentItemCount(collection);
            Assert.Equal(4, result);
        }

        [Fact]
        public void ArrayWithDuplicateItems_ReturnsCorrectCount()
        {
            int[] collection = { 2, 2, 2, 2, 2, 2 };
            int result = QuestionFour.MostFrequentItemCount(collection);
            Assert.Equal(6, result);
        }

        [Fact]
        public void ArrayWithAllNegativeItems_ReturnsCountOfAllItems()
        {
            int[] collection = { -3, -3, -3, -3 };
            int result = QuestionFour.MostFrequentItemCount(collection);
            Assert.Equal(4, result);
        }

        [Fact]
        public void ArrayWithAllPositiveItems_ReturnsCountOfAllItems()
        {
            int[] collection = { 7, 7, 7, 7 };
            int result = QuestionFour.MostFrequentItemCount(collection);
            Assert.Equal(4, result);
        }

        [Fact]
        public void ArrayWithMultipleMostFrequentItems_ReturnsCountOfOneItem()
        {
            int[] collection = { 1, 1, 2, 2, 3, 3 };
            int result = QuestionFour.MostFrequentItemCount(collection);
            Assert.Equal(2, result);
        }
    }

}

