using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace NumAnalyzer
{
    public class NumAnalyzerTest
    {
        [Theory]
        [InlineData("")]
        [InlineData("Odd")]
        [InlineData("Even and less than 25")]
        [InlineData("Even")]
        [InlineData("Even")]
        [InlineData("Odd")]

        public void TestNumbers(string expected)
        {
            NumberAnalyzer nma = new NumberAnalyzer();

            string actual = nma.GetNumber(expected);

            Assert.Equal(expected, actual);
        }
    }
}
