namespace CTM.Extensions
{
    using System;
    using OpenQA.Selenium;
    using OpenQA.Selenium.Support.UI;

    public static class DriverExtensions
    {
        public static void WaitForElementVisible(this IWebDriver driver, By by, int timeout = 5)
        {
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(timeout));

            wait.Until(ExpectedConditions.ElementIsVisible(by));
        }
    }
}
