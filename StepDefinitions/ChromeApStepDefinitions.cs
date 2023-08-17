using Dynamitey;
using Microsoft.VisualBasic;
using System;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace SpecFlowProjectDemo.StepDefinitions
{
    [Binding]
    public class ChromeApStepDefinitions
    {
        [Given(@"I login app in below url <browser>")]
        public void GivenILoginAppInBelowUrlBrowser(Table table)
        {
            var data = table.CreateDynamicInstance();
            // throw new PendingStepExce
            // ption();

           // Console.WriteLine(((string)data.browser));
           
        }


    }
}
