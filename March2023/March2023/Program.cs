//using NUnit.Framework;
//using OpenQA.Selenium;
//using OpenQA.Selenium.DevTools.V110.WebAuthn;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace March2023.pages
//{
//    public class LoginPage
//    {
//        public void loginmethod(IWebDriver driver)
//        {
//            //turnup portal
//            driver.Navigate().GoToUrl("http://localhost:5000/");
//            Thread.Sleep(1000);

//            IWebElement signinbtn = driver.FindElement(By.XPath("//*[@id=\"home\"]/div/div/div[1]/div/a"));
//            signinbtn.Click();

//            try
//            {
//                IWebElement idtextbox = driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[1]/input"));
//                idtextbox.SendKeys("jeelpatel508@gmail.com");
//            }
//            catch (Exception ex)
//            {
//                Assert.Fail("Home Page did not launch", ex.Message);
//            }
//            //Identify Password textbox and enter password
//            IWebElement passtxtbox = driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[2]/input"));
//            passtxtbox.SendKeys("Zalak9407");

//            //Identify Login button and click on login button
//            IWebElement loginbtn = driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[4]/button"));
//            loginbtn.Click();
//            Thread.Sleep(1000);


//        }
//    }
//}
