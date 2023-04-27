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

     private  IWebElement pen1 => driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[2]/div/span/i"));
     private   SelectElement availselect => new SelectElement(driver.FindElement(By.CssSelector("div[id='account-profile-section'] div section div div div div div div div div div div div div div span select")));
     private IWebElement hrspen => driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[3]/div/span/i"));
     private SelectElement hoursSelect => new SelectElement(driver.FindElement(By.Name("availabiltyHour")));
     private   IWebElement earnpen => driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[4]/div/span/i"));
     private SelectElement earnSelect => new SelectElement(driver.FindElement(By.CssSelector("#account-profile-section > div > section:nth-child(3) > div > div > div > div.four.wide.column > div > div > div > div > div > div.extra.content > div > div:nth-child(4) > div > span > select")));
     private IWebElement despen => driver.FindElement(By.XPath("(//i[@class='outline write icon'])[1]"));
     private IWebElement DescSelect => driver.FindElement(By.Name("value"));
     private IWebElement des => driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/div/div/form/div/div/div[2]/div[1]/textarea"));
     private  IWebElement savebtn2 => driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/div/div/form/div/div/div[2]/button"));
     private IWebElement actualdesc => driver.FindElement(By.XPath("//*[@class=\"content\"]/div/span"));
     private   IWebElement addnewbtn => driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/thead/tr/th[3]/div"));
     private  IWebElement langtxt => driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[1]/input"));
     private  SelectElement level => new SelectElement(driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[2]/select")));
     private   IWebElement add1btn => driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[3]/input[1]"));
     private IWebElement langx => driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[1]/a[1]"));
     private IWebElement actuallang => driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td[1]"));
     private IWebElement educationtab => driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[1]/a[3]"));
     private IWebElement add3btn => driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/thead/tr/th[6]/div"));
     private IWebElement countrytxtbox => driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[1]/div[1]/input"));
     private SelectElement countrySelect => new SelectElement(driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[1]/div[2]/select")));
     private SelectElement titleSelect => new SelectElement(driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[2]/div[1]/select")));
     private IWebElement degreetxtbox => driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[2]/div[2]/input"));
     private SelectElement yearSelect => new SelectElement(driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[2]/div[3]/select")));
     private IWebElement add4edubtn => driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[3]/div/input[1]"));
     private IWebElement con => driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[1]/a[3]"));

     private IWebElement actualcountry => driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table[last()]/tbody/tr/td[1]"));
     private IWebElement uni => driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[1]/a[3]"));
     private  IWebElement actualuni => driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody[last()]/tr/td[2]"));
     private IWebElement tit => driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[1]/a[3]"));
     private IWebElement actualtitle => driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody[last()]/tr/td[3]"));
     private IWebElement deg => driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[1]/a[3]"));
     private IWebElement actualdegree => driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody[last()]/tr/td[4]"));
     private IWebElement certitab => driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[1]/a[4]"));
     private IWebElement addbtn4 => driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/thead/tr/th[4]/div"));
     private IWebElement awardtextbox => driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/div/div[1]/div/input"));
     private IWebElement certyfromtxt => driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/div/div[2]/div[1]/input"));
     private SelectElement oSelect => new SelectElement(driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/div/div[2]/div[2]/select")));
     private IWebElement certy => driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[1]/a[4]"));
     private IWebElement actualcerty => driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody[last()]/tr/td[1]"));
     private IWebElement form => driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[1]/a[4]"));
     private IWebElement actualfrom => driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody[last()]/tr/td[2]"));
     private IWebElement year => driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[1]/a[4]"));
     private IWebElement actualyear => driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody[last()]/tr/td[3]"));
     private IWebElement addcerty => driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/div/div[3]/input[1]"));
        

        public void loadingprofile()
        {
            

            //Click on pen
             Wait.WaitToBeClickable("XPath", 2, "//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[2]/div/span/i");
           
             pen1.Click();

            //select part time or fulltime i am selecting here parttime
           
            availselect.SelectByValue("0");                                               
                                                                                           
            //click on hours pensil
            Wait.WaitToBeClickable("XPath", 2, "//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[3]/div/span/i");
            
          hrspen.Click();
            Thread.Sleep(3000);

          
            hoursSelect.SelectByValue("2");

            //Click on earn pensil
            Wait.WaitToBeClickable("XPath", 2, "//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[4]/div/span/i");
           
            earnpen.Click();

            //Selecting earn dropdown by css selector and select the value of dropdown
           
            earnSelect.SelectByValue("1");

            //Select des pen                          
            Wait.WaitToBeClickable("XPath",2, "(//i[@class='outline write icon'])[1]");

            despen.Click();

            //select desc textbox using name and again select using xpath and clear it and put a value
           
            des.Click();
            des.Clear();
            DescSelect.SendKeys("I am Tester");
            Thread.Sleep(1000);

            //Click on save to save


            savebtn2.Click();

        }

        public string getdes()
        {

            Thread.Sleep(1000);
           
          
            return actualdesc.Text;

        }
        public void languagemethod()
        {
          

            ////click on add
            Wait.WaitToBeClickable("XPath", 2, "//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/thead/tr/th[3]/div");
           
          addnewbtn.Click();

            ////add lang in textbox
            Wait.WaitToBeClickable("XPath", 2, "//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[1]/input");
            langtxt.SendKeys("English");
            ////select level
          
            level.SelectByValue("Basic");


            ////click on add

            add1btn.Click();
            Thread.Sleep(1000);

        }
        public string getlang()
        {
            Thread.Sleep(1000);
          
            langx.Click();
           
            return actuallang.Text;                             
        }


        public void Educationmethod()
        {

           //click on education
           Wait.WaitToBeClickable("XPath", 2,"//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[1]/a[3]");
            educationtab.Click();

            //click on add to add education
            Wait.WaitToBeClickable("XPath", 2, "//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/thead/tr/th[6]/div");
            add3btn.Click();
            //Add uni name
            Wait.WaitToBeClickable("XPath", 2, "//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[1]/div[1]/input");
            countrytxtbox.SendKeys("India");


            //Country of university
            Wait.WaitToBeClickable("XPath", 2, "//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[1]/div[2]/select");
           
            countrySelect.SelectByValue("New Zealand");


            //select title 
            Wait.WaitToBeClickable("XPath", 2, "//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[2]/div[1]/select");
           
            titleSelect.SelectByValue("B.Tech");

            //add degree in textbox

            degreetxtbox.SendKeys("Computer");

            ////select year
            Wait.WaitToBeClickable("XPath", 2, "//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[2]/div[3]/select");
           
            yearSelect.SelectByValue("2017");

            //Click on add button to add education
            add4edubtn.Click();
            Thread.Sleep(1000);

           
        }
        public string getcountry()
        {
            Thread.Sleep(1000);
           con.Click();
           
            return actualcountry.Text;                             
        }
        public string getuni()
        {
            Thread.Sleep(1000);
           uni.Click();
            
            return actualuni.Text;
        }
        public string gettitle()
        {
            Thread.Sleep(1000);
           tit.Click();
           
            return actualtitle.Text;

        }
        public string getdegree()
        {
            Thread.Sleep(1000);
            deg.Click();
           
            return actualdegree.Text;
        }


        public void cerficationmethod()
        {

            //click on certification
            Thread.Sleep(5000);
            Wait.WaitToBeClickable("XPath", 10, "//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[1]/a[4]");
            certitab.Click();
            //click on add new to add cerification
            Wait.WaitToBeClickable("XPath", 2, "//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/thead/tr/th[4]/div");
            addbtn4.Click();

            //enter award to textbox
            Wait.WaitToBeClickable("XPath", 2, "//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/div/div[1]/div/input");
            awardtextbox.SendKeys("java");


            //Enter certification from
            Wait.WaitToBeClickable("XPath", 2, "//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/div/div[2]/div[1]/input");
           
            certyfromtxt.SendKeys("University");

            //select year
            Wait.WaitToBeClickable("XPath", 2, "//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/div/div[2]/div[2]/select");
            oSelect.SelectByValue("2017");
            //Click on add to add certification
            Wait.WaitToBeClickable("XPath", 2, "//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/div/div[3]/input[1]");
            addcerty.Click();
            Thread.Sleep(1000);
        }
        public string getcerty()
        {
            Thread.Sleep(1000);
          
            certy.Click();
           
            return actualcerty.Text;
        }
        public string getfrom()
        {
            Thread.Sleep(1000);
         
                form.Click();
            
            return actualfrom.Text;
        }
        public string getyear()
        {
            Thread.Sleep(1000);
           
            year.Click();
            
            return actualyear.Text;
        }


    }
}
