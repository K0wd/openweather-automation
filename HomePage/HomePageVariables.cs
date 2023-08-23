using NUnit.Framework;

namespace Tests
{
    public class HomePageVariables
    {
        //HomePage
        public static string BASE_URL = "https://home.openweathermap.org";
        public static By buttonSignIn = By.XPath("/html/body/nav/ul[1]/div/ul/li[11]");

        //LoginPage
        public static string LOGIN_URL = BASE_URL + "/users/sign_in";
        public static By textBoxUsername = By.XPath("/html/body/div[2]/div[3]/div[2]/div/div/form/div[1]/input");
        public static By textBoxPassword = By.XPath("/html/body/div[2]/div[3]/div[2]/div/div/form/div[2]/input");

        public static By buttonSubmit = By.XPath("/html/body/div[2]/div[3]/div[2]/div/div/form/input[3]");

        //MemberPage
        public static By modalNotice = By.XPath("/html/body/div[2]/div[3]/div/div/div");

        //ApiKeys
        public static string APIKEYS_URL = BASE_URL + "h/api_keys";
        public static By textApiKeys = By.XPath("/html/body/div[2]/div[4]/div[3]/div[1]/table/tbody/tr/td[1]/pre");
    }
}