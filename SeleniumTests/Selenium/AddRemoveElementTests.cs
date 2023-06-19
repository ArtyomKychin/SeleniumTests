using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;

namespace SeleniumTests.Selenium
{
    public class AddRemoveElementTests : BaseTests
    {

        [Test]
        public void AddRemoveButton()
        {
            driver.FindElement(By.LinkText("Add/Remove Elements")).Click();

            IWebElement addButton = driver.FindElement(By.TagName("button"));
            new Actions(driver).DoubleClick(addButton).Perform();
            List<IWebElement> buttonDelete = driver.FindElements(By.ClassName("added-manually")).ToList();
            
            var actual = buttonDelete.Count;
            var expected = 2;

            Assert.That(actual, Is.EqualTo(expected));

            var addedButtonDelete = driver.FindElement(By.ClassName("added-manually"));        
            addedButtonDelete.Click();

            Assert.IsNotEmpty(driver.FindElements(By.ClassName("added-manually")));
        }
    }
}
