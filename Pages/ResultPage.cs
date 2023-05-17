using OpenQA.Selenium;
using SpecFlowProject2.Pages.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowProject2.Pages
{
    class ResultPage : BasePage
    {
        readonly IWebDriver _driver;
        NavbarPageComponent navbar;
        public ResultPage(IWebDriver driver) : base(driver)
        {
            _driver = driver;
            navbar = new NavbarPageComponent(_driver);
        }

        public void clickOnFirstVideoByNameReference(string nameReference)
        {
            base.WaitAndTryInSeconds(3, 2);
             _driver.FindElement(By.LinkText(nameReference)).Click();
        }

    }
}
