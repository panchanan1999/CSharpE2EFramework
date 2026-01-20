using CSharpAutomationFramework.PageObjects;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace CSharpAutomationFramework.Tests
{
    public class LoginPage : LoginPageObjects
    {
        [Test]
        public void LoginPageTest()
        {
            TestContext.Progress.WriteLine("LoginPage test executed.");
            
            // Use inherited methods from LoginPageObjects
            EnterUsername("rahulshettyacademy");
            EnterPassword("Learning@830$3mK2");
            ClickLogin();
            
            // Wait to see the result after login
            Thread.Sleep(3000); // 3 seconds to observe the result
            
            // Add login page specific assertions here
            TestContext.Progress.WriteLine("Login attempted successfully.");
        }
    }
}
