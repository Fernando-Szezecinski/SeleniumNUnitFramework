using NUnit.Framework;
using SeleniumNUnitFramework.Definition;
using TechTalk.SpecFlow;

namespace SeleniumNUnitFramework.Steps
{
    [Binding]
    public class BrowserSteps : BaseStep
    {
        public BrowserSteps(ParallelConfig parallelConfig) : base(parallelConfig)
        {
        }

        [Given(@"I am accessing the url '(.*)'")]
        public void GoToUrl(string url)
        {
            _parallelConfig.Driver.Navigate().GoToUrl(url);
        }

        [Then(@"system displays the page '(.*)'")]
        public void ValidateUrl(string currentUrl)
        {
            Assert.That(_parallelConfig.Driver.Url.Contains(currentUrl));
        }


    }
}
