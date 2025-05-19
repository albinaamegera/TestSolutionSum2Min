namespace UnitTestsIsSolutionShould
{

    [TestClass]
    public class Test_IsSolutionSumToMinShould
    {
        [DataTestMethod]
        [DynamicData(nameof(TestDataCollectionsAndResults), DynamicDataSourceType.Method)]
        public void Get_IntCollection_ReturnsSumOfTwoMins(IEnumerable<int> ints, int expected)
        {
            var calculator = CreateDefaultSum2MinCalculator();

            var actual = calculator.SumOfTwoMinNumbers(ints);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Get_Null_ThrowsNullReferenceException()
        {
            var calculator = CreateDefaultSum2MinCalculator();

            Action actual = () => calculator.SumOfTwoMinNumbers(null);

            Assert.ThrowsException<NullReferenceException>(actual);
        }

        [TestMethod]
        public void Get_EmptyCollection_ThrowsArgumentOutOfRangeException()
        {
            var calculator = CreateDefaultSum2MinCalculator();

            Action actual = () => calculator.SumOfTwoMinNumbers(Array.Empty<int>());

            Assert.ThrowsException<ArgumentOutOfRangeException>(actual);
        }

        [DataTestMethod]
        [DataRow(new int[] { 10 })]
        [DataRow(new int[] { int.MaxValue })]
        public void Get_OneNumberCollection_ThrowsArgumentOutOfRangeException(int[] ints)
        {
            var calculator = CreateDefaultSum2MinCalculator();

            Action actual = () => calculator.SumOfTwoMinNumbers(ints);

            Assert.ThrowsException<ArgumentOutOfRangeException>(actual);
        }

        [DataTestMethod]
        [DataRow(new int[] { int.MinValue, int.MinValue })]
        [DataRow(new int[] { int.MaxValue, int.MaxValue })]
        public void Check_OverflowResult_ThrowsOverflowException(int[] ints)
        {
            var calculator = CreateDefaultSum2MinCalculator();

            Action actual = () => calculator.SumOfTwoMinNumbers(ints);

            Assert.ThrowsException<OverflowException>(actual);
        }

        private Sum2MinCalculator CreateDefaultSum2MinCalculator() => new Sum2MinCalculator();

        private static IEnumerable<object[]> TestDataCollectionsAndResults()
        {
            yield return new object[] { new int[] { -2, -1, 0, 1, 2 }, -3 };
            yield return new object[] { new int[] { 4, 0, 3, 19, 492, -10, 1 }, -10 };
            yield return new object[] { new int[] { 0, 3, 5, 19, -100, -11, 19 }, -111 };
            yield return new object[] { new int[] { 72, 100, 598, 29, 134, 8, 1003, 9, 56, 32, 17 }, 17 };
            yield return new object[] { GenerateNumbers(1_000_000), 2 };
            yield return new object[] { GenerateNumbers(1_000_000_000), 2 };

            IEnumerable<int> GenerateNumbers(long count)
            {
                for (int i = 0; i < count; i++)
                {
                    yield return 1;
                }
            }
        }
    }
}
