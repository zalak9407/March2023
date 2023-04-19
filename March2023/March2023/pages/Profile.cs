using March2023.Utilities;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace March2023.pages
{
    public class Profile : Commondriver
    {
        public void SkillTab()
        {
            //click on Skill
            // Thread.Sleep(2500);
            System.Threading.Thread.Sleep(2500);
            driver.FindElement(By.XPath("//*[@class=\"ui form\"]/div/a[2]")).Click();
        }
        public void Addskill()
        {

            Wait.WaitToBeClickable("xPath", 5, "//*[@data-tab=\"second\"]/div/div[2]/div/table/thead/tr/th[3]/div");
            //click on add skill
           
            driver.FindElement(By.XPath("//*[@data-tab=\"second\"]/div/div[2]/div/table/thead/tr/th[3]/div")).Click();
            //seller add skill
            driver.FindElement(By.XPath("//*[@class=\"five wide field\"]/input"))
           .SendKeys("learning");

            //seller click on choose skill level
            
            driver.FindElement(By.XPath("//*[@class=\"five wide field\"]/select"))
            .Click();

            // seller choose skill level
            
            driver.FindElement(By.XPath("//*[@class=\"five wide field\"]/select/option[2]"))
            .Click();

            //seller click on add button
           
            driver.FindElement(By.XPath("//*[@class=\"buttons-wrapper\"]/input"))
              .Click();
            
        }



        public string getskill()
        {
            Thread.Sleep(1000);
            IWebElement actualskill = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[last()]/tr/td"));
            return actualskill.Text;



        }

        public string getchooselevel()
        {
            IWebElement actualchooselevel = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[last()]/tr/td[2]"));
            return actualchooselevel.Text;


        }
        public void Editskill(string skill, string level)
        {
            //click on edit button
            driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[last()]/tr/td[3]/span[1]/i"))
           .Click();
            //edit skill
            driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td/div/div[1]/input"))
           .Clear();
            driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td/div/div[1]/input"))
           .SendKeys(skill);
            Thread.Sleep(1000);

            // Edit level
            driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td/div/div[2]/select"))
           .Click();
            driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td/div/div[2]/select")).SendKeys(level);
            Thread.Sleep(1000);

            //click on update
            driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td/div/span/input[1]"))
            .Click();
            Thread.Sleep(1000);
        }
        public string geteditedskill()
        {
            Thread.Sleep(1000);
            IWebElement createskill = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[last()]/tr/td[1]"));
            return createskill.Text;

        }

        public string geteditedlevel()
        {
            Thread.Sleep(1000);
            IWebElement createlevel = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[last()]/tr/td[2]"));
            return createlevel.Text;

        }


        //delete skill
        public void Deleteskill()
        {
            IWebElement crossbtn = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[last()]/tr/td[3]/span[2]/i"));
            crossbtn.Click();
            Thread.Sleep(1000);

        }

        public string getdelskill()
        {
            Thread.Sleep(1000);
            IWebElement pe = driver.FindElement(By.XPath(" //*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[last()]/tr/td[1] "));
            return pe.Text;

        }
    }
}