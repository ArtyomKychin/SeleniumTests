using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace SeleniumTests.Selenium
{
    public class DropDownTests : BaseTests
    {
        [Test]
        [Description("AllOptions")]
        public void QuantityAllOptions()
        {
            driver.FindElement(By.LinkText("Dropdown")).Click();
            List<IWebElement> allOptions = driver.FindElements(By.TagName("option")).ToList();

            Assert.That(allOptions.Count, Is.EqualTo(3));

        }

        [Test]
        [Description("First Option Selected")]
        public void SelectOptions1()
        {
            SelectElement select = SelectOptions();
            select.SelectByIndex(1);

            Assert.IsTrue((driver.FindElement(By.CssSelector("option[value='1']")).Selected));
        }

        [Test]
        [Description("Second Option Selected")]
        public void SelectOptions2()
        {
            SelectElement select = SelectOptions();
            select.SelectByIndex(2);

            Assert.IsTrue((driver.FindElement(By.CssSelector("option[value='2']")).Selected));
        }

        private SelectElement SelectOptions()
        {
            driver.FindElement(By.LinkText("Dropdown")).Click();

            SelectElement select = new(driver.FindElement(By.Id("dropdown")));
            return select;
        }

    }
}
