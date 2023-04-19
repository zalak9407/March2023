using BoDi;
using Docker.DotNet.Models;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;

//namespace March2023.hook
//{
//    [Binding]
//    public  class Hooks1
//    {
//       public static  IWebDriver driver = new ChromeDriver();
//       // driver = new ChromeDriver();
//       // public static IWebDriver driver;
//        private readonly IObjectContainer _container;
//        public Hooks1 (IObjectContainer container)
//        {
//            _container = container;
//        }
       
//        [BeforeScenario(Order = 1)]
//        public void FirstBeforeScenario()
//        {
//           // IWebDriver driver = new ChromeDriver();
//            driver.Manage().Window.Maximize();
//            _container.RegisterInstanceAs<IWebDriver>(driver);
//            //turnup portal
//            driver.Navigate().GoToUrl("http://localhost:5000/");


//        }

//        [AfterScenario]
//        public void AfterScenario()
//        {
//            var driver = _container.Resolve<IWebDriver>();
//            if (driver != null)
//            {
//                driver.Quit();
//                //TODO: implement logic that has to run after executing each scenario
//            }
//        }
//    }
//}