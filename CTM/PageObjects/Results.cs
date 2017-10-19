namespace CTM.PageObjects
{
    using CTM.Extensions;
    using OpenQA.Selenium;
    using OpenQA.Selenium.Support.PageObjects;

    public class Results : BasePageObject
    {
         private const string SearchingPricesInterstitial = "interstitial-overlay";
        
        public Results(IWebDriver webDriver) : base(webDriver)
        {
        }

        public void WaitForSearchingPricesInterstitialToBeInvisible()
        {
            this.Driver.WaitForElementVisible(By.CssSelector(SearchingPricesInterstitial));

            this.Driver.WaitForElementInvisible(By.CssSelector(SearchingPricesInterstitial));
        }
    }
}
