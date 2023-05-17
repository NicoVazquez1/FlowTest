using OpenQA.Selenium;
using SpecFlowProject2.Pages.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowProject2.Pages
{
    class VideoPage : BasePage
    {
        readonly IWebDriver _driver;
        public readonly NavbarPageComponent navbar;
        public string titile = "//*[@id=\"title\"]/h1/yt-formatted-string";
        public VideoPage(IWebDriver driver) : base(driver)
        {
            _driver = driver;
            navbar = new NavbarPageComponent(_driver);
        }
    }
}
