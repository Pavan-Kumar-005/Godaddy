using Godaddy1.Drivers;
using Godaddy1.page;
using System;
using TechTalk.SpecFlow;

namespace Godaddy1.StepDefinitions
{
    [Binding]
    public class Godaddy12StepDefinitions : godriver
    {
        [Given(@"Navigate to the Homepage")]
        public void GivenNavigateToTheHomepage()
        {
            //throw new PendingStepException();
            go();
        }

        [When(@"I click on users")]
        public void WhenIClickOnUsers()
        {
            //throw new PendingStepException();
            baseclass sign = new baseclass(driver);
            sign.users.Click();
        }

        [When(@"Click on create an account")]
        public void WhenClickOnCreateAnAccount()
        {
            //throw new PendingStepException();
            baseclass acc = new baseclass(driver);
            acc.create.Click();
        }

        [When(@"Click on continue with email")]
        public void WhenClickOnContinueWithEmail()
        {
            //throw new PendingStepException();
            baseclass email = new baseclass(driver);
            email.clickemail.Click();
        }

        [When(@"Click on continue with username")]
        public void WhenClickOnContinueWithUsername()
        {
            //throw new PendingStepException();
            baseclass email1 = new baseclass(driver);
            email1.username.SendKeys("pavankumar12");
        }

        [When(@"Click on continue with password")]
        public void WhenClickOnContinueWithPassword()
        {
            //throw new PendingStepException();
            baseclass email2 = new baseclass(driver);
            email2.password.SendKeys("pavankumar12");
        }

        [When(@"Click on submit")]
        public void WhenClickOnSubmit()
        {
            //throw new PendingStepException();
            baseclass email3 = new baseclass(driver);
            email3.submit.Click();
        }

        [Then(@"Navigate to the verification page")]
        public void ThenNavigateToTheVerificationPage()
        {
            //throw new PendingStepException();
            //baseclass email4 = new baseclass(driver);
            //email4..Click();
        }
    }
}
