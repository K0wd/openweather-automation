namespace openweather_automation;

public class Tests
{
    HttpClient client = new HttpClient();
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public async Task Test1()
    {
        HttpResponseMessage result = await client.GetAsync("http://google.com");

        Assert.AreEqual(result.StatusCode, HttpStatusCode.OK);
    }
}