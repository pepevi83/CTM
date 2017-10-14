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
        [FindsBy(How = How.Id, Using = "go-back")]
        private IWebElement back;

        [FindsBy(How = How.Id, Using = "goto-your-energy")]
        private IWebElement next;

        // Electricity options
        [FindsBy(How = How.Id, Using = "electricity-tariff-additional-info")]
        private IWebElement electricityPlan;

        [FindsBy(How = How.CssSelector, Using = "#economy-7-question input")]
        private IWebElement economy7;

        [FindsBy(How = How.Id, Using = "electricity-payment-method-dropdown-link")]
        private IWebElement elecPaymentMethod;

        [FindsBy(How = How.CssSelector, Using = "#electricity-main-heating-source-question input")]
        private IWebElement elecMainHeating;

        [FindsBy(How = How.CssSelector, Using = "#electricity-usage-question input")]
        private IWebElement elecUsageInput;

        [FindsBy(How = How.Id, Using = "economy-7-day-usage")]
        private IWebElement elecEconomy7DayUsage;

        [FindsBy(How = How.Id, Using = "economy-7-day-usage-dropdown")]
        private IWebElement elecEconomy7DayUsageDropdown;

        [FindsBy(How = How.Id, Using = "economy-7-night-usage")]
        private IWebElement elecEconomy7NightUsage;

        [FindsBy(How = How.Id, Using = "economy-7-night-usage-dropdown")]
        private IWebElement elecEconomy7NightUsageDropdown;

        [FindsBy(How = How.Id, Using = "electricity-usage")]
        private IWebElement elecUsage;

        [FindsBy(How = How.Id, Using = "electricity-usage-dropdown")]
        private IWebElement elecUsageDropdown;

        [FindsBy(How = How.Id, Using = "electricity-spend")]
        private IWebElement elecSpend;

        [FindsBy(How = How.Id, Using = "electricity-spend-dropdown")]
        private IWebElement elecSpendDropdown;

        // Gas options
        [FindsBy(How = How.Id, Using = "gas-tariff-additional-info")]
        private IWebElement gasTariffDropdown;

        [FindsBy(How = How.Id, Using = "gas-payment-method-dropdown-link")]
        private IWebElement gasPaymentMethodDropdown;

        [FindsBy(How = How.CssSelector, Using = "#gas-main-heating-source-question input")]
        private IWebElement gasMainHeating;

        [FindsBy(How = How.CssSelector, Using = "#gas-type-of-bill-question .radio-ticks input")]
        private IWebElement gasTypeBill;

        [FindsBy(How = How.Id, Using = "gas-usage")]
        private IWebElement gasUsage;

        [FindsBy(How = How.Id, Using = "type-of-Gas-bill-usage-dropdown")]
        private IWebElement gasUsageDropdown;

        [FindsBy(How = How.Id, Using = "gas-spend")]
        private IWebElement gasSpend;

        [FindsBy(How = How.Id, Using = "type-of-Gas-bill-dropdown")]
        private IWebElement gasSpendDropdown;

        public Energy(IWebDriver webDriver) : base(webDriver)
        {
        }

        public static Energy NavigateTo(IWebDriver webDriver)
        {
            webDriver.Navigate().GoToUrl(ConfigurationManager.AppSettings["URL"]);

            return new Energy(webDriver);
        }
    }
}