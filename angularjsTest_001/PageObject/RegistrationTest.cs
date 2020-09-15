using angularjsTest_001.Utilities;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace angularjsTest_001.PageObject
{
    class RegistrationTest
    {
        public RegistrationTest()
        {
            driver = Hooks1.driver;
        }

        IWebDriver driver;

        IWebElement Registerbutton => driver.FindElement(By.XPath("//a[contains(text(),'Sign up')]"));
        IWebElement username => driver.FindElement(By.XPath("//input[@placeholder='Username']"));
        IWebElement email => driver.FindElement(By.XPath("//input[@placeholder='Email']"));
        IWebElement passw => driver.FindElement(By.XPath("//input[@placeholder='Password']"));

        IWebElement SignUp => driver.FindElement(By.XPath("//button[@class='btn btn-lg btn-primary pull-xs-right ng-binding']"));
        IWebElement yourFeed => driver.FindElement(By.XPath("//ul[2]//li[2]//a[1]"));

   

        public void NavigateUrl()
        {
            driver.Navigate().GoToUrl("https://angularjs.realworld.io/");
        }
        public void ClickRegister()
        {
            Registerbutton.Click();

        }
        public void EnterName()
        {
            username.SendKeys("Valex5453537");
        }

        public void EnterEmail()
        {
            email.SendKeys("owoeye3452507@gmail.com");

        }

        public void EnterPassword()
        {
            passw.SendKeys("hardwork50554955654");

        }

        public void ClickSignUp()
        {

            SignUp.Click();
        }


        public bool ArticleCheck()
        {
           return yourFeed.Displayed;
        }
//User enter password less than 6 character
        public void EnterInvalidPassword()
        {
            passw.SendKeys("hardwo");

        }

        //User enter invalid email address

        public void EnterInvalidEmail()
        {
            email.SendKeys("owoeye3452507@");

        }
    }
}
