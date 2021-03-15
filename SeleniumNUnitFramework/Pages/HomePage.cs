using OpenQA.Selenium;
using SeleniumNUnitFramework.Definition;
using SeleniumNUnitFramework.Extensions;

namespace SeleniumNUnitFramework.Pages
{
    public class HomePage : BasePage
    {
        IWebElement lnkLogin => _parallelConfig.Driver.FindByXpath("/html/body/header/nav/div/div/ul/li[2]/a");

        public HomePage(ParallelConfig parallelConfig) : base(parallelConfig)
        {

        }

        public void ClickLogin() => lnkLogin.Click();
    }
}
