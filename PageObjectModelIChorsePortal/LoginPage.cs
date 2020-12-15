using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace NUnitTestProject1.PageObjectModel
{
    public class LoginPage
    {
        public void Login(IWebDriver driver)
        {
            IWebElement username = driver.FindElement(By.XPath("//input [@id='UserName']"));
            username.SendKeys("hari");
            IWebElement password = driver.FindElement(By.XPath("//input [@id='Password']"));
            password.SendKeys("123123");

            IWebElement Submit = driver.FindElement(By.XPath("//input [@type='submit']"));
            Submit.Click();
        }


       
    }
}
