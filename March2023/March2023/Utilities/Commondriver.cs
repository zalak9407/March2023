using March2023.pages;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace March2023.Utilities
{
    public class Commondriver
    {
        public IWebDriver driver;
        [SetUp]
        public void Loginstep()
        {
            driver = new ChromeDriver();
            LoginPage loginobj = new LoginPage();
            loginobj.loginmethod(driver);

        }
        [TearDown]
        public void closeingsteps()
        {
            driver.Quit();
        }
    }
}
