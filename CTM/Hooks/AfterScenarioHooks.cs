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
        private readonly WebBrowser webBrowser;

        private readonly ScenarioContext scenarioContext;

        private readonly FeatureContext featureContext;

        public AfterScenarioHooks(WebBrowser browser)
        {
            this.webBrowser = browser;
        }

        [AfterScenario]
        public void Teardown()
        {
            try
            {
                if (this.scenarioContext.TestError != null)
                {
                    var screenshot = ((ITakesScreenshot)this.webBrowser.Driver).GetScreenshot();

                    var date = DateTime.Now.ToString("yyyMMdd_HHmmss");

                    var fileName = string.Format(
                                        CultureInfo.CurrentCulture,
                                        "[{0}][{1}] {2}_{3}.png",
                                        TestContext.CurrentContext.Test.Name,
                                        FeatureContext.Current.FeatureInfo.Title,
                                        this.featureContext.FeatureInfo.Title,
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
                this.webBrowser.Teardown();
            }
        }
    }
}
