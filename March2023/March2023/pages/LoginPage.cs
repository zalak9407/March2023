
using March2023.Utilities;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.DevTools.V110.WebAuthn;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace March2023.pages
{
    public class LoginPage:Commondriver
    {
       
        public void loginmethod()
        {
            
            Thread.Sleep(1000);

           driver.FindElement(By.XPath("//*[@id=\"home\"]/div/div/div[1]/div/a")).Click(); ;
            

            try
            {
                driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[1]/input"))
                .SendKeys("jeelpatel508@gmail.com");
            }
            catch (Exception ex)
            {
                Assert.Fail("Home Page did not launch", ex.Message);
            }
            //Identify Password textbox and enter password
             driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[2]/input"))
            .SendKeys("Zalak9407");

            //Identify Login button and click on login button
            driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[4]/button"))
            .Click();
            Thread.Sleep(1000);


        }
    }
}

