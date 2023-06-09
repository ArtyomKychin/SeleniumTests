namespace SeleniumTests.Tests
{
    public class DevideTests : BaseTest
    {
        [Test]
        [Category("Smoke")]
        [Description("SimpleDevide")]

        public void SimpleDevide()
        {
            var expected = 2;
            var actual = calculator.Devide(10, 5);
            //Assert.AreEqual(expected, actual);
            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        [Category("Smoke")]
        [Description("DevideByZero")]

        public void DevideByZero
            (
            [Random(1, 10, 1)] double operand1,
            [Random(-5, 5, 10)] double operand2
            )
        {
            //Random random = new ();
            //operand1 = random.Next(1, 100);
            //operand2 = random.Next(0, 1);
            var expected = 1;
            var actual = calculator.Devide(operand1, operand2);
            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        [Category("Smoke")]
        [Description("DevideByZeroAndRange")]

        public void DevideByZeroAndRange
            (
            [Values(2, 4, 10)] double operand1,
            [Range(-5, 5, 1)] double operand2
            )
        {
            var expected = 0;
            var actual = calculator.Devide(operand1, operand2);
            Assert.AreNotEqual(actual, expected);
        }
    }
}
