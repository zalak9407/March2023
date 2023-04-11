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



//using Mars.Drivers;
//using Mars.Utilities;
//using NUnit.Framework;
//using OpenQA.Selenium;
//using OpenQA.Selenium.Chrome;
//using OpenQA.Selenium.Support.UI;
//using SeleniumExtras.WaitHelpers;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Reflection.Metadata;
//using System.Text;
//using System.Threading.Tasks;

namespace March2023.pages
{
    public class Create_Profile
    {
        public void loadingprofile(IWebDriver driver)
        {
            //click on arrow to add profile name
            //Wait.WaitToBeClickable(driver, "XPath", 5, "//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[2]/div/div/div[1]/i");
            //IWebElement arrowsign = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[2]/div/div/div[1]/i"));
            //arrowsign.Click();
           

            ////Enter first name
            //IWebElement nametxtbox = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[2]/div/div/div[2]/div/div[1]/input[1]"));
            //nametxtbox.Clear();
            //nametxtbox.SendKeys("zeel");

            ////Enter last name
            //IWebElement lasttxtbox = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[2]/div/div/div[2]/div/div[1]/input[2]"));
            //lasttxtbox.Clear();
            //lasttxtbox.SendKeys("pate1");

            ////Click on save
            //IWebElement savebtn = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[2]/div/div/div[2]/div/div[2]/button"));
            //savebtn.Click();

            //Click on [en
            Wait.WaitToBeClickable(driver, "XPath", 2, "//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[2]/div/span/i");
            IWebElement pen1 = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[2]/div/span/i"));
            pen1.Click();

            //select part time or fulltime i am selecting here parttime
            SelectElement availselect = new SelectElement(driver.FindElement(By.CssSelector("div[id='account-profile-section'] div section div div div div div div div div div div div div div span select")));
            availselect.SelectByValue("0");                                                //#account-profile-section > div > section:nth-child(3) > div > div > div > div.four.wide.column > div > div > div > div > div > div.extra.content > div > div:nth-child(2) > div > span > select
                                                                                           
            //click on hours pensil
            Wait.WaitToBeClickable(driver, "XPath", 2, "//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[3]/div/span/i");
            IWebElement hrspen = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[3]/div/span/i"));
            hrspen.Click();
            Thread.Sleep(3000);

            //Select hours dropdown using Name and select value 2
            SelectElement hoursSelect = new SelectElement(driver.FindElement(By.Name("availabiltyHour")));
            hoursSelect.SelectByValue("2");

            //Click on earn pensil
            Wait.WaitToBeClickable(driver, "XPath", 2, "//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[4]/div/span/i");
            IWebElement earnpen = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[4]/div/span/i"));
            earnpen.Click();

            //Selecting earn dropdown by css selector and select the value of dropdown
            SelectElement earnSelect = new SelectElement(driver.FindElement(By.CssSelector("#account-profile-section > div > section:nth-child(3) > div > div > div > div.four.wide.column > div > div > div > div > div > div.extra.content > div > div:nth-child(4) > div > span > select")));
            earnSelect.SelectByValue("1");

            //Select des pen                            ////h3[@class='ui dividing header']//i[@class='outline write icon']
            Wait.WaitToBeClickable(driver, "XPath",2, "(//i[@class='outline write icon'])[1]");
            IWebElement despen = driver.FindElement(By.XPath("(//i[@class='outline write icon'])[1]"));
            despen.Click();

            //select desc textbox using name and again select using xpath and clear it and put a value
            IWebElement DescSelect = driver.FindElement(By.Name("value"));
            IWebElement des = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/div/div/form/div/div/div[2]/div[1]/textarea"));
            des.Clear();
            DescSelect.SendKeys("I am Tester");
            Thread.Sleep(1000);

            //Click on save to save
            IWebElement savebtn2 = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/div/div/form/div/div/div[2]/button"));
            savebtn2.Click();

        }
        public void languagemethod(IWebDriver driver)
        {
            //Thread.Sleep(1000);
            ////Click on lang
            //IWebElement lantab = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[1]/a[1]"));
            //lantab.Click();

            ////click on add
            Wait.WaitToBeClickable(driver, "XPath", 2, "//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/thead/tr/th[3]/div");
            IWebElement addnewbtn = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/thead/tr/th[3]/div"));
            addnewbtn.Click();

            ////add lang in textbox
            Wait.WaitToBeClickable(driver, "XPath", 2, "//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[1]/input");
            IWebElement langtxt = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[1]/input"));
            langtxt.SendKeys("English");

            ////select level
            SelectElement level = new SelectElement(driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[2]/select")));
            level.SelectByValue("Basic");


            ////click on add
            IWebElement add1btn = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[3]/input[1]"));
            add1btn.Click();
            Thread.Sleep(1000);

        }

        public void Educationmethod(IWebDriver driver)
        {

            //click on education
            Wait.WaitToBeClickable(driver, "XPath", 2,"//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[1]/a[3]");
            IWebElement educationtab = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[1]/a[3]"));
            educationtab.Click();

            //click on add to add education
            Wait.WaitToBeClickable(driver, "XPath", 2, "//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/thead/tr/th[6]/div");
            IWebElement add3btn = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/thead/tr/th[6]/div"));
            add3btn.Click();

            //Add uni name
            Wait.WaitToBeClickable(driver, "XPath", 2, "//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[1]/div[1]/input");
            IWebElement countrytxtbox = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[1]/div[1]/input"));
            countrytxtbox.SendKeys("India");

            //Country of university
            Wait.WaitToBeClickable(driver, "XPath", 2, "//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[1]/div[2]/select");
            SelectElement countrySelect = new SelectElement(driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[1]/div[2]/select")));
            countrySelect.SelectByValue("New Zealand");


            //select title 
            Wait.WaitToBeClickable(driver, "XPath", 2, "//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[2]/div[1]/select");
            SelectElement titleSelect = new SelectElement(driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[2]/div[1]/select")));
            titleSelect.SelectByValue("B.Tech");

            //add degree in textbox
            IWebElement degreetxtbox = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[2]/div[2]/input"));
            degreetxtbox.SendKeys("Computer");                     ////*[@id="account-profile-section"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[2]/div[2]/input

            ////select year
            Wait.WaitToBeClickable(driver, "XPath", 2, "//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[2]/div[3]/select");
            SelectElement yearSelect = new SelectElement(driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[2]/div[3]/select")));
            yearSelect.SelectByValue("2017");
           
            //Click on add button to add education
            IWebElement add4edubtn = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[3]/div/input[1]"));
            add4edubtn.Click();
            Thread.Sleep(1000);
        }
        public void cerficationmethod(IWebDriver driver)
        {

            //click on certification
            Thread.Sleep(5000);
            Wait.WaitToBeClickable(driver, "XPath", 10, "//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[1]/a[4]");
            IWebElement certitab = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[1]/a[4]"));
            certitab.Click();

            //click on add new to add cerification
            Wait.WaitToBeClickable(driver, "XPath", 2, "//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/thead/tr/th[4]/div");
            IWebElement addbtn4 = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/thead/tr/th[4]/div"));
            addbtn4.Click();

            //enter award to textbox
            Wait.WaitToBeClickable(driver, "XPath", 2, "//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/div/div[1]/div/input");
            IWebElement awardtextbox = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/div/div[1]/div/input"));
            awardtextbox.SendKeys("java");


            //Enter certification from
            Wait.WaitToBeClickable(driver, "XPath", 2, "//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/div/div[2]/div[1]/input");
            IWebElement certyfromtxt = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/div/div[2]/div[1]/input"));
            certyfromtxt.SendKeys("University");

            //select year
            Wait.WaitToBeClickable(driver, "XPath", 2, "//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/div/div[2]/div[2]/select");
            SelectElement oSelect = new SelectElement(driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/div/div[2]/div[2]/select")));
            oSelect.SelectByValue("2017");

            //Click on add to add certification
            Wait.WaitToBeClickable(driver, "XPath", 2, "//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/div/div[3]/input[1]");
            IWebElement addcerty = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/div/div[3]/input[1]"));
            addcerty.Click();
            Thread.Sleep(1000);

        }


    }
}
