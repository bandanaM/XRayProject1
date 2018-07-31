using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace XRayProject.StepDefination
{
    [Binding]
    public class InvalidLogin
    {
        private IWebDriver driver;
        public InvalidLogin(IWebDriver _driver)
        {
            driver = _driver;
        }
        [Then(@"verify Login Error Message")]
        public void ThenVerifyLoginErrorMessage()
        {

            var element = driver.FindElement(By.Id("lblMsg"));
            Assert.That(element.Text, Is.Not.Null, "Header Text is not Found");

        }

    }
}
