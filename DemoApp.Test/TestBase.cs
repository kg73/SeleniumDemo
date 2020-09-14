using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace DemoApp.Test
{
    public class TestBase : IDisposable
    {
        public const string BaseUrl = "https://kgseleniumdemo.azurewebsites.net/";
        public const string TableUrl = "Table";
        protected IWebDriver driver;

        protected TestBase()
        {
            driver = new ChromeDriver(); 
        }

        public void Dispose()
        {
            driver.Quit();
        }
    }
}
