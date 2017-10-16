namespace CTM.Extensions
{
    using OpenQA.Selenium;
    using OpenQA.Selenium.Support.UI;

    public static class ElementExtensions
    {
        public static void SelectByText(this IWebElement element, string text)
        {
            new SelectElement(element).SelectByText(text);
        }
    }
}