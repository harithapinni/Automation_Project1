using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;

namespace WebAutomationBillingform.Framework
{
    public class BaseTest
    {
        public IWebDriver driver;
        
        [SetUp]
        public void SetUp()
        {
            driver = new ChromeDriver();
          
        }
        [TearDown]
        protected void TearDown()
        {
            driver.Quit();
        }


        [Test]
        public void webautomation()
        {
            //driver.Navigate().GoToUrl("http://qaauto.co.nz/billing-order-form/");
           
           /* driver.FindElement(By.Id("wpforms-locked-24-field_form_locker_password")).Click();
            driver.FindElement(By.Id("wpforms-locked-24-field_form_locker_password")).SendKeys("Testing");
            driver.FindElement(By.Id("wpforms-submit-locked-24")).Click();
            driver.FindElement(By.Id("wpforms-24-field_0")).Click();
            driver.FindElement(By.Id("wpforms-24-field_0")).SendKeys("Haritha");
            driver.FindElement(By.Id("wpforms-24-field_0-last")).Click();
            driver.FindElement(By.Id("wpforms-24-field_0-last")).SendKeys("Pinni");
            driver.FindElement(By.Id("wpforms-24-field_1")).SendKeys("haritha.123@gmail.com");
            driver.FindElement(By.Id("wpforms-24-field_3")).Click();
            driver.FindElement(By.Id("wpforms-24-field_3")).SendKeys("Auckland");
            driver.FindElement(By.Id("wpforms-24-field_3-address2")).Click();
            driver.FindElement(By.Id("wpforms-24-field_3-address2")).SendKeys("Hillsborough");
            driver.FindElement(By.Id("wpforms-24-field_3-city")).SendKeys("Hillsborough");
            driver.FindElement(By.Id("wpforms-24-field_3-postal")).Click();
            driver.FindElement(By.Id("wpforms-24-field_3-state")).Click();
            {
                var dropdown = driver.FindElement(By.Id("wpforms-24-field_3-state"));
                dropdown.FindElement(By.XPath("//option[. = 'Colorado']")).Click();
            }
            driver.FindElement(By.Id("wpforms-24-field_4_1")).Click();
            driver.FindElement(By.Id("wpforms-24-field_6")).Click();
            driver.FindElement(By.Id("wpforms-24-field_6")).SendKeys("Test WebAutomation ");
            driver.FindElement(By.Id("wpforms-submit-24")).Click();*/
        }
    }
}
