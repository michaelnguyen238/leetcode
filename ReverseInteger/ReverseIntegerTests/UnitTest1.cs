using System;
using Xunit;
using System.IO;
using System.Collections.Generic;

namespace ReverseIntegerTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(123)]
        [InlineData(-123)]
        [InlineData(120)]
        [InlineData(0)]
        [InlineData(-2147483648)]
        public void TestInput(int input)
        {
            Dictionary<int, int> expectedResults = new Dictionary<int, int>
            {
                { 123, 321 },
                { -123, -321 },
                { 120, 21 },
                { 0, 0 },
                { -2147483648, 0 }
            };

            int reversedInput = ReverseInteger.Program.Reverse(input);
            expectedResults.TryGetValue(input, out int expectedValue);

            Assert.Equal(expectedValue, reversedInput);
        }
    }
}
