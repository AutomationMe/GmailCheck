using GmailCheck.Drivers;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GmailCheck.SeleniumExtensions
{
    public class Extensions
    {
        
        public bool IsAvailable(By _Ele)
        {
            //Explicit wait

            try
            {
                WebDriverWait wait = new WebDriverWait(Initialise._driver, TimeSpan.FromSeconds(10));
                IWebElement SearchResult = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(_Ele)); 
                
                return true;
            }
            catch(Exception e)
            {
                return false;
            }
          

            
           
        }
        public void IsClickable()
        {

        }
        //Checks the element is available and click the button
        public void Click()
        {

        }
        //Checks the element is available and enter the value
        public void EnterValue(By _Ele , IWebElement _user , string _value)
        {
            bool _available = IsAvailable(_Ele);
            if (_available==true)
            {
                _user.Clear();

                _user.SendKeys("anjukuttan92@gmail.com");
                
            }
        }

    }
}
