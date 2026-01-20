using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Configuration;
using System.Text;
using WebDriverManager.DriverConfigs.Impl;

namespace CSharpAutomationFramework.Utilities
{
    public class Base
    {
#pragma warning disable NUnit1032
        public IWebDriver driver;
#pragma warning restore NUnit1032
        public WebDriverWait wait;

        [SetUp]
        public void Setup()
        {
            string url = ConfigurationManager.AppSettings["url"];
            string browser = ConfigurationManager.AppSettings["browser"];
            initbrowser(browser);

            // Add implicit wait so driver waits for elements
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            // Create explicit wait for more control
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));

            //string actualurl = "https://rahulshettyacademy.com/loginpagePractise/";
            driver.Navigate().GoToUrl(url);
            driver.Manage().Window.Maximize();
        }
        public void initbrowser(string browser)
        {
            switch (browser)
            {
                case "chrome":
                    new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());
                    driver = new ChromeDriver();
                    break;
                // Add other browsers here as needed
                default:
                    throw new ArgumentException($"Browser '{browser}' is not supported.");
            }

            [TearDown]
            void TearDown()
            {
                if (driver != null)
                {
                    driver.Quit();
                    driver.Dispose();
                    driver = null;
                }
            }
        }
    }
}

