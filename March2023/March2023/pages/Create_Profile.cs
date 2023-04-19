using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using March2023.Utilities;
using Microsoft.VisualStudio.TestPlatform.ObjectModel;
using SeleniumExtras.WaitHelpers;
using System.Reflection.Metadata;
using NUnit.Framework;


namespace March2023.pages
{
    public class Create_Profile:Commondriver
    {
        
        public void loadingprofile()
        {
            
            //Click on pen
             Wait.WaitToBeClickable("XPath", 2, "//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[2]/div/span/i");
            driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[2]/div/span/i"))
           .Click();

            //select part time or fulltime i am selecting here parttime
            SelectElement availselect = new SelectElement(driver.FindElement(By.CssSelector("div[id='account-profile-section'] div section div div div div div div div div div div div div div span select")));
            availselect.SelectByValue("0");                                               
                                                                                           
            //click on hours pensil
            Wait.WaitToBeClickable("XPath", 2, "//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[3]/div/span/i");
            driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[3]/div/span/i"))
            .Click();
            Thread.Sleep(3000);

            //Select hours dropdown using Name and select value 2
            SelectElement hoursSelect = new SelectElement(driver.FindElement(By.Name("availabiltyHour")));
            hoursSelect.SelectByValue("2");

            //Click on earn pensil
            Wait.WaitToBeClickable("XPath", 2, "//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[4]/div/span/i");
            driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[4]/div/span/i"))
            .Click();

            //Selecting earn dropdown by css selector and select the value of dropdown
            SelectElement earnSelect = new SelectElement(driver.FindElement(By.CssSelector("#account-profile-section > div > section:nth-child(3) > div > div > div > div.four.wide.column > div > div > div > div > div > div.extra.content > div > div:nth-child(4) > div > span > select")));
            earnSelect.SelectByValue("1");

            //Select des pen                          
            Wait.WaitToBeClickable("XPath",2, "(//i[@class='outline write icon'])[1]");
            driver.FindElement(By.XPath("(//i[@class='outline write icon'])[1]"))
            .Click();

            //select desc textbox using name and again select using xpath and clear it and put a value
          //  driver.FindElement(By.Name("value")).SendKeys("I am Tester"); 
            driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/div/div/form/div/div/div[2]/div[1]/textarea"))
            .Click();
            driver.FindElement(By.Name("value")).Clear();
            driver.FindElement(By.Name("value")).SendKeys("I am Tester");

            Thread.Sleep(1000);

            //Click on save to save

            driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/div/div/form/div/div/div[2]/button"))
           .Click();

        }

        public string getdes()
        {

            Thread.Sleep(1000);
            //driver.FindElement(By.XPath("//*[@class=\"button\"]/i");
            IWebElement actualdesc = driver.FindElement(By.XPath("//*[@class=\"content\"]/div/span"));
            return actualdesc.Text;

        }
        public void languagemethod()
        {
          

            ////click on add
            Wait.WaitToBeClickable("XPath", 2, "//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/thead/tr/th[3]/div");
            driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/thead/tr/th[3]/div"))
          .Click();

            ////add lang in textbox
            Wait.WaitToBeClickable("XPath", 2, "//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[1]/input");
           driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[1]/input"))
            .SendKeys("English");

            ////select level
            SelectElement level = new SelectElement(driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[2]/select")));
            level.SelectByValue("Basic");


            ////click on add
            driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[3]/input[1]"))
           .Click();
            Thread.Sleep(1000);

        }
        public string getlang()
        {
            Thread.Sleep(1000);
            
           IWebElement langx = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[1]/a[1]"));
            langx.Click();
            IWebElement actuallang = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td[1]"));
            return actuallang.Text;                               ////*[@id="account-profile-section"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td[1]
        }

        //*[@id="account-profile-section"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td[2]


        public void Educationmethod()
        {

           //click on education
           Wait.WaitToBeClickable("XPath", 2,"//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[1]/a[3]");
           driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[1]/a[3]"))
          .Click();

            //click on add to add education
            Wait.WaitToBeClickable("XPath", 2, "//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/thead/tr/th[6]/div");
            driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/thead/tr/th[6]/div"))
           .Click();

            //Add uni name
            Wait.WaitToBeClickable("XPath", 2, "//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[1]/div[1]/input");
            driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[1]/div[1]/input"))
           .SendKeys("India");

            //Country of university
            Wait.WaitToBeClickable("XPath", 2, "//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[1]/div[2]/select");
            SelectElement countrySelect = new SelectElement(driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[1]/div[2]/select")));
            countrySelect.SelectByValue("New Zealand");


            //select title 
            Wait.WaitToBeClickable("XPath", 2, "//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[2]/div[1]/select");
            SelectElement titleSelect = new SelectElement(driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[2]/div[1]/select")));
            titleSelect.SelectByValue("B.Tech");

            //add degree in textbox
            driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[2]/div[2]/input"))
            .SendKeys("Computer");                   

            ////select year
            Wait.WaitToBeClickable("XPath", 2, "//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[2]/div[3]/select");
            SelectElement yearSelect = new SelectElement(driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[2]/div[3]/select")));
            yearSelect.SelectByValue("2017");
           
            //Click on add button to add education
            driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[3]/div/input[1]"))
            .Click();
            Thread.Sleep(1000);
        }
        public string getcountry()
        {
            Thread.Sleep(1000);
            driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[1]/a[3]")).Click();
            IWebElement actualcountry = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table[last()]/tbody/tr/td[1]"));
            return actualcountry.Text;                             
        }
        public string getuni()
        {
            Thread.Sleep(1000);
            driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[1]/a[3]")).Click();
            IWebElement actualuni = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody[last()]/tr/td[2]"));
            return actualuni.Text;
        }
        public string gettitle()
        {
            Thread.Sleep(1000);
            driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[1]/a[3]")).Click();
            IWebElement actualtitle = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody[last()]/tr/td[3]"));
            return actualtitle.Text;

        }
        public string getdegree()
        {
            Thread.Sleep(1000);
            driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[1]/a[3]")).Click();
            IWebElement actualdegree = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody[last()]/tr/td[4]"));
            return actualdegree.Text;
        }


        public void cerficationmethod()
        {

            //click on certification
            Thread.Sleep(5000);
            Wait.WaitToBeClickable("XPath", 10, "//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[1]/a[4]");
           driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[1]/a[4]"))
           .Click();

            //click on add new to add cerification
            Wait.WaitToBeClickable("XPath", 2, "//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/thead/tr/th[4]/div");
            driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/thead/tr/th[4]/div"))
            .Click();

            //enter award to textbox
            Wait.WaitToBeClickable("XPath", 2, "//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/div/div[1]/div/input");
             driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/div/div[1]/div/input"))
            .SendKeys("java");


            //Enter certification from
            Wait.WaitToBeClickable("XPath", 2, "//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/div/div[2]/div[1]/input");
            IWebElement certyfromtxt = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/div/div[2]/div[1]/input"));
            certyfromtxt.SendKeys("University");

            //select year
            Wait.WaitToBeClickable("XPath", 2, "//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/div/div[2]/div[2]/select");
            SelectElement oSelect = new SelectElement(driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/div/div[2]/div[2]/select")));
            oSelect.SelectByValue("2017");

            //Click on add to add certification
            Wait.WaitToBeClickable("XPath", 2, "//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/div/div[3]/input[1]");
          driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/div/div[3]/input[1]"))
           .Click();
            Thread.Sleep(1000);

        }
        public string getcerty()
        {
            Thread.Sleep(1000);
            driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[1]/a[4]")).Click();
               
            IWebElement actualcerty = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody[last()]/tr/td[1]"));
            return actualcerty.Text;
        }
        public string getfrom()
        {
            Thread.Sleep(1000);
            driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[1]/a[4]")).Click();
            IWebElement actualfrom = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody[last()]/tr/td[2]"));
            return actualfrom.Text;
        }
        public string getyear()
        {
            Thread.Sleep(1000);
            driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[1]/a[4]")).Click();
            IWebElement actualyear = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody[last()]/tr/td[3]"));
            return actualyear.Text;
        }


    }
}
