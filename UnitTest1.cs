using NUnit.Framework;
using NUnitTestProject1.PageObjectModel;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace NUnitTestProject1
{
 
    public class Tests
    {
        IWebDriver driver;
        LoginPage login = new LoginPage();


        //addcustomer createcustomer = new addcustomer();

        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("http://horse.industryconnect.io/");
            driver.Manage().Window.Maximize();
        }


        [Test]
        public void Test1()
        {
            login.Login(driver);
            //createcustomer.Addcustomer();


                       // var uservalidate = driver.FindElement(By.XPath("//body/div[3]/div[1]/div[1]/form[1]/ul[1]/li[1]/a[1]"));
            //  System.Console.Write(uservalidate);
            //Assert.AreEqual(uservalidate, "Hello hari!");
            IWebElement admin = driver.FindElement(By.XPath("//a[@class='dropdown-toggle' and text()='Administration ']"));
            admin.Click();
            IWebElement customer = driver.FindElement(By.XPath("//a[contains(text(),'Customers')]"));

            customer.Click();
            
            IWebElement createnewcustomer = driver.FindElement(By.XPath("//a[contains(text(),'Create New')]"));
            createnewcustomer.Click();
            
            IWebElement savecustmr = driver.FindElement(By.XPath("//input[@id='submitButton' and @value='Save']"));
            savecustmr.Click();


        }
    }
}