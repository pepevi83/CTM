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
        private IWebDriver driver;

        public WebBrowser()
        {
        }

        public IWebDriver Driver
        {
            get
            {
                if (driver == null)
                {
                    this.SetupBrowser(ConfigurationManager.AppSettings["Browser"]);
                }

                return driver;
            }
        }

        public void Teardown()
        {
            this.Driver.Dispose();
        }

        public void SetupBrowser(string browser)
        {
            if (driver == null)
            {
                switch (browser)
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
            }
        }
    }
}
