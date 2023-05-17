using OpenQA.Selenium;
using System;
using OpenQA.Selenium.Support.UI;

namespace SpecFlowProject2.Pages
{
    internal abstract class BasePage
    {
        
        protected readonly IWebDriver driver;
        readonly string BaseURL = "https://www.youtube.com/";
        public string Title { get { return driver.Title; } }

        public BasePage(IWebDriver driver) {
           
            this.driver = driver;
        }

        public void GoTo(string url)
        {
            driver.Url = url;
            driver.Navigate().GoToUrl(driver.Url);
        }
        public void GoToHomePage()
        {
            driver.Navigate().GoToUrl(BaseURL);
        }

        public WebDriverWait WaitAndTryInSeconds(double waitForSeconds, double tryEverySeconds)
        {
            WebDriverWait wait = new WebDriverWait(driver, timeout: TimeSpan.FromSeconds(waitForSeconds))
            {
                PollingInterval = TimeSpan.FromSeconds(tryEverySeconds),
            };
            wait.IgnoreExceptionTypes(typeof(NoSuchElementException));

            return wait;
        }
        public void ClickOnLinkText(string locator) {
            driver.FindElement(By.LinkText(locator)).Click();
        }

    }
}
