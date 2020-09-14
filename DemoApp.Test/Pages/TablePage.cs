using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace DemoApp.Test.Pages
{
    public class TablePage
    {
        protected static IWebDriver _driver;

        public By numRecordsDropdown = By.Id("numRecordsDropdown");
        public By classDropdown = By.Id("classDropdown");

        public By idCol = By.Id("idCol");
        public By nameCol = By.Id("nameCol");
        public By ageCol = By.Id("ageCol");
        public By classCol = By.Id("classCol");
        public By gradeCol = By.Id("gradeCol");

        public By tableSubmitButton = By.Id("tableSubmitButton");

        public TablePage(IWebDriver driver)
        {
            _driver = driver;
        }

        public string getIdCol()
        {
            return _driver.FindElement(idCol).Text;
        }

        public string getNameCol()
        {
            return _driver.FindElement(nameCol).Text;
        }

        public string getAgeCol()
        {
            return _driver.FindElement(ageCol).Text;
        }

        public string getClassCol()
        {
            return _driver.FindElement(classCol).Text;
        }

        public string getGradeCol()
        {
            return _driver.FindElement(gradeCol).Text;
        }

        public TablePage GoToTablePage()
        {
            _driver.Navigate().GoToUrl(TestBase.BaseUrl + TestBase.TableUrl);
            return this;
        }

        public TablePage SubmitTablePage(int numRecords)
        {
            var numRecordsIndex = 1;
            switch(numRecords)
            {
                case 10:
                {
                    break;
                }
                case 25:
                {
                    numRecordsIndex = 2;
                    break;
                }
                case 100:
                {
                    numRecordsIndex = 3;
                    break;
                }
            }
            
            new SelectElement(_driver.FindElement(numRecordsDropdown)).SelectByIndex(numRecordsIndex);
            new SelectElement(_driver.FindElement(classDropdown)).SelectByIndex(1);
            _driver.FindElement(tableSubmitButton).Click();

            return this;
        }
    }
}
