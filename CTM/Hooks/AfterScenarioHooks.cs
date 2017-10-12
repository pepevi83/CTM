using System;
using System.Drawing.Imaging;
using System.Globalization;
using CTM.Browser;
using OpenQA.Selenium.Support.Extensions;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using NUnit.Framework;

namespace CTM.Hooks
{
    [Binding]
    public sealed class AfterScenarioHooks
    {
        private readonly WebBrowser browser;

        public AfterScenarioHooks(WebBrowser browser)
        {
            this.browser = browser;
        }

        [AfterScenario]
        public void Teardown()
        {
            try
            {
                if (ScenarioContext.Current.TestError != null)
                {
                    var screenshot = ((ITakesScreenshot)this.browser.Driver).GetScreenshot();

                    var date = DateTime.Now.ToString("yyyMMdd_HHmmss");

                    var fileName = string.Format(
                                        CultureInfo.CurrentCulture,
                                        "{0}_{1}_{2}.png",
                                        FeatureContext.Current.FeatureInfo.Title,
                                        ScenarioContext.Current.ScenarioInfo.Title,
                                        date);

                    try
                    {
                        screenshot.SaveAsFile(fileName, ScreenshotImageFormat.Png);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Exception Writing Screenshot Image!");
                        while (ex != null)
                        {
                            if (!string.IsNullOrEmpty(ex.Message))
                            {
                                Console.WriteLine("Exception: " + ex.GetType());
                                Console.WriteLine(ex.Message);
                            }

                            ex = ex.InnerException;
                        }
                    }
                }
            }
            finally
            {
                this.browser.Teardown();
            }
        }
    }
}
