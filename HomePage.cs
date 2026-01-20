using CSharpAutomationFramework.Utilities;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpAutomationFramework.Tests
{
    public class HomePage : Base
    {
        [Test]
        public void HomepageTest()
        {
           string title = driver.Title;
           TestContext.Progress.WriteLine("Page Title: " + title);
           Assert.That(title, Is.EqualTo("LoginPage Practise | Rahul Shetty Academy"), "The Actual and expected title matched");
        }

        [Test]
        public void UrlTest()
        {
            string actualurl = "https://rahulshettyacademy.com/loginpagePractise/";
            string url = driver.Url;
            TestContext.Progress.WriteLine("Current URL: " + url);
            Assert.That(url, Is.EqualTo(actualurl), "The Actual and expected url matched");
        }
    }
}
