using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace March2023.pages
{
    public class Profile
    {
            public void SkillTab(IWebDriver driver)
            {
            //click on Skill
            Thread.Sleep(2500);
            IWebElement skillbtn = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[1]/a[2]"));
            skillbtn.Click();
            }
            public void Addskill(IWebDriver driver) 
            {
            //click on add skill
            IWebElement addskillbtn = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/thead/tr/th[3]/div"));
            addskillbtn.Click();

            //seller add skill
            IWebElement addskilltxtbox = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/div[1]/input"));
            addskilltxtbox.SendKeys("learning");                      ////*[@id="account-profile-section"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/div[1]/input

            //seller click on choose skill level
            IWebElement chooseskilldropdown = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/div[2]/select"));
            chooseskilldropdown.Click();                                   ////*[@id="account-profile-section"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/div[2]/select

            // seller choose skill level
            IWebElement beginneroption = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/div[2]/select/option[2]"));
            beginneroption.Click();                                  ////*[@id="account-profile-section"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/div[2]/select/option[2]

            //seller click on add button
            IWebElement addbtn = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/span/input[1]"));
            addbtn.Click();
            }

        public string getskill(IWebDriver driver)
        {
            Thread.Sleep(1000);
            IWebElement actualskill = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[last()]/tr/td"));
            return actualskill.Text;                               ////*[@id="account-profile-section"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td[1]

            //IWebElement getchooselevel = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td[2]"));
            //return getchooselevel.Text;

        }

        public string getchooselevel(IWebDriver driver)
        {
            IWebElement actualchooselevel = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[last()]/tr/td[2]"));
            return actualchooselevel.Text;                               ////*[@id="account-profile-section"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td[2]
            Thread.Sleep(1000);

        }
        public void Editskill(IWebDriver driver, string skill,string level)
        {
            //click on edit button
            IWebElement pensilbtn = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[last()]/tr/td[3]/span[1]/i"));
            pensilbtn.Click();
            //edit skill
            IWebElement editskilltxt = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[last()]/tr/td/div/div[1]/input"));
            editskilltxt.Clear();                                   ////*[@id="account-profile-section"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td/div/div[1]/input
            editskilltxt.SendKeys(skill);
            Thread.Sleep(1000);

           // Edit level
            IWebElement editlevel = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[last()]/tr/td/div/div[2]/select"));
            editlevel.Click();                                   ////*[@id="account-profile-section"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td/div/div[2]/select
            editlevel.SendKeys(level);
            Thread.Sleep(1000);

            //click on update
            IWebElement updateclick = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[last()]/tr/td/div/span/input[1]"));
            updateclick.Click();
        }
        public string geteditedskill(IWebDriver driver)
        {
            Thread.Sleep(1000);
            IWebElement createskill = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[last()]/tr/td[1]"));
            return createskill.Text;                               ////*[@id="account-profile-section"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td[1]
           
        }

        public string geteditedlevel(IWebDriver driver)
        {
            Thread.Sleep(1000);
            IWebElement createlevel = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[last()]/tr/td[2]"));
            return createlevel.Text;
            ////*[@id="account-profile-section"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td[2]      }
        }


        //delete skill
        public void Deleteskill(IWebDriver driver)
        {
            IWebElement crossbtn = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[last()]/tr/td[3]/span[2]/i"));
            crossbtn.Click();
            Thread.Sleep(1000);
            ////seller go to cross button for delete record
            //IWebElement crossbtn = driver.FindElement(By.XPath(""));
            //crossbtn.Click();

            //IWebElement recordtobedel = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[last()]/tr/td[1]"));
            //if (recordtobedel.Text== "Writing")
            //{
            //    IWebElement crossbtn = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[last()]/tr/td[3]/span[2]/i"));
            //    crossbtn.Click();
            //    Thread.Sleep(1000);
            //}
            //else
            //{
            //    Assert.Fail("Record to be delete not found");
            //}
            ////IWebElement Accept = driver.FindElement(By.XPath("/html/body/div[1]"));
            ////driver.SwitchTo().Alert().Accept();
            ////driver.Navigate().Refresh();
            //Thread.Sleep(1000);

            //IWebElement delre = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[last()]/tr/td[1]"));
            //Assert.That(delre.Text != "Writing", "Record hasn't been deleted");
            //driver.Quit();

        }

    }
}