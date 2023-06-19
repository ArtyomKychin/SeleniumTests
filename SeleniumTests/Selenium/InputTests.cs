using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;

namespace SeleniumTests.Selenium
{
    public class InputTests : BaseTests
    {
        [Test]
        public void InputNumbers()
        {
            IWebElement input = FindInput();

            var inputNumbers = "42";
            input.SendKeys(inputNumbers);
            
            Assert.That(input.GetAttribute("value"), Is.EqualTo(inputNumbers));
        }


        [Test]
        public void InputNumbersVsArrowKeys()
        {
            IWebElement input = FindInput();

            var inputNumbers = "42";
            input.SendKeys(inputNumbers);
            var text = input.GetAttribute("value");

            input.SendKeys(Keys.ArrowUp + Keys.ArrowDown);

            Assert.That(text, Is.EqualTo(inputNumbers));
        }

        [Test]
        public void InputNumbersVsText()
        {
            IWebElement input = FindInput();

            var expectedNumbers = "42";
            input.SendKeys("A42D");

            var text = input.GetAttribute("value");

            Assert.That(text, Is.EqualTo(expectedNumbers));
        }
        public IWebElement FindInput()
        {
            driver.FindElement(By.LinkText("Inputs")).Click();
            var input = driver.FindElement(By.TagName("input"));
            return input;
        }
    }
}
