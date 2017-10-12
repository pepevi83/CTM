using System;
using System.Configuration;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using TechTalk.SpecFlow;

namespace CTM.Browser
{
    [Binding]
    public class WebBrowser
    {
        private readonly IWebDriver driver;

        public WebBrowser()
        {
            driver = this.SetupBrowser(ConfigurationManager.AppSettings["Browser"]);
        }

        public IWebDriver Driver => this.driver;

        public void Teardown()
        {
            this.Driver.Quit();
        }

        private IWebDriver SetupBrowser(string browser)
        {
            IWebDriver driver;

            switch (browser.ToUpper())
            {
                case "CHROME":
                    driver = new ChromeDriver();
                    break;

                case "IE":
                    driver = new InternetExplorerDriver();
                    break;

                case "FIREFOX":
                default:
                    driver = new FirefoxDriver();
                    break;
            }

            driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(60);
            driver.Manage().Window.Maximize();

            return driver;
        }
    }
}
