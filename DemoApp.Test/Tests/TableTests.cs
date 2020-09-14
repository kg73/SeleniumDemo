using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using DemoApp.Test.Pages;
using System;
using Xunit;

namespace DemoApp.Test.Tests
{
    public class TableTests : TestBase
    {
        private TablePage page;

        public TableTests()
        {
            page = new TablePage(driver);
        }

        [Fact]
        public void ColumnHeaders()
        {
            page.GoToTablePage();

            Assert.Equal("Id", page.getIdCol());
            Assert.Equal("Name", page.getNameCol());
            Assert.Equal("Age", page.getAgeCol());
            Assert.Equal("Class", page.getClassCol());
            Assert.Equal("Grade", page.getGradeCol());
        }

        [Fact]
        public void SuccessfulQuery_RowCount()
        {
            var rowCount = 10;
            page.GoToTablePage()
                .SubmitTablePage(rowCount);

            // Wait a total of 10 seconds for the first row to be present.
            // We don't need this row for the test, we just want to wait for it to load.
            var firstResult = new WebDriverWait(driver, timeout: TimeSpan.FromSeconds(10))
                .Until(ExpectedConditions.ElementExists(By.XPath("//table[@class='table']/tbody/tr")));

            var rows = driver.FindElements(By.XPath("//table[@class='table']/tbody/tr"));

            Assert.Equal(rowCount, rows.Count);
        }
    }
}
