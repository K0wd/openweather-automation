using NUnit.Framework;

namespace Tests
{
    public class HomePageTests
    {
        HomePage objHomePage = new HomePage();
        API objAPI = new API();

        [SetUp]
        public void Setup()
        {
            objHomePage.Login("solarplustesting@gmail.com", "7eYPSX.tt#/*K2+");

            Assert.IsTrue(objHomePage._driver.FindElement(HomePageVariables.modalNotice).Text.Contains("successfull"));
        }

        [TearDown]
        public void TearDown()
        {
            objHomePage.Quit();
        }

        [Test]
        public async Task SearchCity()
        {
            string apikey = objHomePage.GetApiKey();

            await objAPI.GetCityData(apikey);

            objHomePage._driver.FindElement(HomePageVariables.textboxSearchCity).SendKeys("Marilao");
            objHomePage._driver.FindElement(HomePageVariables.buttonSearchCity).Click();
            objHomePage._driver.FindElement(HomePageVariables.listFirstResult).Click();

            Assert.That(objHomePage._driver.FindElement(HomePageVariables.resultCity).Text, Is.EqualTo("Marilao, PH"));
            Assert.IsTrue(objHomePage._driver.FindElement(HomePageVariables.resultTemp).Text.Contains("°C"));
        }
    }
}