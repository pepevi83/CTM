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
public abstract class BasePageObject
{
    private readonly IWebDriver driver;

    [FindsBy(How = How.Id, Using = "ctm-logo")]
    private IWebElement logo;

    [FindsBy(How = How.CssSelector, Using = "#header-container li span.text")]
    private IWebElement sections;

    public BasePageObject(IWebDriver webDriver)
    {
        driver = webDriver;
        PageFactory.InitElements(this.Driver, this);
    }
}
