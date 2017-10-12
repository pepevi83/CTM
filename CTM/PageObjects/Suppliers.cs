using System;
using System.Collections.Generic;
using System.Globalization;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;

/// <summary>
/// Summary description for Class1
/// </summary>
public abstract class Suppliers : BasePageObject
{
    [FindsBy(How = How.Id, Using = "your-postcode")]
    private IWebElement postCodeInput;

    [FindsBy(How = How.Id, Using = "find-postcode")]
    private IWebElement findPostCode;

    [FindsBy(How = How.Id, Using = "change-postcode")]
    private IWebElement changePostCode;

    [FindsBy(How = How.CssSelector, Using = ".have-bill-yes")]
    private IWebElement haveBillYes;

    [FindsBy(How = How.CssSelector, Using = ".have-bill-no")]
    private IWebElement haveBillNo;

    [FindsBy(How = How.CssSelector, Using = ".energy-gas-electricity")]
    private IWebElement compareGasElectricity;

    [FindsBy(How = How.CssSelector, Using = ".energy-electricity")]
    private IWebElement compareElectricity;

    [FindsBy(How = How.CssSelector, Using = ".energy-gas")]
    private IWebElement compareGas;

    [FindsBy(How = How.Id, Using = "same-supplier-yes")]
    private IWebElement sameSupplierYes;

    [FindsBy(How = How.Id, Using = "same-supplier-no")]
    private IWebElement sameSupplierNo;

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
        //
        // TODO: Add constructor logic here
        //
    }
}
