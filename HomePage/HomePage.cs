using NUnit.Framework;
using OpenQA.Selenium.Chrome;

namespace Tests
{
    public class HomePage
    {
        public WebDriver _driver = new ChromeDriver();

        public void NavigateTo(string url) {
            _driver.Navigate().GoToUrl(url);
        }

        public void Login(string username, string password) {
            NavigateTo(HomePageVariables.LOGIN_URL);

            _driver.FindElement(HomePageVariables.textBoxUsername).SendKeys(username);
            _driver.FindElement(HomePageVariables.textBoxPassword).SendKeys(password);

            _driver.FindElement(HomePageVariables.buttonSubmit).Click();

            Thread.Sleep(HomePageVariables.GlobalSleep);
        }
        public string GetApiKey()
        {
            _driver.FindElement(HomePageVariables.dropdownUserMenu).Click();
            _driver.FindElement(HomePageVariables.submenuMyApikeys).Click();
            
            Thread.Sleep(HomePageVariables.GlobalSleep);

            return _driver.FindElement(HomePageVariables.textApiKeys).Text;
        }
  
        public void Quit() {
            _driver.Close();
            _driver.Quit();
        }
    }
}