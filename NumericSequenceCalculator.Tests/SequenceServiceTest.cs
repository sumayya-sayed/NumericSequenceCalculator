using Microsoft.VisualStudio.TestTools.UnitTesting;
using NumericSequenceService;

namespace NumericSequenceCalculator.Tests
{
    [TestClass()]
    public class SequenceServiceTest
    {
        [TestMethod()]
        public void GetAllNumbersTest()
        {
            //Arrange
            var expected = "1,2,3,4,5,6,7,8,9,10";
            var num = 10;

            //Act
            SequenceService _service = new SequenceService();
            var actual = _service.GetAllNumbers(num);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void GetOddNumbersTest()
        {
            //Arrange
            var expected = "1,3,5,7,9,10";
            var num = 10;

            //Act
            SequenceService _service = new SequenceService();
            var actual = _service.GetOddNumbers(num);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void GetEvenNumbersTest()
        {
            //Arrange
            var expected = "2,4,6,8,10";
            var num = 10;

            //Act
            SequenceService _service = new SequenceService();
            var actual = _service.GetEvenNumbers(num);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void GetSpecialCodeTest()
        {
            //Arrange
            var expected = "E";
            var num = 10;

            //Act
            SequenceService _service = new SequenceService();
            var actual = _service.GetSpecialCode(num);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void GetFibonacciSeriesTest()
        {
            //Arrange
            var expected = "0,1,1,2,3,5,8,10";
            var num = 10;

            //Act
            SequenceService _service = new SequenceService();
            var actual = _service.GetFibonacciSeries(num);

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}