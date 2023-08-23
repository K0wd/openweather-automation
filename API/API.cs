

namespace Tests
{
    public class API
    {
        HttpRequestMessage ?req;
        HttpClient httpClient = new HttpClient();
        public static WeatherData? wdata;


        public async Task GetCityData(string key, string city)
        {
            req = new HttpRequestMessage(HttpMethod.Get, APIVariables.BASE_URL + APIVariables.FIND + "?q="+ city +"&appid="+ key + "&units=metric&dt=1643803200");

            HttpResponseMessage resp = await httpClient.SendAsync(req);

            wdata = JsonConvert.DeserializeObject<WeatherData>(resp.Content.ReadAsStringAsync().Result);
        }
    }
}