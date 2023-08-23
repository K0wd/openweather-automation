namespace Tests;

public class APITests
{
    HomePage objHomePage = new HomePage();
    API objAPI = new API();
    string? apikey;

    [OneTimeSetUp]
    public void Setup()
    {
        objHomePage.Login("solarplustesting@gmail.com", "7eYPSX.tt#/*K2+");

        Assert.IsTrue(objHomePage._driver.FindElement(HomePageVariables.modalNotice).Text.Contains("successfull"));
        
        apikey = objHomePage.GetApiKey().Remove(HomePageVariables.apiBitIdentifier);

        objHomePage.Quit();
    }

    [TearDown]
    public void TearDown()
    {
        
    }

    [NonParallelizable]
    [TestCase("New York City", "US", 24)]
    [TestCase("Los Angeles", "US", 22)]
    [TestCase("Chicago", "US", 32)]
    [TestCase("Houston", "US", 33)]
    [TestCase("Phoenix", "US", 33)]
    [TestCase("Philadelphia", "US", 23)]
    [TestCase("yada yada", "US", 23)]
    public async Task TestDifferentCities(string city, string country, int temperature)
    {

        await objAPI.GetCityData(apikey, city);

        Assert.That(API.wdata.List[0].Name + ", " + API.wdata.List[0].Sys.Country,
                    Is.EqualTo(city + ", " + country),
                    APIVariables.ERROR);

        Assert.That(Math.Ceiling(API.wdata.List[0].Main.Temp),
                    Is.EqualTo(temperature),
                    APIVariables.ERROR);
    }
}