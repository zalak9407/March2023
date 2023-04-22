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
        LoginPage loginobj;
        Profile profileobj;
        Create_Profile createobj;
        //Profile_FeatureStepDefinitions obj = new Profile_FeatureStepDefinitions();  
        public Profile_FeatureStepDefinitions()
        {
             loginobj = new LoginPage();
             profileobj = new Profile();
             createobj = new Create_Profile();
            //IWebDriver driver = new ChromeDriver();
        }


        [Given(@"I logged into MARS portal successfully")]
        public void GivenILoggedIntoMARSPortalSuccessfully()
        {
           
           
            Loginstep();
            loginobj.loginmethod();
        }


      

        [When(@"I Navigate to Skill field on profile page")]
        public void WhenINavigateToSkillFieldOnProfilePage()
        {
            profileobj.SkillTab();
        }

        [When(@"I add new skills on pages")]
        public void WhenIAddNewSkillsOnPages()
        {
            profileobj.Addskill();
        }

        [Then(@"The Skill should be added successfully")]
        public void ThenTheSkillShouldBeAddedSuccessfully()
        {
            string newskill = profileobj.getskill();
            string newchooselevel = profileobj.getchooselevel();

            Assert.That(newskill == "learning","Actual skill and expected skill do not match");
            Assert.That(newchooselevel == "Beginner","Actual skill level and expected do not match");

        }
        [When(@"I Update '([^']*)','([^']*)' on an existing skill field record")]
        public void WhenIUpdateOnAnExistingSkillFieldRecord(string skill, string level)
        {
           profileobj.Editskill( skill, level);
        }
        
        [Then(@"The record should have updated '([^']*)','([^']*)'")]
        public void ThenTheRecordShouldHaveUpdated(string skill, string level)
        {

            string editskill = profileobj.geteditedskill();
            string editlevel = profileobj.geteditedlevel();
            Assert.That(editskill == skill, "Actual skill and expected skill do not match");
            Assert.That(editlevel == level, "Actual skill level and expected skill level do not match");
        }


 

        [When(@"I delete  on an existing skill field record")]
        public void WhenIDeleteOnAnExistingSkillFieldRecord()
        {
            profileobj.Deleteskill();
        }
        [Then(@"The record should have deleted")]
        public void ThenTheRecordShouldHaveDeleted()
        {
            string deleteskill = profileobj.getdelskill();
            Assert.That(deleteskill != "Writing","Record not deleted ");
        }
        [When(@"Add all details to profile page")]
        public void WhenAddAllDetailsToProfilePage()
        {
            createobj.loadingprofile();
            createobj.languagemethod();
            createobj.Educationmethod();
            createobj.cerficationmethod();
        }

        [Then(@"profile is updated successfully")]
        public void ThenProfileIsUpdatedSuccessfully()
        {
            string newsdes = createobj.getdes();
           string newlang = createobj.getlang();
            string newcountry = createobj.getcountry();
            string newuni = createobj.getuni();
            string newtitle = createobj.gettitle();
            string newdegree = createobj.getdegree();
            string newcerty = createobj.getcerty(); 
            string newfrom = createobj.getfrom();
            string newyear1 = createobj.getyear();

            Assert.That(newsdes == "I am Tester", "Actual des and expected des do not match");
            Assert.That(newlang == "English", "Actual lang and expected do not match");
             Assert.That(newcountry == "New Zealand", "Actual country and expected des do not match");
             Assert.That(newuni == "India", "Actual uni and expected do not match");
             Assert.That(newtitle == "B.Tech","Actual title and expected do not match");
             Assert.That(newdegree == "Computer", "Actual degree and expected do not match");
            Assert.That(newcerty == "java", "Actual certy and expected do not match");
            Assert.That(newfrom == "University", "Actual degree and expected do not match");
            Assert.That(newyear1 == "2017", "Actual year and expected do not match");

        }

        [AfterScenario]
        public void Teardown()
        {
            driver.Quit();
        }




    }
}
