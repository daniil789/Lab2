using System;
using Xunit;
using Lab2;

namespace Lab2Test
{
    public class UnitTest1
    {
        [Fact]
        public void FindCountEvenElementsTest()
        {
            int[] array = CreateArray();
            int count = Program.FindCountEvenElements(array);
            Assert.Equal(5, count);
        }

        [Fact]
        public void FindIndexMinText()
        {
            int[] array = CreateArray();
            int minIndex = Program.FindIndexMin(array);
            Assert.Equal(0, minIndex);
        }

        public int[] CreateArray()
        {
            int[] array = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            return array;
        }
    }
}
