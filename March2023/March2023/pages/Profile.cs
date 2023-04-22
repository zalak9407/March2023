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
     
     private IWebElement actualskill => driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[last()]/tr/td"));
     private   IWebElement actualchooselevel => driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[last()]/tr/td[2]"));

      private   IWebElement crossbtn => driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[last()]/tr/td[3]/span[2]/i"));

      private   IWebElement pe => driver.FindElement(By.XPath(" //*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[last()]/tr/td[1] "));

      private  IWebElement createskill => driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[last()]/tr/td[1]"));

     private   IWebElement createlevel => driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[last()]/tr/td[2]"));

        private IWebElement skillbtn => driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[1]/a[2]"));

        private IWebElement addskillbtn => driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/thead/tr/th[3]/div"));

        private IWebElement addskilltxtbox => driver.FindElement(By.XPath("//*[@class=\"five wide field\"]/input"));

        private IWebElement chooseskilldropdown => driver.FindElement(By.XPath("//*[@class=\"five wide field\"]/select"));

       private IWebElement beginneroption =>driver.FindElement(By.XPath("//*[@class=\"five wide field\"]/select/option[2]"));

        private IWebElement addbtn => driver.FindElement(By.XPath("//*[@class=\"buttons-wrapper\"]/input"));
      private   IWebElement pensilbtn => driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[last()]/tr/td[3]/span[1]/i"));
       private IWebElement editskilltxt => driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td/div/div[1]/input"));

      private  IWebElement editlevel => driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td/div/div[2]/select"));

      private  IWebElement updateclick => driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td/div/span/input[1]"));
        public void SkillTab()
        {
            //click on Skill
            // Thread.Sleep(2500);
            System.Threading.Thread.Sleep(2500);
            skillbtn.Click();
        }
        public void Addskill()
        {

            Wait.WaitToBeClickable("xPath", 5, "//*[@data-tab=\"second\"]/div/div[2]/div/table/thead/tr/th[3]/div");
            //click on add skill

            addskillbtn.Click();
            //seller add skill
            addskilltxtbox .SendKeys("learning");

            //seller click on choose skill level
            
           
           chooseskilldropdown .Click();

            // seller choose skill level
            
          
            beginneroption.Click();

            //seller click on add button
           
           
             addbtn .Click();
            
        }



        public string getskill()
        {
            Thread.Sleep(1000);
          
            return actualskill.Text;



        }

        public string getchooselevel()
        {
          
            return actualchooselevel.Text;


        }
        public void Editskill(string skill, string level)
        {
            //click on edit button
           
             pensilbtn.Click();
            //edit skill
            
           editskilltxt.Clear();
          
           editskilltxt.SendKeys(skill);
            Thread.Sleep(1000);

            // Edit level

            editlevel.Click();
           editlevel.SendKeys(level);
            Thread.Sleep(1000);

            //click on update

            updateclick.Click();
            Thread.Sleep(1000);
        }
        public string geteditedskill()
        {
            Thread.Sleep(1000);
           
            return createskill.Text;

        }

        public string geteditedlevel()
        {
            Thread.Sleep(1000);
          
            return createlevel.Text;

        }


        //delete skill
        public void Deleteskill()
        {
            crossbtn.Click();
            Thread.Sleep(1000);

        }

        public string getdelskill()
        {
            Thread.Sleep(1000);
         
            return pe.Text;

        }
    }
}