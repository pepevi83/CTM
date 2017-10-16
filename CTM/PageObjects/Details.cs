namespace CTM.PageObjects
{
    using OpenQA.Selenium;
    using OpenQA.Selenium.Support.PageObjects;

    /// <summary>
    /// Summary description for Class1
    /// </summary>
    public class Details : BasePageObject
    {
        public Details(IWebDriver webDriver) : base(webDriver)
        {
        }

        [FindsBy(How = How.CssSelector, Using = ".fixed-rate")]
        public IWebElement FixedTariff { get; set; }

        [FindsBy(How = How.CssSelector, Using = ".variable-rate")]
        public IWebElement VariableTariff { get; set; }

        [FindsBy(How = How.CssSelector, Using = ".both-rate")]
        public IWebElement AllTariff { get; set; }

        [FindsBy(How = How.CssSelector, Using = ".payment-monthly")]
        public IWebElement MonthlyPayment { get; set; }

        [FindsBy(How = How.CssSelector, Using = ".payment-quarterly")]
        public IWebElement QuarterlyPayment { get; set; }

        [FindsBy(How = How.CssSelector, Using = ".payment-onbill")]
        public IWebElement OnBillPayment { get; set; }

        [FindsBy(How = How.CssSelector, Using = ".payment-all")]
        public IWebElement AllPayment { get; set; }

        [FindsBy(How = How.Id, Using = "Email")]
        public IWebElement Email { get; set; }

        [FindsBy(How = How.Id, Using = "marketingPreference")]
        public IWebElement MarketingPreference { get; set; }

        [FindsBy(How = How.Id, Using = "terms")]
        public IWebElement Terms { get; set; }

        [FindsBy(How = How.Id, Using = "go-back")]
        public IWebElement Back { get; set; }

        [FindsBy(How = How.Id, Using = "email-submit")]
        public IWebElement GoToPrices { get; set; }
    }
}
