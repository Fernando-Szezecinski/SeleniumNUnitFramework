using OpenQA.Selenium;
using SeleniumNUnitFramework.Definition;
using SeleniumNUnitFramework.Extensions;

namespace SeleniumNUnitFramework.Pages
{   
    public class LoginPage : BasePage
    {
        IWebElement txtUser => _parallelConfig.Driver.FindByXpath("/html/body/div/main/div/div/form/div[1]/input");
        IWebElement txtPassword => _parallelConfig.Driver.FindByXpath("/html/body/div/main/div/div/form/div[2]/input");
        IWebElement btnLogin => _parallelConfig.Driver.FindByXpath("/html/body/div/main/div/div/form/div[3]/input");

        public LoginPage(ParallelConfig parallelConfig) : base(parallelConfig)
        {

        }

        public void Login(string user, string pass)
        {
            txtUser.Clear();
            txtUser.SendKeys(user);
            txtPassword.Clear();
            txtPassword.SendKeys(pass);
            btnLogin.Click();
        }
    }
}
