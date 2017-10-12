using System;
using System.Configuration;
using TechTalk.SpecFlow;
using CTM.Browser;


namespace CTM.Tests.Steps
{
    [Binding]
    public class CTMSteps
    {
        private WebBrowser browser;
        private BasePageObject basePage;

        public CTMSteps(WebBrowser browser, BasePageObject basePage)
        {
            this.browser = browser;
            this.basePage = basePage;
        }

        [Given(@"I visit the energy comparison in CTM")]
        public void GivenIVisitTheEnergyComparisonInCTM()
        {
            this.basePage.OpenEnergyComparisonSite();
        }
    }
}
