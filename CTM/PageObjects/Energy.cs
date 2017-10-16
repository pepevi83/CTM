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
        public IWebElement GasTariffDropdown { get; set; }

        [FindsBy(How = How.Id, Using = "gas-payment-method-dropdown-link")]
        public IWebElement GasPaymentMethodDropdown { get; set; }

        [FindsBy(How = How.Id, Using = "gas-main-heating-yes")]
        public IWebElement GasMainHeatingYes { get; set; }

        [FindsBy(How = How.Id, Using = "gas-main-heating-no")]
        public IWebElement GasMainHeatingNo { get; set; }

        [FindsBy(How = How.Id, Using = "kwhSpendG")]
        public IWebElement GasUsageKwh { get; set; }

        [FindsBy(How = How.Id, Using = "poundSpendG")]
        public IWebElement GasUsagePound { get; set; }

        [FindsBy(How = How.Id, Using = "gas-usage")]
        public IWebElement GasUsageInput { get; set; }

        [FindsBy(How = How.Id, Using = "type-of-Gas-bill-usage-dropdown")]
        public IWebElement GasUsageDropdown { get; set; }

        [FindsBy(How = How.Id, Using = "gas-spend")]
        public IWebElement GasSpend { get; set; }

        [FindsBy(How = How.Id, Using = "type-of-Gas-bill-dropdown")]
        public IWebElement GasSpendDropdown { get; set; }

        // Energy Usage
        [FindsBy(How = How.Id, Using = "one-two-bedroom")]
        public IWebElement OneTwoBedroom { get; set; }

        [FindsBy(How = How.Id, Using = "three-four-bedroom")]
        public IWebElement YhreeFourBedroom { get; set; }

        [FindsBy(How = How.Id, Using = "five-plus-bedroom")]
        public IWebElement FivePlusBedroom { get; set; }

        [FindsBy(How = How.Id, Using = "one-two-occupants")]
        public IWebElement OneTwoOcuppants { get; set; }

        [FindsBy(How = How.Id, Using = "three-four-occupants")]
        public IWebElement ThreeFourOcuppants { get; set; }

        [FindsBy(How = How.Id, Using = "five-plus-occupants")]
        public IWebElement FivePlusOcuppants { get; set; }

        [FindsBy(How = How.Id, Using = "gas-heat")]
        public IWebElement GasHeating { get; set; }

        [FindsBy(How = How.Id, Using = "electricity-heat")]
        public IWebElement ElectricityHeating { get; set; }

        [FindsBy(How = How.Id, Using = "other-heat")]
        public IWebElement OtherHeating { get; set; }

        [FindsBy(How = How.Id, Using = "arctic")]
        public IWebElement ArticTemperature { get; set; }

        [FindsBy(How = How.Id, Using = "temperate")]
        public IWebElement TemperateTemperature { get; set; }

        [FindsBy(How = How.Id, Using = "tropical")]
        public IWebElement TropicalTemperature { get; set; }

        [FindsBy(How = How.Id, Using = "wafer-thin")]
        public IWebElement WaferThinInsulation { get; set; }

        [FindsBy(How = How.Id, Using = "well-wrapped")]
        public IWebElement WellWrappedInsulation { get; set; }

        [FindsBy(How = How.Id, Using = "airtight")]
        public IWebElement AirtightInsulation { get; set; }

        [FindsBy(How = How.Id, Using = "gas-cooking")]
        public IWebElement GasMainSourceCooking { get; set; }

        [FindsBy(How = How.Id, Using = "electricity-cooking")]
        public IWebElement ElectricityMainSourceCooking { get; set; }

        [FindsBy(How = How.Id, Using = "other-cooking")]
        public IWebElement OtherMainSourceCooking { get; set; }

        [FindsBy(How = How.Id, Using = "hardly-ever")]
        public IWebElement HardlyEverSomeone { get; set; }

        [FindsBy(How = How.Id, Using = "evenings-weekends")]
        public IWebElement EveningAndWeekendsSomeone { get; set; }

        [FindsBy(How = How.Id, Using = "most-time")]
        public IWebElement MostOfTimeSomeone { get; set; }

        // Navigation
        [FindsBy(How = How.Id, Using = "go-back")]
        public IWebElement Back;

        [FindsBy(How = How.Id, Using = "goto-your-energy")]
        [FindsBy(How = How.Id, Using = "goto-person-details-button")]
        public IWebElement Next;
    }
}