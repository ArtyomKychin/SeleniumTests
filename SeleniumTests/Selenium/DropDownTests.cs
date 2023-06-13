using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace SeleniumTests.Selenium
{
    public class DropDownTests : BaseTests
    {
        [Test]
        public void SelectOptions()
        {
            driver.FindElement(By.LinkText("Dropdown")).Click();

            SelectElement select = new(driver.FindElement(By.Id("dropdown")));
            select.SelectByText("Please select an option");
            select.SelectByIndex(1);


        }

    }
}
