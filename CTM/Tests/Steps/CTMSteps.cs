using System;
using System.Configuration;
using TechTalk.SpecFlow;
using CTM.Browser;
using CTM.PageObjects;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CTM.Tests
{
    [Binding]
    public class CTMSteps : Steps
    {
        private WebBrowser browser;
        private CompareTheMarket ctm;

        public CTMSteps(WebBrowser browser)
        {
            this.browser = browser;
            this.ctm = new CompareTheMarket(browser.Driver);
        }

        [Given(@"I visit the energy comparison in CTM")]
        public void GivenIVisitTheEnergyComparisonInCTM()
        {
            this.ctm.OpenEnergyComparisonSite();
            Assert.IsFalse(true);
        }
    }
}
