using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SpecFlowProject2.Pages.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowProject2.Pages
{
    internal class HomePage : BasePage
    {
        readonly IWebDriver _driver;
        public readonly NavbarPageComponent navbar;
        public HomePage(IWebDriver driver) : base(driver) {
            _driver = driver;
            navbar = new NavbarPageComponent(_driver);
        }


    }
}
