using BoDi;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using TechTalk.SpecFlow;

namespace SpecFlowProjectDemo.Hooks
{
    [Binding]
    public sealed class Hooks
    {
        private readonly IObjectContainer _Container;
        private IWebDriver driver;

        public Hooks(IObjectContainer container)
        {
            _Container = container;
        }
        [BeforeScenario("@tag1")]
        public void BeforeScenarioWithTag()
        {
            // Example of filtering hooks using tags. (in this case, this 'before scenario' hook will execute if the feature/scenario contains the tag '@tag1')
            //TODO: implement logic that has to run before executing each scenario

            Console.WriteLine("BeforeScenarioWithTag Excuted--------------------");
        }
        [BeforeScenario(Order = 1)]
        public void FirstBeforeScenario(ScenarioContext contex)
        {
            //var t= contex.ScenarioContainer.br
            driver = new EdgeDriver();
            //driver.Manage().Window.Maximize();
            //_Container.RegisterInstanceAs(driver);            //var t= contex.ScenarioContainer.br
            //driver = new ChromeDriver();
            //driver.Manage().Window.Maximize();
            _Container.RegisterInstanceAs(driver);

            // Example of ordering the execution of hooks
            //TODO: implement logic that has to run before executing each scenario
            Console.WriteLine("FirstBeforeScenario--------------------");
        }
        [AfterScenario]
        public void AfterScenario()
        {
            var driver = _Container.Resolve<IWebDriver>();
            if (driver != null)
            {
                driver.Quit();
            }
            //TODO: implement logic that has to run after executing each scenario
            Console.WriteLine("AfterScenario----------------------------");
        }
    }
}