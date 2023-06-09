namespace SeleniumTests.Tests
{
    public class MultiplyTests : BaseTest
    {
        [Test]
        [Category("Smoke")]
        [Description("Simple")]
        public void SimpleMultiply()
        {
            var expected = 10;
            var actual = calculator.Multiply(2, 5);
            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        [Category("Smoke")]
        [Description("ByZero")]
        public void MultiplymultiplicationByZero
            (
            [Values(0)] double operand1,
            [Random(1, 10, 1)] double operand2
            )           
        {
            //operand1 = 0;
            var expected = 0;
            var actual = calculator.Multiply(operand1, operand2);
            Assert.That(actual, Is.EqualTo(expected));
        }

        [TestCase(-10, 5, 2)]//(expexted, operand1, operand2)
        [TestCase(-10, -5, 2)]
        [Category("Smoke")]
        [Description("ByANegativeNumber")]
        public void MultiplicationByANegativeNumber(double expected, double operand1, double operand2)
        {
            var actual = calculator.Multiply(operand1, operand2);
            Assert.That(actual, Is.EqualTo(expected)); 
        }
    }
}