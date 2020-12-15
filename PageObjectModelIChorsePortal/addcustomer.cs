using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace NUnitTestProject1.PageObjectModelIChorsePortal
{
    public class addcustomer
    {
        IWebDriver driver;
        public void Addcustomer()
        {
            IWebElement custname = driver.FindElement(By.XPath("//input[@id='Name']"));
            custname.SendKeys("selina");
            IWebElement editcstmr = driver.FindElement(By.XPath("//button[@id='EditContactButton']"));
            editcstmr.Click();
            driver.SwitchTo().Frame(0);
            IWebElement editcstmrname = driver.FindElement(By.XPath("//input[@id='FirstName']"));
            editcstmrname.SendKeys("selina");
            IWebElement editcstmrlastname = driver.FindElement(By.XPath("//input[@id='LastName']"));
            editcstmrlastname.SendKeys("scout");
            IWebElement editcstmrprefdname = driver.FindElement(By.XPath("//input[@id='PreferedName']"));
            editcstmrprefdname.SendKeys("selina");
            IWebElement editcstmrphnum = driver.FindElement(By.XPath("//input[@id='Phone']"));
            editcstmrphnum.SendKeys("12345");
            IWebElement editcstmrmobile = driver.FindElement(By.XPath("//input[@id='Mobile']"));
            editcstmrmobile.SendKeys("12345");
            IWebElement editcstmrmail = driver.FindElement(By.XPath("//input[@id='email']"));
            editcstmrmail.SendKeys("selina@gmail.com");
            IWebElement editcstmrfax = driver.FindElement(By.XPath("//input[@id='Fax']"));
            editcstmrfax.SendKeys("12345");
            IWebElement editcstmrstrt = driver.FindElement(By.XPath("//input[@id='Street']"));
            editcstmrstrt.SendKeys("123");
            IWebElement editcstmrcity = driver.FindElement(By.XPath("//input[@id='City']"));
            editcstmrcity.SendKeys("Wellington");
            IWebElement editcstmrcode = driver.FindElement(By.XPath("//input[@id='Postcode']"));
            editcstmrcode.SendKeys("6666");
            IWebElement editcstmrcountry = driver.FindElement(By.XPath("//input[@id='Country']"));
            editcstmrcountry.SendKeys("New Zealand");
            IWebElement savecstmredit = driver.FindElement(By.XPath("//input[@id='submitButton' and @value='Save Contact']"));
            savecstmredit.Click();
            driver.SwitchTo().ParentFrame();
            IWebElement sameasabove = driver.FindElement(By.XPath("//input[@id='IsSameContact']"));
            sameasabove.Click();
            IWebElement gst = driver.FindElement(By.XPath("//input[@id='GST']"));
            gst.SendKeys("234");
        }
    }
}
