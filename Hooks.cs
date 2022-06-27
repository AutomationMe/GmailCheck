using GmailCheck.Drivers;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;

namespace GmailCheck
{
    [Binding]
    public sealed class Hooks
    { 


        [BeforeScenario]
        public void FirstBeforeScenario()
        {
            ChromeOptions options = new ChromeOptions();
            options.AddArguments("--incognito");
            Initialise._driver = new ChromeDriver(options);
        }

        [AfterScenario]
        public void AfterScenario()
        {
            Initialise._driver.Quit();
        }
    }
}