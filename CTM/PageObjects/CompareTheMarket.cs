using System;
using System.Collections.Generic;
using System.Globalization;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System.Configuration;


namespace CTM.PageObjects
{
    /// <summary>
    /// Summary description for Class1
    /// </summary>
    public class CompareTheMarket
    {
        private readonly IWebDriver driver;

        [FindsBy(How = How.Id, Using = "ctm-logo")]
        private IWebElement logo;

        [FindsBy(How = How.CssSelector, Using = "#header-container li span.text")]
        private IWebElement sections;

        public CompareTheMarket(IWebDriver webDriver)
        {
            driver = webDriver;
            PageFactory.InitElements(webDriver, this);
        }

        public void OpenEnergyComparisonSite()
        {
            this.driver.Navigate().GoToUrl(ConfigurationManager.AppSettings["URL"]);
        }
    }
}