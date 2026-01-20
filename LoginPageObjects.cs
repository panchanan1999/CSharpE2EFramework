using CSharpAutomationFramework.Utilities;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpAutomationFramework.PageObjects
{
    public class LoginPageObjects :Base
    {
        public IWebElement UsernameField => driver.FindElement(By.Id("username"));
        public IWebElement PasswordField => driver.FindElement(By.Id("password"));
        public IWebElement LoginButton => driver.FindElement(By.Id("login"));

        public void EnterUsername(string username)
        {
            UsernameField.SendKeys(username);
        }

        public void EnterPassword(string password)
        {
            PasswordField.SendKeys(password);
        }

        public void ClickLogin()
        {
            LoginButton.Click();
        }
    }
}
