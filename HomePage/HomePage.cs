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
            _driver.FindElement(HomePageVariables.textBoxUsername).SendKeys(username);
            _driver.FindElement(HomePageVariables.textBoxPassword).SendKeys(password);

            _driver.FindElement(HomePageVariables.buttonSubmit).Click();

            Thread.Sleep(5000);
        }
  
        public void Quit() {
            _driver.Close();
            _driver.Quit();
        }
    }
}