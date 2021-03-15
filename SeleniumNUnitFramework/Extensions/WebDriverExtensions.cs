using OpenQA.Selenium;
using System;
using System.Diagnostics;

namespace SeleniumNUnitFramework.Extensions
{
    public static class WebDriverExtensions
    {

        public static void WaitForPageLoaded(this IWebDriver driver)
        {
            driver.WaitForCondition(dri =>
            {
                string state = ((IJavaScriptExecutor)dri).ExecuteScript("return document.readyState").ToString();
                return state == "complete";
            }, 10);
        }

        public static void WaitForCondition<T>(this T obj, Func<T, bool> condition, int timeOut)
        {
            Func<T, bool> execute =
                (arg) =>
                {
                    try
                    {
                        return condition(arg);
                    }
                    catch (Exception e)
                    {
                        return false;
                    }
                };

            var stopWatch = Stopwatch.StartNew();
            while (stopWatch.ElapsedMilliseconds < timeOut)
            {
                if (execute(obj))
                {
                    break;
                }
            }
        }

        public static IWebElement FindById(this IWebDriver webDriver, string element)
        {
            try
            {
                if (webDriver.FindElement(By.Id(element)).Displayed)
                {
                    return webDriver.FindElement(By.Id(element));
                }
            }
            catch (Exception e)
            {
                throw new ElementNotVisibleException($"Element not found : {element}");
            }
            return null;
        }

        public static IWebElement FindByXpath(this IWebDriver webDriver, string element)
        {
            try
            {
                if (webDriver.FindElement(By.XPath(element)).Displayed)
                {
                    return webDriver.FindElement(By.XPath(element));
                }
            }
            catch (Exception e)
            {
                throw new ElementNotVisibleException($"Element not found : {element}");
            }
            return null;
        }

        public static IWebElement FindByCss(this IWebDriver webDriver, string element)
        {
            try
            {
                if (webDriver.FindElement(By.CssSelector(element)).Displayed)
                {
                    return webDriver.FindElement(By.CssSelector(element));
                }
            }
            catch (Exception e)
            {
                throw new ElementNotVisibleException($"Element not found : {element}");
            }
            return null;
        }

        public static IWebElement FindByLinkText(this IWebDriver webDriver, string element)
        {
            try
            {
                if (webDriver.FindElement(By.LinkText(element)).Displayed)
                {
                    return webDriver.FindElement(By.LinkText(element));
                }
            }
            catch (Exception e)
            {
                throw new ElementNotVisibleException($"Element not found : {element}");
            }
            return null;
        }

    }
}
