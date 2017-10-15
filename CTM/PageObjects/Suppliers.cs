namespace CTM.PageObjects
{
    using System;
    using System.Configuration;
    using CTM.Extensions;
    using OpenQA.Selenium;
    using OpenQA.Selenium.Support.PageObjects;
    using TechTalk.SpecFlow;
    using OpenQA.Selenium.Support.UI;

    /// <summary>
    /// Summary description for Class1
    /// </summary>
    [Binding]
    public class Suppliers : BasePageObject
    {
        private const string GoodPostCodeXPath = "//*[@id='postcode-question']//*[@class='tick-area']";

        [FindsBy(How = How.Id, Using = "change-postcode")]
        private IWebElement changePostCode;

        [FindsBy(How = How.CssSelector, Using = "#elec-energy-suppliers-question input")]
        private IWebElement elecSuppliersRadio;

        [FindsBy(How = How.CssSelector, Using = "#elec-energy-suppliers-question select")]
        private IWebElement elecSuppliersSelect;

        [FindsBy(How = How.Id, Using = "electricity-supplier-dont-know")]
        private IWebElement elecSupplierDontKnow;

        [FindsBy(How = How.CssSelector, Using = "#gas-energy-suppliers-question input")]
        private IWebElement gasSuppliersRadio;

        [FindsBy(How = How.CssSelector, Using = "#gas-energy-suppliers-question select")]
        private IWebElement gasSuppliersSelect;

        [FindsBy(How = How.Id, Using = "gas-supplier-dont-know")]
        private IWebElement gasSupplierDontKnow;

        [FindsBy(How = How.CssSelector, Using = "#dual-energy-suppliers-question input")]
        private IWebElement dualSuppliersRadio;

        [FindsBy(How = How.CssSelector, Using = "#dual-energy-suppliers-question select")]
        private IWebElement dualSuppliersSelect;

        [FindsBy(How = How.Id, Using = "goto-your-supplier-details")]
        private IWebElement next;

        public Suppliers(IWebDriver webDriver) : base(webDriver)
        {
        }

        [FindsBy(How = How.Id, Using = "your-postcode")]
        public IWebElement PostCode { get; set; }

        [FindsBy(How = How.Id, Using = "find-postcode")]
        public IWebElement FindPostCode { get; set; }

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

        public void GasSupplier(string company, string element)
        {
            this.SelectSupplier("GAS", company, element);
        }

        private void SelectSupplier(string power, string company, string element)
        {
            if (company.Equals("GAS") && element.ToUpper().Equals("RADIO BUTTONS"))
            {

            }
            else if (company.Equals("GAS") && element.ToUpper().Equals("DROPDOWN"))
            {
                new SelectElement(this.gasSuppliersSelect).SelectByText(company);
            }
            else if (company.Equals("ELECTRICITY") && element.ToUpper().Equals("RADIO BUTTONS"))
            {

            }
            else if (company.Equals("ELECTRICITY") && element.ToUpper().Equals("DROPDOWN"))
            {
                new SelectElement(this.elecSuppliersSelect).SelectByText(company);
            }
        }
    }
}