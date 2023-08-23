namespace Tests;

public class APITests
{
    HomePage objHomePage = new HomePage();
    API objAPI = new API();

    [SetUp]
    public void Setup()
    {
        objHomePage.Login("solarplustesting@gmail.com", "7eYPSX.tt#/*K2+");

        Assert.IsTrue(objHomePage._driver.FindElement(HomePageVariables.modalNotice).Text.Contains("successfull"));
    }

    [Test]
    public async Task SearchCityAndValidateInfo()
    {
        string apikey = objHomePage.GetApiKey().Remove(HomePageVariables.apiBitIdentifier);

        await objAPI.GetCityData(apikey);

        objHomePage._driver.FindElement(HomePageVariables.logo).Click();

        Thread.Sleep(HomePageVariables.GlobalSleep);

        objHomePage._driver.FindElement(HomePageVariables.textboxSearchCity).SendKeys("Marilao");
        objHomePage._driver.FindElement(HomePageVariables.buttonSearchCity).Click();

        Thread.Sleep(HomePageVariables.GlobalSleep);
        
        objHomePage._driver.FindElement(HomePageVariables.listFirstResult).Click();

        Assert.That(objHomePage._driver.FindElement(HomePageVariables.resultCity).Text,
                    Is.EqualTo(API.wdata.List[0].Name + ", " + API.wdata.List[0].Sys.Country),
                    APIVariables.ERROR);

        Assert.That(objHomePage._driver.FindElement(HomePageVariables.resultTemp).Text,
                    Is.EqualTo(Math.Ceiling(API.wdata.List[0].Main.Temp) + "°C"),
                    APIVariables.ERROR);
    }
}