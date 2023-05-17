using BoDi;
using OpenQA.Selenium;
using SpecFlowProject2.Pages;
using System;
using TechTalk.SpecFlow;

namespace SpecFlowProject2.StepDefinitions
{
    [Binding]
    public class SearchVideoSteps
    {
        IWebDriver _driver;
        HomePage home;
        public SearchVideoSteps(IObjectContainer container)
        {
            _driver = container.Resolve<IWebDriver>();
            home = new HomePage(_driver);
        }

        [Given(@"user is in the home page")]
        public void GivenUserIsInTheHomePage()
        {
            home.GoToHomePage();
        }
        
        [When(@"user search input the query ""(.*)""")]
        public void WhenUserSearchInputTheQuery(string query)
        {
            home.navbar.Search(query);
        }
        
        [When(@"user clicks on the first video with name ""(.*)""")]
        public void WhenUserClicksOnTheFirstVideoWithName(string p0)
        {

        }
        
        [Then(@"user is able to watch the video")]
        public void ThenUserIsAbleToWatchTheVideo()
        {
          
        }
    }
}
