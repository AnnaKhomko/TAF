using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Framework.Core;
using Frameworkk.Elements;
using OpenQA.Selenium;
using Framework.Core.Element;
using Framework.Core.Driver;

namespace Frameworkk.Pages
{
    public class LoginPage : Page
    {
        //public string Uri { get; }
        public Button BtNext
        {
            get
            {
                return new Button("//*[@id=\"next\"]");
            }
        }

        public Button BtLogIn
        {
            get
            {
                return new Button("//*[@id=\"signIn\"]");
            }
        }

        public Input InpLogin
        {
            get
            {
                return new Input("//*[@id=\"Email\"]");
            }
        }

        public Input InpPassword
        {
            get
            {
                return new Input("//*[@id=\"Passwd\"]");
            }
        }

        public Link LChangeAccounr
        {
            get
            {
                return new Link("//a[contains(text(),'Sign in with a different account')]");
            }
        }

        public LoginPage(string Uri)
        {
            WebDriver.OpenWebDriver();
            WebDriver.GetDriver().Navigate().GoToUrl(Uri);


            
        }

    }
}
