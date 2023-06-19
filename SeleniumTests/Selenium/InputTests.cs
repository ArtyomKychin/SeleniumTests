using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;

namespace SeleniumTests.Selenium
{
    public class InputTests : BaseTests
    {
    [Test]
    public void InputNumbers()
        {
            driver.FindElement(By.LinkText("Inputs")).Click();
            var input = driver.FindElement(By.TagName("input"));

            input.SendKeys("100");
            input.Clear();

            input.SendKeys("42");
            input.SendKeys(Keys.ArrowUp);
            input.SendKeys(Keys.ArrowUp);

            var text = input.GetAttribute("Value");

        }

    }
}
