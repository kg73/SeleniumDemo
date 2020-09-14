using OpenQA.Selenium;

namespace DemoApp.Test.Pages
{
    public class SignInPage
    {
        protected static IWebDriver _driver;

        public By usernameLabel = By.Id("usernameLabel");
        public By usernameField = By.Id("usernameField");
        public By usernameErrorMessage = By.Id("usernameError");

        public By passwordLabel = By.Id("passwordLabel");
        public By passwordField = By.Id("passwordField");
        public By passwordErrorMessage = By.Id("passwordError");

        public By signinSubmitButton = By.Id("signinSubmit");

        public SignInPage(IWebDriver driver)
        {
            _driver = driver; 
        }

        public string getUsernameLabel()
        {
            return _driver.FindElement(usernameLabel).Text;
        }

        public string getPasswordLabel()
        {
            return _driver.FindElement(passwordLabel).Text;
        }

        public string getUsernameError()
        {
            return _driver.FindElement(usernameErrorMessage).Text;
        }

        public string getPasswordError()
        {
            return _driver.FindElement(passwordErrorMessage).Text;
        }

        public string getCurrentUrl()
        {
            return _driver.Url;
        }
        
        public SignInPage GoToSignInPage()
        {
            _driver.Navigate().GoToUrl(TestBase.BaseUrl);
            return this;
        }

        public SignInPage EnterUsernamePassword(string username, string password)
        {
            _driver.FindElement(usernameField).SendKeys(username);
            _driver.FindElement(passwordField).SendKeys(password);
            _driver.FindElement(signinSubmitButton).Click();
            return this;
        }
    }
}
