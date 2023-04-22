using March2023.pages;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace March2023.Utilities
{
    public class Commondriver
    {
         public static IWebDriver driver;


        [SetUp]
        public void Loginstep()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();

            //turnup portal
            driver.Navigate().GoToUrl("http://localhost:5000/");


        }

        [TearDown]
        public void closeingsteps()
        {
            driver.Quit();
        }
    }
}
