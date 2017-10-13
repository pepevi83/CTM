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
        private BasePageObject ctm;

        public CTMSteps(WebBrowser browser)
        {
            this.browser = browser;
        }

        [Given(@"I visit the energy comparison in CTM")]
        public void GivenIVisitTheEnergyComparisonInCTM()
        {
            var energySection = Energy.NavigateTo(this.browser.Driver);
            Assert.IsFalse(true);
        }
    }
}
