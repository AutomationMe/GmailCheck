using GmailCheck.Drivers;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace GmailCheck.StepDefinitions
{
    [Binding]
    public class GmailStepDefinitions
    {
         

          [Given("User launches gmail login page")]
        public void GivenTheuserlaunchesGmail()
        {
            Initialise._LaunchUrl();

     // Write Assert to check its loaded. Check for a title in the logged in page            

            Thread.Sleep(1000);
            Assert.IsTrue(Initialise._driver.PageSource.Contains("to continue to Gmail"));


        }

        [When("User should be able to logged in")]
        public void WhenUserIsLoggedInToGmail()
        {
            //_main.Login();

        }

        [Then("User gets details of unread emails")]
        public void ThenTheUserGetUnreadEmails()
        {
        }
    }
} 