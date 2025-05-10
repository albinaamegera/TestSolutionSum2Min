namespace TestSolution
{
    [TestClass]
    public class SolutionTests
    {
        public Solution solution = new();

        [TestMethod]
        public void TestWnenNumbersIsExampleCollection()
        {
            int[] numbers = { 4, 0, 3, 19, 492, -10, 1 };
            int expected = -10;

            int actial = solution.SumOfTwoMinNumbers(numbers);
            Assert.AreEqual(expected, actial);
        }

        [TestMethod]
        public void TestWhenCollectionIsNull()
        {
            int[] numbers = null;

            Assert.ThrowsException<NullReferenceException>(() => solution.SumOfTwoMinNumbers(numbers));
        }

        [TestMethod]
        public void TestWhenCollectionIsEmpty()
        {
            int[] numbers = { };

            Assert.ThrowsException<ArgumentOutOfRangeException>(() => solution.SumOfTwoMinNumbers(numbers)); 
        }

        [TestMethod]
        public void TestWhenCollectionHasLessThenTwoNumbers()
        {
            int[] numbers = { 1 };

            Assert.ThrowsException<ArgumentOutOfRangeException>(() => solution.SumOfTwoMinNumbers(numbers));
        }

        [TestMethod]
        public void TestWhenCollectionHasHundredMillionNumbers()
        {
            int[] numbers = new int[100_000_000];

            int min1 = int.MaxValue;
            int min2 = int.MaxValue;
            int num;

            Random random = new();

            for (int i = 0; i < numbers.Length; i++)
            {
                num = random.Next(int.MinValue, int.MaxValue);

                if (num < min1)
                {
                    min2 = min1;
                    min1 = num;
                }
                else if (num < min2)
                {
                    min2 = num;
                }
                numbers[i] = num;
            }

            int expected = min1 + min2;
            int actial = solution.SumOfTwoMinNumbers(numbers);

            Assert.AreEqual(expected, actial);
        }
    }
}
