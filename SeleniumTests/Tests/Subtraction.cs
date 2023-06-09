namespace SeleniumTests.Tests
{
    public class Subtraction : BaseTest
    {
        [Test]
        [Category("Smoke")]
        [Description("DifferenceLessThanZero")]

        public void DifferenceLessThanZero
            (
            [Values(2, 4, 10)] double operand1,
            [Range(-5, 5, 1)] double operand2
            )
        {
            //Random rand = new Random();
            //var expected =rand.Next(-1,-10);
            //var expected = 0;
            var actual = calculator.Sub(operand1, operand2);
            Assert.Negative(actual);
        }

        [Test]
        [Retry(10)]
        [Category("Smoke")]
        [Description("SimpleDifferenceAllGreaterThanZero")]

        public void SiimpleDifference()
        {

            Random rnd = new();
            var actual = calculator.Sub(rnd.Next(2, 10), 1);
            Assert.Positive(actual);

        }

        [Test]
        [Retry(10)]
        [Category("Smoke")]
        [Description("SimpleDifferenceSoftAccert")]
        public void SimpleDifferenceSoftAccert
            (
            [Values(1)] double operand1,
            [Range(-5, 5, 1)] double operand2
            )
        {

            Random rnd = new();
            var actual = calculator.Sub(operand1, operand2);
            Assert.Multiple(() =>
            {
                Assert.Negative(actual);
                //Assert.Positive(actual);
            });
        }
    }
}
