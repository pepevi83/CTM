namespace CTM.PageObjects
{
    using System.Configuration;
    using CTM.Extensions;
    using OpenQA.Selenium;
    using OpenQA.Selenium.Support.PageObjects;
    using TechTalk.SpecFlow;

    /// <summary>
    /// Summary description for Class1
    /// </summary>
    [Binding]
    public class Suppliers : BasePageObject
    {
        private const string GoodPostCodeXPath = "//*[@id='postcode-question']//*[@class='tick-area']";
        private const string SupplierRadio = ".//label[@supplier-name='{0}']";

        [FindsBy(How = How.CssSelector, Using = "#elec-energy-suppliers-question")]
        private IWebElement elecSupplierQuestion;

        [FindsBy(How = How.CssSelector, Using = "#elec-energy-suppliers-question select")]
        private IWebElement elecSuppliersSelect;

        [FindsBy(How = How.XPath, Using = "#gas-energy-suppliers-question")]
        private IWebElement gasSupplierQuestion;

        [FindsBy(How = How.CssSelector, Using = "#gas-energy-suppliers-question select")]
        private IWebElement gasSuppliersSelect;

        [FindsBy(How = How.CssSelector, Using = "#dual-energy-suppliers-question")]
        private IWebElement dualSuppliersQuestion;

        [FindsBy(How = How.CssSelector, Using = "#dual-energy-suppliers-question select")]
        private IWebElement dualSuppliersSelect;

        public Suppliers(IWebDriver webDriver) : base(webDriver)
        {
        }

        [FindsBy(How = How.Id, Using = "your-postcode")]
        public IWebElement PostCode { get; set; }

        [FindsBy(How = How.Id, Using = "find-postcode")]
        public IWebElement FindPostCode { get; set; }

        [FindsBy(How = How.Id, Using = "change-postcode")]
        public IWebElement ChangePostCode { get; set; }

        [FindsBy(How = How.CssSelector, Using = ".have-bill-yes")]
        public IWebElement IHaveBillHandy { get; set; }
        
        [FindsBy(How = How.CssSelector, Using = ".have-bill-no")]
        public IWebElement IDontHaveBillHandy { get; set; }

        [FindsBy(How = How.CssSelector, Using = ".energy-gas-electricity")]
        public IWebElement CompareGasAndElectricity { get; set; }

        [FindsBy(How = How.CssSelector, Using = ".energy-electricity")]
        public IWebElement CompareElectricity { get; set; }

        [FindsBy(How = How.CssSelector, Using = ".energy-gas")]
        public IWebElement CompareGas { get; set; }

        [FindsBy(How = How.Id, Using = "same-supplier-yes")]
        public IWebElement GasAndElectricitySameSupplier { get; set; }

        [FindsBy(How = How.Id, Using = "same-supplier-no")]
        public IWebElement GasAndElectricityNoSameSupplier { get; set; }

        [FindsBy(How = How.Id, Using = "electricity-supplier-dont-know")]
        public IWebElement ElecSupplierDontKnow { get; set; }

        [FindsBy(How = How.Id, Using = "gas-supplier-dont-know")]
        public IWebElement GasSupplierDontKnow { get; set; }

        [FindsBy(How = How.Id, Using = "goto-your-supplier-details")]
        private IWebElement Next { get; set; }

        public static Suppliers NavigateTo(IWebDriver webDriver)
        {
            webDriver.Navigate().GoToUrl(ConfigurationManager.AppSettings["URL"]);

            return new Suppliers(webDriver);
        }

        public bool IsValidPostCode()
        {
            try
            {
                this.Driver.WaitForElementVisible(By.XPath(GoodPostCodeXPath));
                return true;
            }
            catch
            {
                return false;
            }
        }

        public void ElectricitySupplier(string company, string element)
        {
            this.SelectSupplier("ELECTRICITY", company, element);
        }

        public void DualSupplier(string company, string element)
        {
            this.SelectSupplier("DUAL", company, element);
        }

        public void GasSupplier(string company, string element)
        {
            this.SelectSupplier("GAS", company, element);
        }

        private void SelectSupplier(string power, string company, string element)
        {
            if (company.Equals("GAS") && element.Equals("RADIO BUTTONS"))
            {
                this.gasSupplierQuestion.FindElement(By.XPath(string.Format(SupplierRadio, company)));
            }
            else if (company.Equals("GAS") && element.Equals("DROPDOWN"))
            {
                this.gasSuppliersSelect.SelectByText(company);
            }
            else if (company.Equals("ELECTRICITY") && element.Equals("RADIO BUTTONS"))
            {
                this.elecSupplierQuestion.FindElement(By.XPath(string.Format(SupplierRadio, company)));
            }
            else if (company.Equals("ELECTRICITY") && element.Equals("DROPDOWN"))
            {
                this.elecSuppliersSelect.SelectByText(company);
            }
            else if (company.Equals("DUAL") && element.Equals("RADIO BUTTONS"))
            {
                this.dualSuppliersQuestion.FindElement(By.XPath(string.Format(SupplierRadio, company)));
            }
            else if (company.Equals("DUAL") && element.Equals("DROPDOWN"))
            {
                this.dualSuppliersSelect.SelectByText(company);
            }
        }
    }
}