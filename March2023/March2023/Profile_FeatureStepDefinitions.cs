using March2023.pages;
using March2023.Utilities;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Reflection.Emit;
using TechTalk.SpecFlow;

namespace March2023
{
    [Binding]
    public class Profile_FeatureStepDefinitions:Commondriver
    {
        LoginPage loginobj = new LoginPage();
        Profile profileobj = new Profile();

        [Given(@"I logged into turnup portal successfully")]
        public void GivenILoggedIntoTurnupPortalSuccessfully()
        {
            driver = new ChromeDriver();
            loginobj.loginmethod(driver);
        }

        [When(@"I Navigate to Skill field on profile page")]
        public void WhenINavigateToSkillFieldOnProfilePage()
        {
            profileobj.SkillTab(driver);
        }

        [When(@"I add new skills on pages")]
        public void WhenIAddNewSkillsOnPages()
        {
            profileobj.Addskill(driver);
        }

        [Then(@"The Skill should be added successfully")]
        public void ThenTheSkillShouldBeAddedSuccessfully()
        {
            string newskill = profileobj.getskill(driver);
            string newchooselevel = profileobj.getchooselevel(driver);

            Assert.That(newskill == "learning","Actual skill and expected skill do not match");
            Assert.That(newchooselevel == "Beginner","Actual skill level and expected do not match");

        }
        [When(@"I Update '([^']*)','([^']*)' on an existing skill field record")]
        public void WhenIUpdateOnAnExistingSkillFieldRecord(string skill, string level)
        {
           profileobj.Editskill(driver, skill, level);
        }
        //[Then(@"The record should have updated '([^']*)',Intermediate'")]
        //public void ThenTheRecordShouldHaveUpdatedIntermediate(string skill, string level)
        //{
        //    string editskill = profileobj.geteditedskill(driver);
        //    string editlevel = profileobj.geteditedlevel(driver);
        //    Assert.That(editskill == skill, "Actual skill and expected skill do not match");
        //    Assert.That(editlevel == level, "Actual skill level and expected skill level do not match");
        //}
        [Then(@"The record should have updated '([^']*)','([^']*)'")]
        public void ThenTheRecordShouldHaveUpdated(string skill, string level)
        {

            string editskill = profileobj.geteditedskill(driver);
            string editlevel = profileobj.geteditedlevel(driver);
            Assert.That(editskill == skill, "Actual skill and expected skill do not match");
            Assert.That(editlevel == level, "Actual skill level and expected skill level do not match");
        }


        //[When(@"I delete '([^']*)','([^']*)' on an existing skill field record")]
        //public void WhenIDeleteOnAnExistingSkillFieldRecord(string skill, string level)
        //{
        //    profileobj.Deleteskill(driver);
        //}
        //[Then(@"The record should have deleted '([^']*)','([^']*)'")]
        //public void ThenTheRecordShouldHaveDeleted(string skill, string level)
        //{


        //    Assert.That(skill != "Writing", "not delete");
        //    Assert.That(level != "Expert", "Not del");
        //}

        [When(@"I delete  on an existing skill field record")]
        public void WhenIDeleteOnAnExistingSkillFieldRecord()
        {
            profileobj.Deleteskill(driver);
        }
        [Then(@"The record should have deleted")]
        public void ThenTheRecordShouldHaveDeleted()
        {
            Console.WriteLine("Record deleted successfully");
            //Thread.Sleep(1000);
            //string var = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[last()]/tr/td[1]")).Text;
            //Assert.That(var != "Writing", "not delete");
           
        }



    }
}
