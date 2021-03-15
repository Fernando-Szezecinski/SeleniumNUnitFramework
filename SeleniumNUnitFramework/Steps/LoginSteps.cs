using SeleniumNUnitFramework.Definition;
using SeleniumNUnitFramework.Pages;
using TechTalk.SpecFlow;

namespace SeleniumNUnitFramework.Steps
{
    [Binding]
    public class LoginSteps : BaseStep
    {
        public LoginSteps(ParallelConfig parallelConfig) : base(parallelConfig)
        {
        }

        [When(@"I authenticate with user '(.*)' and password '(.*)'")]
        public void Authenticate(string user, string password)
        {
            _parallelConfig
                .CurrentPage<LoginPage>(_parallelConfig)
                    .Login(user, password);
        }

    }
}
