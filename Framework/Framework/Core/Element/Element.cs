using Framework.Core.Driver;
using Framework.Core.Utils;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework.Core.Element
{
    public class Element
    {
        public string xPath;
        IWebDriver driver = WebDriver.GetDriver();
        Waiters waiter = new Waiters();

        public Element(string xPath)
        {
            this.xPath = xPath;
        }

        public By ByElement 
        {
            get
            {
                return By.XPath(xPath);
            }
        }

        public IWebElement IElement
        {
            get
            {
                return waiter.WaitForElement(20, ByElement);
            }
        }
    }
}
