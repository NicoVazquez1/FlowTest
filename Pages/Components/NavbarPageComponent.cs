using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowProject2.Pages.Components
{
    internal class NavbarPageComponent //: basePage ??? deberia heredar?
    {
        IWebDriver _driver;
        IWebElement _searchBox => _driver.FindElement(By.Id("cb1-edit"));
        public NavbarPageComponent(IWebDriver driver)
        {
            _driver = driver;
        }

        public void Search(string query)
        {
            _searchBox.Clear();
            _searchBox.SendKeys(query);
            _searchBox.SendKeys(Keys.Enter);
        }

    }
}
