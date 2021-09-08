using Commons.Model;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;
using WebAutomationBillingform.Framework;
using WebAutomationBillingform.Pages;

namespace WebAutomationBillingform.Test
{   // inheriting BaseTest class from framework to BillingOrderTest 
    class BillingOrderTest
    { 
        private IWebDriver driver;
    
    [SetUp]
    public void SetUp()
    {
            driver = new ChromeDriver();
            driver.Url = "http://qaauto.co.nz/billing-order-form/";

        }
    [TearDown]
    protected void TearDown()
    {
        driver.Quit();
    }

        [Test]
        public void CreateBillingOrderTest()     //creating  webBillingOrderPage
        {
            
            BillingOrderPage orderPage = new BillingOrderPage(driver);
            orderPage.Login();
            orderPage.FirstName("Arihan");
            orderPage.LastName("Pinni");
           /* orderPage.Email("abc@12.com");
            orderPage.PhoneNumber("0123456789");
            orderPage.AddressLine1("test");
            orderPage.AddressLine2("tesst1");
            orderPage.City("Auck");
            orderPage.State("New York");
            orderPage.Zipcode("1024");
*/
        }
        BillingOrder orderObject = new BillingOrder
        {
            AddressLine1 = "test",
            AddressLine2 = "test",
            City = "testing",
            Comment = "comment",
            Email = "a@test.com",
            FirstName = "amit",
            ItemNumber = 1,
            LastName = "test",
            Phone = "0222222222",
            State = "AL",
            ZipCode = "1234"
        };

        [Test]
        public void CreateBillingOrderTestModel()     //creating  webBillingOrderPage
        {

            BillingOrderPage orderPage = new BillingOrderPage(driver);
            orderPage.Login();
            orderPage.BillingOrderFillupform(orderObject);
 
        }



















    }
}
