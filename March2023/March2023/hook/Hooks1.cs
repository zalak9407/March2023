using BoDi;
using Docker.DotNet.Models;
using March2023.Utilities;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;

namespace March2023.hook
{
    [Binding]
    public class Hooks1 : Commondriver
    {



        [BeforeScenario(Order = 1)]
        public void FirstBeforeScenario()
        {
            Loginstep();
           

        }

        [AfterScenario]
        public void AfterScenario()
        {
            closeingsteps();
        }
    }
}

