using Commons.Model;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace WebAutomationBillingform.Pages
{
    public class BillingOrderPage
    {
        IWebDriver browser;

        public BillingOrderPage(IWebDriver driver)
        {
            browser = driver;
        }
        public void FirstName(string value)
        {
            browser.FindElement(By.Id("wpforms-24-field_0")).SendKeys(value);
        }
        public void LastName(string value)
        {
            browser.FindElement(By.Id("wpforms-24-field_0-last")).SendKeys(value);
        }
        public void Email(string value)
        {
            browser.FindElement(By.Id("wpforms-24-field_1")).SendKeys(value);
        }
        public void PhoneNumber(string value)
        {
            browser.FindElement(By.Id("wpforms-24-field_1")).SendKeys(value);
        }


        public void Address(string value)
        {
            browser.FindElement(By.Id("wpforms-24-field_3")).SendKeys(value);
        }
        public void AddressLine1(string value)
        {
            browser.FindElement(By.Id("wpforms-24-field_3")).SendKeys(value);
        }

        public void AddressLine2(string value)
        {
            browser.FindElement(By.Id("wpforms-24-field_3-address2")).SendKeys(value);
        }

        public void City(string value)
        {
            browser.FindElement(By.Id("wpforms-24-field_3-city")).SendKeys(value);
        }
        public void State(string value)
        {
            browser.FindElement(By.Id("wpforms-24-field_3-state")).SendKeys(value);
        }

        public void Zipcode(string value)
        {
            browser.FindElement(By.Id("wpforms-24-field_3-postal")).SendKeys(value);
            
        }

        public void Submit(string value)
        {
            browser.FindElement(By.Id("wpforms-submit-24")).SendKeys(value);
        }
        public void BillingOrderFillupform(BillingOrder order) // from Commons ->model->Billingorder
        {
            FirstName(order.FirstName);
            LastName(order.LastName);
            PhoneNumber(order.Phone);
            Email(order.Email);
            City(order.City);
            Zipcode(order.ZipCode);
            AddressLine1(order.AddressLine1);
        }
        public void Login()
        {
            //browser.FindElement(By.Id("wpforms-locked-24-field_form_locker_password")).Click();
            browser.FindElement(By.Id("wpforms-locked-24-field_form_locker_password")).SendKeys("Testing");
            browser.FindElement(By.Id("wpforms-submit-locked-24")).Click();
        }
    }
}
