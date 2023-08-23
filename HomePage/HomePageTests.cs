using NUnit.Framework;

namespace Tests
{
    public class HomePageTests
    {
        HomePage objHomePage = new HomePage();

        [SetUp]
        public void Setup()
        {
        }

        [TearDown]
        public void TearDown()
        {
            objHomePage.Quit();
        }

        [Test]
        public void RetrieveApiKey()
        {
            objHomePage.NavigateTo(HomePageVariables.LOGIN_URL);

            objHomePage.Login("solarplustesting@gmail.com", "7eYPSX.tt#/*K2+");

            Assert.IsTrue(objHomePage._driver.FindElement(HomePageVariables.modalNotice).Text.Contains("successfull"));

            objHomePage.NavigateTo(HomePageVariables.APIKEYS_URL);

            string apiKey = objHomePage._driver.FindElement(HomePageVariables.textApiKeys).Text;

            Assert.IsNotNull(apiKey);
            Assert.IsNotEmpty(apiKey);
        }
    }
}