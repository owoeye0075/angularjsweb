using angularjsTest_001.PageObject;
using NUnit.Framework;
using System;
using System.Threading;
using TechTalk.SpecFlow;

namespace angularjsTest_001.Stepdefinitions
{
    [Binding]
    public class RegistrationSteps
    {
        RegistrationTest registrationTest;
        public RegistrationSteps()
        {
            registrationTest = new RegistrationTest();

        }

        [Given(@"I navigate to https://angularjs\.realworld\.io/")]
        public void GivenINavigateToHttpsAngularjs_Realworld_Io()
        {
            registrationTest.NavigateUrl();

        }
        
        [Given(@"I clicked on Sign up")]
        public void GivenIClickedOnSignUp()
        {
            registrationTest.ClickRegister();
        }
        
        [Given(@"I enter username")]
        public void GivenIEnterUsername()
        {
            registrationTest.EnterName();
        }
        
        [Given(@"I enter valid email address")]
        public void GivenIEnterValidEmailAddress()
        {
            registrationTest.EnterEmail();
        }
        
        [Given(@"I enter password")]
        public void GivenIEnterPassword()
        {
            registrationTest.EnterPassword();
            Thread.Sleep(3000);
        }
        
        [When(@"I click Sign up button")]
        public void WhenIClickSignUpButton()
        {
            registrationTest.ClickSignUp();
            registrationTest.ClickSignUp();
            registrationTest.ClickSignUp();
            registrationTest.ClickSignUp();
        }
        
        [Then(@"I should successfully register")]
        public void ThenIShouldSuccessfullyRegister()
        {
            Assert.That(registrationTest.ArticleCheck);
        }

        [Given(@"I enter invalid email address")]
        public void GivenIEnterInvalidEmailAddress()
        {
            registrationTest.EnterInvalidEmail();
        }

        [Given(@"I enter invalid password address")]
        public void GivenIEnterInvalidPasswordAddress()
        {
            registrationTest.EnterInvalidPassword();
        }





        // {
        //  Assert.That(registrationTest.FeedsDisplay);
        //}
    }
}
