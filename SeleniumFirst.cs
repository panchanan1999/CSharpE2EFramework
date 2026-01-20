using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using WebDriverManager.DriverConfigs.Impl;
namespace MyCSharpAutomationProject
{
    public class Tests
    {
        private IWebDriver driver;
        [SetUp]
        public void Setup()
        {
            new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());
            driver = new ChromeDriver();
        }

        [Test]
        public void NavigateToHomePage()
        {

            string actualurl = "https://rahulshettyacademy.com/loginpagePractise/";
            driver.Navigate().GoToUrl(actualurl);
            driver.Manage().Window.Maximize();
            string url=driver.Url;
            TestContext.Progress.WriteLine("Current URL: " + url);
            Assert.That(url, Is.EqualTo(actualurl), "The Actual and expected url matched");
        }
        [Test]
        public void NavigateToBackPage()
        {
        
            string actualurl = "https://rahulshettyacademy.com/loginpagePractise/";
            driver.Navigate().GoToUrl(actualurl);
            string title = driver.Title;
            TestContext.Progress.WriteLine("Page Title: " + title);
            string url = driver.Url;
            TestContext.Progress.WriteLine("Current URL before navigating back: " + url);
            string pagesource=driver.PageSource;
            TestContext.Progress.WriteLine("Page Source length: " + pagesource);
      
        }
        [TearDown]
        public void TearDown()
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