using OpenQA.Selenium;

namespace SeleniumTests.Selenium
{
    internal class CheckBoxTests : BaseTests
    {
        [Test]
        public void GetCheckBoxes()
        {
            driver.FindElement(By.LinkText("Checkboxes")).Click();
            List<IWebElement> checkBoxes = driver.FindElements(By.TagName("input")).ToList();

            var checkBoxFirst = checkBoxes[0];
            var checkBoxSecond = checkBoxes[1];

            Assert.IsFalse(GetCheckBoxState(checkBoxFirst));

            checkBoxFirst.Click();
            Assert.IsTrue(GetCheckBoxState(checkBoxFirst));

            Assert.IsTrue(GetCheckBoxState(checkBoxSecond));

            checkBoxSecond.Click();
            Assert.IsFalse(GetCheckBoxState(checkBoxSecond));
        }

        public bool GetCheckBoxState(IWebElement element)
        {
            var selected = element.Selected;
            bool.TryParse(element.GetAttribute("checked"), out bool selectedByAttribute);

            return ((selected || selectedByAttribute) != false);
        }
    }
}
