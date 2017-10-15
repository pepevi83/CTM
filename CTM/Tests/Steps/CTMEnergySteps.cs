namespace CTM.Tests
{
    using CTM.Browser;
    using CTM.PageObjects;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using TechTalk.SpecFlow;

    [Binding]
    public class CTMSteps : Steps
    {
        private WebBrowser browser;
        private BasePageObject ctm;

        public CTMSteps(WebBrowser browser)
        {
            this.browser = browser;
        }

        [Given(@"I visit the energy comparison site on CTM")]
        public void GivenIVisitTheEnergyComparisonSiteOnCTM()
        {
            var suppliersSection = Suppliers.NavigateTo(this.browser.Driver);
            ScenarioContext.Current.Add("SuppliersSection", suppliersSection);
        }

        [When(@"I enter (.*) postCode")]
        public void WhenIEnterPEYSPostCode(string postCode)
        {
            var suppliersSection = ScenarioContext.Get<Suppliers>("SuppliersSection");

            suppliersSection.PostCode.SendKeys(postCode);
            suppliersSection.FindPostCode.Click();
        }

        [When(@"I verify is a valid PostCode")]
        public void WhenIVerifyIsAValidPostCode()
        {
            var suppliersSection = ScenarioContext.Get<Suppliers>("SuppliersSection");

            Assert.IsTrue(suppliersSection.IsValidPostCode());
        }

        [When(@"I select (.*) in I have my bill handy")]
        public void WhenISelectIHaveMyBillHandy(string option)
        {
            var suppliersSection = ScenarioContext.Get<Suppliers>("SuppliersSection");

            if (option.ToUpper().Equals("YES"))
            {
                suppliersSection.IHaveBillHandy.Click();
            }
            else if (option.ToUpper().Equals("NO"))
            {
                suppliersSection.IDontHaveBillHandy.Click();
            }
        }

        [When(@"I want to compare (.*)")]
        public void WhenIWantToCompareGasElectricity(string option)
        {
            var suppliersSection = ScenarioContext.Get<Suppliers>("SuppliersSection");

            if (option.ToUpper().Equals("GAS&ELECTRICITY"))
            {
                suppliersSection.CompareGasAndElectricity.Click();
            }
            else if (option.ToUpper().Equals("ELECTRICITY ONLY"))
            {
                suppliersSection.CompareElectricity.Click();
            }
            else if (option.ToUpper().Equals("GAS ONLY"))
            {
                suppliersSection.CompareGas.Click();
            }
        }

        [When(@"I select (.*) in Gas&Electricy is same supplier")]
        public void WhenISelectNoInGasElectricyIsSameSupplier(string option)
        {
            var suppliersSection = ScenarioContext.Get<Suppliers>("SuppliersSection");

            if (option.ToUpper().Equals("YES"))
            {
                suppliersSection.GasAndElectricitySameSupplier.Click();
            }
            else if (option.ToUpper().Equals("NO"))
            {
                suppliersSection.GasAndElectricityNoSameSupplier.Click();
            }
        }

        [When(@"I select (.*) as (.*) supplier from (.*)")]
        public void WhenISelectE_ONAsElectricitySupplierFromRadioButtons(string company, string power, string element)
        {
            var suppliersSection = ScenarioContext.Get<Suppliers>("SuppliersSection");

            if (power.ToUpper().Equals("ELECTRICITY"))
            {
                suppliersSection.ElectricitySupplier(company, element);
            }
            else if (power.ToUpper().Equals("GAS"))
            {
                suppliersSection.GasSupplier(company, element);
            }
        }
    }
}
