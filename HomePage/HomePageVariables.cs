using NUnit.Framework;

namespace Tests
{
    public class HomePageVariables
    {
        public static int GlobalSleep = 5000;
        //HomePage
        public static string BASE_URL = "https://home.openweathermap.org";
        public static By buttonSignIn = By.XPath("/html/body/nav/ul[1]/div/ul/li[11]");
        public static By logo = By.XPath("/html/body/nav/ul[1]/li[1]/a/img");

        //LoginPage
        public static string LOGIN_URL = BASE_URL + "/users/sign_in";
        public static By textBoxUsername = By.XPath("/html/body/div[2]/div[3]/div[2]/div/div/form/div[1]/input");
        public static By textBoxPassword = By.XPath("/html/body/div[2]/div[3]/div[2]/div/div/form/div[2]/input");

        public static By buttonSubmit = By.XPath("/html/body/div[2]/div[3]/div[2]/div/div/form/input[3]");

        //MemberPage
        public static By modalNotice = By.XPath("/html/body/div[2]/div[3]/div/div/div");

        //ApiKeys
        public static string APIKEYS_URL = BASE_URL + "/api_keys";
        public static By textApiKeys = By.XPath("/html/body/div[2]/div[3]/div[3]/div[1]/table/tbody");
        public static int apiBitIdentifier = 32;

        //Dashboard 
        public static By textboxSearchCity = By.XPath("/html/body/main/div[2]/div[1]/div/div/div[2]/div[1]/div/input");
        public static By buttonSearchCity = By.XPath("/html/body/main/div[2]/div[1]/div/div/div[2]/div[1]/button");
        public static By listFirstResult = By.XPath("/html/body/main/div[2]/div[1]/div/div/div[2]/div[1]/div/ul/li[1]");
        public static string listSearchResult = "/html/body/main/div[2]/div[2]";

        public static By resultCity = By.XPath(listSearchResult + "/div[1]/div[1]/div[1]/h2");
        public static By resultTemp = By.XPath(listSearchResult + "/div[1]/div[1]/div[2]/div[1]/span");
        public static By dropdownUserMenu = By.XPath("/html/body/nav/ul[1]/div/ul/li[11]");
        public static By submenuMyApikeys = By.XPath("/html/body/nav/ul[1]/div/ul/li[11]/ul/li[2]");
    }
}