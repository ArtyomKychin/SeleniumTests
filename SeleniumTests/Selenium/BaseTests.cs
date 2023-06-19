using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumTests.Selenium
{
    public class BaseTests
    {
        protected WebDriver driver;

        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            driver.Navigate().GoToUrl("https://the-internet.herokuapp.com/");
            driver.Manage().Window.Maximize();
        }

        [TearDown]
        public void TearDown()
        {
            driver.Quit();
        }
    }
}