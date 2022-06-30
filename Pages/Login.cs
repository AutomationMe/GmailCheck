using GmailCheck.Data;
using GmailCheck.Drivers;
using GmailCheck.Reusables;
using GmailCheck.SeleniumExtensions;
using Newtonsoft.Json;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace GmailCheck.Pages
{
   
    public class Login :Extensions
    {

       
        

 By _userName = By.XPath("//input[@type='email']");
 By _usernameNext = By.XPath("//button[@class='VfPpkd-LgbsSe VfPpkd-LgbsSe-OWXEXe-k8QpJ VfPpkd-LgbsSe-OWXEXe-dgl2Hf nCP5yc AjY5Oe DuMIQc qfvgSe qIypjc TrZEUc lw1w4b']");
 By _passWord = By.XPath("//div[class='whsOnd zHQkBf']");
 By _passwordNext = By.XPath("//span[class='VfPpkd-vQzf8d']");


        public void _EnterUsername()
        {
            credentials _cred = new credentials();


            string packageJson = File.ReadAllText("F:\\Anju Learning\\C# Programs\\GmailCheck\\Data\\credentials.cs");

            _cred = JsonConvert.DeserializeObject<credentials>(packageJson);

            var _user = Initialise._driver.FindElement(_userName);
            EnterValue(_userName , _user , _cred.password);


        }
        public void _EnterPassword()
        {
            credentials _cred = new credentials();


            string packageJson = File.ReadAllText("");

            _cred = JsonConvert.DeserializeObject<credentials>(packageJson);

            var _user = Initialise._driver.FindElement(_userName);
            EnterValue(_userName, _user, _cred.password);

        }
        public void _ClickUserNext()
        {


        }
        public void _ClickPwdNext()
        {


        }


    }
}
