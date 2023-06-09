namespace SeleniumTests.Tests
{
    public class SumTests : BaseTest
    {
        
        [Test]
        [Category("Smoke")]
        [Description("Sum")]
        public void Sum()
        {
            var expected = 4;
            var actual = calculator.Add(2, 2);
            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        [Category("Smoke")]
        [Description("SumTestRandom")]
        public void SumTestRandom(

            [Values(1)] double operand1,
            [Random(0, 10, 1)] double operand2)
        {       
            var expected = 4;
            var actual = calculator.Add(operand1, operand2);
            Assert.That(actual, Is.EqualTo(expected));
        }


        [TestCase(4, 2, 2)]//(expexted, operand1, operand2)
        [TestCase(4, 3, 1)]//(expexted, operand1, operand2)
        [TestCase(4, -1, 4)]//(expexted, operand1, operand2)
        public void SummaNegativeNumbersTest(double expected, double operand1, double operand2)
        {
            var actual = calculator.Add(operand1, operand2);
            Assert.That(actual, Is.EqualTo(expected));
            //Assert.That(calculator.Add(operand1, operand2), Is.EqualTo(expected)); - можно записать и так

        }

        [Test]
        public void SummaVsReturn()
        {
            var expected = 4;
            var actual = calculator.Add(2, 2);
            Assert.That(actual, Is.EqualTo(expected));
        }

        [TestCase(2, 2, ExpectedResult = 4)]//(expexted, operand1, operand2)
        public double SummaNegativeNumbersReturnTest(double operand1, double operand2)
        {
            return calculator.Add(operand1, operand2);
        }
    }
}
