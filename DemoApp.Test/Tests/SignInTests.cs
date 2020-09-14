using DemoApp.Test.Pages;
using Xunit;

namespace DemoApp.Test.Tests
{
    public class SignInTests : TestBase
    {
        private SignInPage page;
        private const string NullUsernameErrorMessage = "Username cannot be empty";
        private const string NullPasswordErrorMessage = "Password cannot be empty";
        private const string BadPasswordErrorMessage = "That password is incorrect";

        public SignInTests()
        {
            page = new SignInPage(driver);
        }

        [Fact]
        public void LabelsVisible()
        {
            page.GoToSignInPage();

            Assert.Equal("Username", page.getUsernameLabel());
            Assert.Equal("Password", page.getPasswordLabel());
        }

        [Theory]
        [InlineData("", "", NullUsernameErrorMessage, NullPasswordErrorMessage)]
        [InlineData("TestUsername", "", "", NullPasswordErrorMessage)]
        [InlineData("", "TestPassword", NullUsernameErrorMessage, "")]
        [InlineData("TestUsername", "badPassword", "", BadPasswordErrorMessage)]
        public void SubmitSignin_Error(
            string username,
            string password, 
            string expectedUsernameError,
            string expectedPasswordError)
        {
            page.GoToSignInPage()
                .EnterUsernamePassword(username, password);

            Assert.Equal(expectedUsernameError, page.getUsernameError());
            Assert.Equal(expectedPasswordError, page.getPasswordError());

        }

        [Fact]
        public void SubmitSignin_Success()
        {
            page.GoToSignInPage()
                .EnterUsernamePassword("TestUsername", "TestPassword");

            Assert.Equal(BaseUrl + TableUrl, page.getCurrentUrl());
        }
    }
}
