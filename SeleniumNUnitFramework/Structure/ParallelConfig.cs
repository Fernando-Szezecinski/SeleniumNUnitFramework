using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;
using WebDriverManager.Helpers;

namespace SeleniumNUnitFramework.Definition
{
    [Binding]
    public class ParallelConfig
    {
        public IWebDriver Driver { get; set; }
        private BasePage currentPage { get; set; }

        [BeforeScenario]
        public IWebDriver SetUpDriver()
        {
            new DriverManager().SetUpDriver(new ChromeConfig(), VersionResolveStrategy.MatchingBrowser);
            Driver = new ChromeDriver();
            return Driver;
        }

        [AfterScenario]
        public void QuitDriver()
        {
            Driver.Quit();
        }

        public T CurrentPage<T>(ParallelConfig parallelConfig) where T : BasePage
        {
            if(currentPage == null)
            {
                currentPage = (T) Activator.CreateInstance(typeof(T), parallelConfig);
            }
            return (T) currentPage;
        }

    }
}
