using Xunit;

namespace Sorter.Test
{
    public class IntegerSorterTests
    {
        [Theory]
        [InlineData(2678, 6287)]
        [InlineData(913, 193)]
        [InlineData(914, 194)]
        public void Test1(int givenNumber, int expectedNumber)
        {
            var result = IntegerSorter.Sort(givenNumber);
            Assert.Equal(expectedNumber, result);
        }
    }
}
