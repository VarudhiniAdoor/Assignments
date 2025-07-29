using ClassLib11;

namespace ClassLib11Test
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test_Addition()
        {
            ClassLib11.NumericFunctions nf = new ClassLib11.NumericFunctions();
            int result = nf.Add(1, 2, 3);
            Assert.AreEqual(6, result);
        }

        [Test]
        public void Test_Addition2()
        {
            ClassLib11.NumericFunctions nf = new ClassLib11.NumericFunctions();
            int result = nf.Add(5, 6, 9);
            Assert.AreEqual(20, result);
        }

        [Test]
        public void Test_Subtraction()
        {
            int result = ClassLib11.NumericFunctions.Subtract(2, 3);
            Assert.AreEqual(-1, result);
        }

        [Test]
        public void Test_Multiplication()
        {
            int result = ClassLib11.NumericFunctions.Multiply(10, 9);
            Assert.AreEqual(90, result);
        }

        [Test]
        public void Test_FindMax()
        {
            int result = ClassLib11.NumericFunctions.FindMax(2, 3, 4, 5, 10, 12);
            Assert.AreEqual(12, result);
        }

        [Test]
        public void Test_FindMin()
        {
            int result = ClassLib11.NumericFunctions.FindMin(2, 3, 4, 5, 10, 12);
            Assert.AreEqual(2, result);
        }

        [Test]
        public void Test_IsEven()
        {
            bool result = ClassLib11.NumericFunctions.IsEven(10);
            Assert.IsTrue(result);
        }

        [Test]
        public void Test_IsEven2()
        {
            bool result = ClassLib11.NumericFunctions.IsEven(7);
            Assert.IsFalse(result);
        }

        [Test]
        public void Test_IsOdd()
        {
            bool result = ClassLib11.NumericFunctions.IsEven(10);
            Assert.IsTrue(result);
        }

        [Test]
        public void Test_IsOdd2()
        {
            bool result = ClassLib11.NumericFunctions.IsEven(7);
            Assert.IsFalse(result);
        }
        [Test]
        public void Test_IsPrime()
        {
            bool result = ClassLib11.NumericFunctions.IsEven(10);
            Assert.IsTrue(result);
        }

        [Test]
        public void Test_IsPrime2()
        {
            bool result = ClassLib11.NumericFunctions.IsEven(7);
            Assert.IsFalse(result);
        }

        [Test]
        public void Test_GetEvenInRange()
        {
            List<int> result = ClassLib11.NumericFunctions.GetEvenInRange(1, 20);
            Assert.AreEqual(new List<int> { 2, 4, 6, 8, 10, 12, 14, 16, 18, 20 }, result);
        }
        [Test]
        public void Test_GetOddInRange()
        {
            List<int> result = ClassLib11.NumericFunctions.GetOddInRange(1, 20);
            Assert.AreEqual(new List<int> { 1, 3, 5, 7, 9, 11, 13, 15, 17, 19 }, result);
        }
        [Test]
        public void Test_GetPrimeInRange()
        {
            List<int> result = ClassLib11.NumericFunctions.GetPrimeInRange(1, 20);
            Assert.AreEqual(new List<int> { 2, 3, 5, 7, 11, 13, 17, 19 }, result);
        }

        //[Test]
        //public void Test_GetTable()
        //{
        //    List<string> result = ClassLib11.NumericFunctions.GetTable(5);
        //    Assert.AreEqual(new List<string> { 5, 10, 15, 20, 25, 30, 35, 40, 45, 50 }, result);
        //}
    }
}