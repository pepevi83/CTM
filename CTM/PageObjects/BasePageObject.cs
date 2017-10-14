namespace CTM.PageObjects
{
    using OpenQA.Selenium;
    using OpenQA.Selenium.Support.PageObjects;

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
        
        protected BasePageObject(IWebDriver webDriver)
        {
            this.driver = webDriver;
            PageFactory.InitElements(webDriver, this);
        }
    }
}