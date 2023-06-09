using SeleniumTests.Calc;

namespace SeleniumTests.Tests
{
    public class BaseTest
    {
        protected Calculator calculator;

        [OneTimeSetUp]
        public void OneTimeSetUp()
        {
            calculator = new Calculator();       
        }

        [SetUp]
        public void Setup()
        {
            
        }

        [TearDown]
        public void TearDown()
        {
            
        }
        [OneTimeTearDown]
        public void OneTimeTearDown()
        {

        }
    }
}
