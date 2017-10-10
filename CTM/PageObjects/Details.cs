﻿using System;
using System.Collections.Generic;
using System.Globalization;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;

/// <summary>
/// Summary description for Class1
/// </summary>
public abstract class Details : BasePaseObject
{
    
    [FindsBy(How = How.XPath, Using = "//div[@id='tariff-selection-question']//input")]
    private IWebElement tariffType;
    
    [FindsBy(How = How.XPath, Using = "//div[@id='payment-selection-question']//input")]
    private IWebElement paymentType;

    [FindsBy(How = How.Id, Using = "Email")]
    private IWebElement email;

    [FindsBy(How = How.Id, Using = "marketingPreference")]
    private IWebElement marketingPreference;

    [FindsBy(How = How.Id, Using = "terms")]
    private IWebElement terms;

    [FindsBy(How = How.Id, Using = "go-back")]
    private IWebElement back;
    
    [FindsBy(How = How.Id, Using = "email-submit")]
    private IWebElement goToPrices;

    public Details(IWebDriver webDriver) : base(webDriver)
    {
		//
		// TODO: Add constructor logic here
		//
	}
}
