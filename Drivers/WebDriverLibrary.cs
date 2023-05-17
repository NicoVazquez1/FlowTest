using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace SpecFlowProject2.Drivers
{
    internal class WebDriverLibrary
    {
        ScenarioContext _scenarioContext;
        WebDriverLibrary(ScenarioContext scenarioContext) => _scenarioContext = scenarioContext;
       
    }
}
