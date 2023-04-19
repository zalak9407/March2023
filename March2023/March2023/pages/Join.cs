using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace March2023.pages
{
    internal class Join
    {
        public void signup(IWebDriver driver)
        {
            //click on join to signup
          
            IWebElement joinbutton = driver.FindElement(By.XPath("//*[@id=\"home\"]/div/div/div[1]/div/button"));
            joinbutton.Click();

            //Enter first name
            IWebElement firstnametxtbox = driver.FindElement(By.XPath("/html/body/div[2]/div/div/form/div[1]/input"));
            firstnametxtbox.SendKeys("zalak");

            //Enter last name
            IWebElement lastnametxtbox = driver.FindElement(By.XPath("/html/body/div[2]/div/div/form/div[2]/input"));
            lastnametxtbox.SendKeys("patel");

            //Enter Email address
            IWebElement emailtxtbox = driver.FindElement(By.XPath("/html/body/div[2]/div/div/form/div[3]/input"));
            emailtxtbox.SendKeys("jeelpatel508@gmail.com");

            //Enter password
            IWebElement passtxtbox = driver.FindElement(By.XPath("/html/body/div[2]/div/div/form/div[4]/input"));
            passtxtbox.SendKeys("Zalak9407");

            //Enter password
            IWebElement confrmpasstxtbox = driver.FindElement(By.XPath("/html/body/div[2]/div/div/form/div[5]/input"));
            confrmpasstxtbox.SendKeys("Zalak9407");

            //click on checkbox to accept terms condition
            IWebElement checkbox = driver.FindElement(By.XPath("/html/body/div[2]/div/div/form/div[6]/div/div/input"));
            checkbox.Click();

            //click on join to signup
           
            Thread.Sleep(1000);
            IWebElement joinbtn = driver.FindElement(By.XPath("//*[@id=\"submit-btn\"]"));
            joinbtn.Click();
         }
    }
}