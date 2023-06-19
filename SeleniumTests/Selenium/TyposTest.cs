using OpenQA.Selenium;

namespace SeleniumTests.Selenium
{
    public class TyposTest : BaseTests
    {
        [Test]
        [Retry(5)]
        public void CheckText() 
        {
            driver.FindElement(By.LinkText("Typos")).Click();

            string expectedText = "Sometimes you'll see a typo, other times you won't.";
            var atualText = driver.FindElement(By.CssSelector("p:last-child"));
            //XPath://p[last()] or://*[contains(text(),"Sometimes")]
            Assert.That(atualText.Text, Is.EqualTo(expectedText));
        }
    }
}
