namespace CTM.PageObjects
{
    using System.Configuration;
    using OpenQA.Selenium;
    using OpenQA.Selenium.Support.PageObjects;    

    /// <summary>
    /// Summary description for Class1
    /// </summary>
    public class Energy : BasePageObject
    {
        public Energy(IWebDriver webDriver) : base(webDriver)
        {
        }

        // Electricity options
        [FindsBy(How = How.Id, Using = "electricity-tariff-additional-info")]
        public IWebElement ElectricityPlan { get; set; }

        [FindsBy(How = How.Id, Using = "economy-7-yes")]
        public IWebElement Economy7Yes { get; set; }

        [FindsBy(How = How.Id, Using = "economy-7-no")]
        public IWebElement Economy7No { get; set; }

        [FindsBy(How = How.Id, Using = "electricity-payment-method-dropdown-link")]
        public IWebElement ElecPaymentMethod { get; set; }

        [FindsBy(How = How.Id, Using = "electricity-main-heating-yes")]
        public IWebElement ElecMainHeatingYes { get; set; }

        [FindsBy(How = How.Id, Using = "electricity-main-heating-no")]
        public IWebElement ElecMainHeatingNo { get; set; }

        [FindsBy(How = How.Id, Using = "kwhSpend")]
        public IWebElement ElecUsageKwh { get; set; }

        [FindsBy(How = How.Id, Using = "poundSpend")]
        public IWebElement ElecUsagePound { get; set; }

        [FindsBy(How = How.Id, Using = "economy-7-day-usage")]
        public IWebElement ElecEconomy7DayUsage { get; set; }

        [FindsBy(How = How.Id, Using = "economy-7-day-usage-dropdown")]
        public IWebElement ElecEconomy7DayUsageDropdown { get; set; }

        [FindsBy(How = How.Id, Using = "economy-7-night-usage")]
        public IWebElement ElecEconomy7NightUsage { get; set; }

        [FindsBy(How = How.Id, Using = "economy-7-night-usage-dropdown")]
        public IWebElement ElecEconomy7NightUsageDropdown { get; set; }

        [FindsBy(How = How.Id, Using = "electricity-usage")]
        public IWebElement ElecUsageInput { get; set; }

        [FindsBy(How = How.Id, Using = "electricity-usage-dropdown")]
        public IWebElement elecUsageDropdown { get; set; }

        [FindsBy(How = How.Id, Using = "electricity-spend")]
        public IWebElement ElecSpend { get; set; }

        [FindsBy(How = How.Id, Using = "electricity-spend-dropdown")]
        public IWebElement ElecSpendDropdown { get; set; }

        // Gas options
        [FindsBy(How = How.Id, Using = "gas-tariff-additional-info")]
        private IWebElement GasTariffDropdown { get; set; }

        [FindsBy(How = How.Id, Using = "gas-payment-method-dropdown-link")]
        private IWebElement GasPaymentMethodDropdown { get; set; }

        [FindsBy(How = How.Id, Using = "gas-main-heating-yes")]
        private IWebElement GasMainHeatingYes { get; set; }

        [FindsBy(How = How.Id, Using = "gas-main-heating-no")]
        private IWebElement GasMainHeatingNo { get; set; }

        [FindsBy(How = How.Id, Using = "kwhSpendG")]
        private IWebElement GasUsageKwh { get; set; }

        [FindsBy(How = How.Id, Using = "poundSpendG")]
        private IWebElement GasUsagePound { get; set; }

        [FindsBy(How = How.Id, Using = "gas-usage")]
        private IWebElement GasUsageInput { get; set; }

        [FindsBy(How = How.Id, Using = "type-of-Gas-bill-usage-dropdown")]
        private IWebElement GasUsageDropdown { get; set; }

        [FindsBy(How = How.Id, Using = "gas-spend")]
        private IWebElement GasSpend { get; set; }

        [FindsBy(How = How.Id, Using = "type-of-Gas-bill-dropdown")]
        private IWebElement GasSpendDropdown { get; set; }

        // Navigation
        [FindsBy(How = How.Id, Using = "go-back")]
        private IWebElement Back;

        [FindsBy(How = How.Id, Using = "goto-your-energy")]
        private IWebElement Next;
    }
}