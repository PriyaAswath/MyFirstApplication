using System.Collections.Generic;
using Xunit;

namespace XUnitTestDemo
{
           public class MathOperationTest
        {
            [Fact]
            public void CanAddFact()
            {
                var num1 = 2.9;
                var num2 = 3.1;
                var expectedValue = 6;

                var sum = MathOperation.Add(num1, num2);

                Assert.Equal(expectedValue, sum, 1);
            }


             [Theory]
             [InlineData(1.1, 2.2, 3.3)]
             [InlineData(-4, -6, -10)]
             [InlineData(-2, 2, 0)]
        public void CanAddTheory(int value1, int value2, int expected)
           { 
            var result = MathOperation.Add(value1, value2);

            Assert.Equal(expected, result);
        }


        [Theory]
        [ClassData(typeof(MathOpsTestData))]
        public void CanAddTheoryClassData(int value1, int value2, int expected)
        {

            var result = MathOperation.Add(value1, value2);

            Assert.Equal(expected, result);
        }


        [Theory]
        [MemberData(nameof(TestData))]
        public void CanAddTheoryDataProperty(int value1, int value2, int expected)
        {
          
            var result = MathOperation.Add(value1, value2);

            Assert.Equal(expected, result);
        }

        public static IEnumerable<object[]> TestData =>
            new List<object[]>
            {
            new object[] { 1, 2, 3 },
            new object[] { -4, -6, -10 },
            new object[] { -2, 2, 0 },
            };
    }
}