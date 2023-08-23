

namespace Tests
{
    public class API
    {
        HttpRequestMessage ?req;
        HttpClient httpClient = new HttpClient();
        public static WeatherData ?wdata;


        public async Task GetCityData(string key)
        {
            req = new HttpRequestMessage(HttpMethod.Get, APIVariables.BASE_URL + APIVariables.FIND + "?q=Marilao&appid="+ key + "&units=metric");

            HttpResponseMessage resp = await httpClient.SendAsync(req);

            wdata = JsonConvert.DeserializeObject<WeatherData>(resp.Content.ReadAsStringAsync().Result);
        }
    }
}

        //?q=marilao&appid=439d4b804bc8187953eb36d2a8c26a02&units=metric




        // [Test]
        // public void RetrieveApiKey()
        // {
        //     objHomePage.NavigateTo(HomePageVariables.APIKEYS_URL);

        //     string apiKey = objHomePage._driver.FindElement(HomePageVariables.textApiKeys).Text;

        //     Assert.IsNotNull(apiKey);
        //     Assert.IsNotEmpty(apiKey);
        // }