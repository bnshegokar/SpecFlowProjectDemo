using System;
using TechTalk.SpecFlow;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;

namespace SpecFlowProjectDemo.StepDefinitions
{
    [Binding]
    public class ToolQAFeatureStepDefinitions
    {
        IWebDriver driver;
        [Given(@"Open the Browser")]
        public void GivenOpenTheBrowser()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
        }
        [When(@"Enter URL")]
        public void WhenEnterURL()
        {
            driver.Navigate().GoToUrl("https://www.guru99.com/");
        }               
        [Then(@"Search Specflow BDD")]
        public void ThenSearchSpecflowBDD()
        {
            driver.FindElement(By.Name("search")).SendKeys("Specflow BDD");
            driver.Quit();
        }
    }
}
