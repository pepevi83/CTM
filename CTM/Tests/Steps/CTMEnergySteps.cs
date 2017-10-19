namespace CTM.Tests
{
    using CTM.Browser;
    using CTM.Extensions;
    using CTM.PageObjects;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using TechTalk.SpecFlow;

    [Binding]
    public class CTMSteps : Steps
    {
        private WebBrowser browser;

        public CTMSteps(WebBrowser browser)
        {
            this.browser = browser;
        }

        [Given(@"I visit the energy comparison site on CTM")]
        public void GivenIVisitTheEnergyComparisonSiteOnCTM()
        {
            ScenarioContext.Current.Add("SuppliersSection", Suppliers.NavigateTo(this.browser.Driver));
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
            else
            {
                suppliersSection.IDontHaveBillHandy.Click();
            }
        }

        [When(@"I want to compare (.*)")]
        public void WhenIWantToCompareGasElectricity(string option)
        {
            var suppliersSection = ScenarioContext.Get<Suppliers>("SuppliersSection");

            switch (option.ToUpper())
            {
                case "GAS&ELECTRICITY":
                    suppliersSection.CompareGasAndElectricity.Click();
                    break;
                case "ELECTRICITY ONLY":
                    suppliersSection.CompareElectricity.Click();
                    break;
                case "GAS ONLY":
                    suppliersSection.CompareGas.Click();
                    break;
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
            else
            {
                suppliersSection.GasAndElectricityNoSameSupplier.Click();
            }
        }

        [When(@"I select (.*) as (.*) supplier from (.*)")]
        public void WhenISelectE_ONAsElectricitySupplierFromRadioButtons(string company, string power, string element)
        {
            var suppliersSection = ScenarioContext.Get<Suppliers>("SuppliersSection");

            switch (power.ToUpper())
            {
                case "ELECTRICITY":
                    suppliersSection.ElectricitySupplier(company, element.ToUpper());
                    break;
                case "GAS":
                    suppliersSection.GasSupplier(company, element.ToUpper());
                    break;
                case "DUAL":
                    suppliersSection.DualSupplier(company, element.ToUpper());
                    break;
            }
        }

        [When(@"I click on Next on Suppliers")]
        public void WhenIClickOnNextOnSuppliers()
        {
            var suppliersSection = ScenarioContext.Get<Suppliers>("SuppliersSection");

            ScenarioContext.Current.Add("EnergySection", suppliersSection.ClickOnNext());
        }

        [When(@"My electricity plan is (.*)")]
        public void WhenMyElectricityPlanIsAgeUKFixedYear(string electricityPlan)
        {
            var energySection = ScenarioContext.Get<Energy>("EnergySection");

            energySection.ElectricityPlan.SelectByText(electricityPlan);
        }

        [When(@"I select (.*) in Economy 7 meter")]
        public void WhenISelectNoInEconomyMeter(string option)
        {
            var energySection = ScenarioContext.Get<Energy>("EnergySection");

            if (option.ToUpper().Equals("YES"))
            {
                energySection.Economy7Yes.Click();
            }
            else
            {
                energySection.Economy7No.Click();
            }
        }

        [When(@"I pay my electricity bill (.*)")]
        public void WhenIPayMyElectricityBillMonthlyDirectDebit(string paymentMethod)
        {
            var energySection = ScenarioContext.Get<Energy>("EnergySection");

            energySection.ElecPaymentMethod.SelectByText(paymentMethod);
        }

        [When(@"I select (.*) in electricity is my main source of heating")]
        public void WhenISelectYesInElectricityIsMyMainSourceOfHeating(string option)
        {
            var energySection = ScenarioContext.Get<Energy>("EnergySection");

            if (option.ToUpper().Equals("YES"))
            {
                energySection.ElecMainHeatingYes.Click();
            }
            else
            {
                energySection.ElecMainHeatingNo.Click();
            }
        }

        [When(@"My current electricity in (.*) is (.*) (.*)")]
        public void WhenMyCurrentElectricityInKWhIsMonthly(string unit, string total, string period)
        {
            var energySection = ScenarioContext.Get<Energy>("EnergySection");

            if (unit.ToUpper().Equals("KWH"))
            {
                energySection.ElecUsageKwh.Click();
                energySection.ElecUsageInput.SendKeys(total);
                energySection.ElecUsageDropdown.SelectByText(period);
            }
            else
            {
                energySection.ElecUsagePound.Click();
                energySection.ElecSpendInput.SendKeys(total);
                energySection.ElecSpendDropdown.SelectByText(period);
            }
        }
    }
}
