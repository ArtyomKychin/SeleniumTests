using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumTests.Selenium
{
    internal class CheckBoxTests :BaseTests
    {
        [Test]
        public void GetCheckBoxes()
        {
            driver.FindElement(By.LinkText("Checkboxes"));

            List<IWebElement> checkBoxes = driver.FindElements(By.TagName("input")).ToList();
            Assert.IsNotEmpty(checkBoxes);

            var checkBox1 = checkBoxes[0];
            var checkBox2 = checkBoxes[1];

            SetCheckBoxState(checkBox1, false);
            SetCheckBoxState(checkBox1, true);
            SetCheckBoxState(checkBox1, true);
            SetCheckBoxState(checkBox1, false);


            checkBox1.Click();
            var selected = checkBox1.Selected;
            var selectedByAttribute = checkBox1.GetAttribute("checked");

            var selected2 = checkBox2.Selected;
            var selectedByAttribute2 = checkBox1.GetAttribute("checked");

        }

        public void SetCheckBoxState(IWebElement element, bool flag)
        {
            var selected = element.Selected;
            //var selectedByAttribute = bool.Parse(element.GetAttribute("checked"));
            bool.TryParse(element.GetAttribute("checked"), out bool selectedByAttribute);

            if ((selected|| selectedByAttribute) != flag) 
            {
                element.Click();
            }
        }
    }
}
