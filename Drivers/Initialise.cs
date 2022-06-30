using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GmailCheck.Drivers
{
    public static class Initialise
    {
        public static IWebDriver _driver
        //returns and set values
        { get; set; }

        public static void _LaunchUrl()
        {
            _driver.Navigate().GoToUrl("https://www.gmail.com");
            
        }

    }
}
