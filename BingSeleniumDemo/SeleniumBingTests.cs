using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using System;
using Xunit;

namespace XunitSeleniumDemo
{
	/// <summary>
	/// Summary description for MySeleniumTests
	/// </summary>
	public class SeleniumBingTests : IDisposable
	{
		private readonly IWebDriver driver;
		private readonly string appURL;

		public SeleniumBingTests()
		{
			appURL = "http://www.bing.com/";

			// Set which web driver we will use. Default to Chrome
			string browser = "Chrome";
			switch (browser)
			{
				case "Chrome":
					driver = new ChromeDriver();
					break;
				case "Firefox":
					driver = new FirefoxDriver();
					break;
				case "IE":
					driver = new InternetExplorerDriver();
					break;
				default:
					driver = new ChromeDriver();
					break;
			}
		}

		[Fact]
		public void TheBingSearchTest()
		{
			// Navigate to app URL
			driver.Navigate().GoToUrl(appURL + "/");

			// Find search box
			var queryInput = driver.FindElement(By.Id("sb_form_q"));

			// Type "Azure Pipelines" into search
			queryInput.SendKeys("Azure Pipelines");

			// Submit
			queryInput.Submit();

			// Assert title of browser window containers "Azure Pipelines"
			Assert.True(driver.Title.Contains("Azure Pipelines"), "Verified title of the page");
		}

		public void Dispose()
		{
			driver.Quit();
		}
	}
}