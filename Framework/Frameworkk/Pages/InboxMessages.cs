using Frameworkk.Elements;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frameworkk.Pages
{
    public class InboxMessages
    {
        public CheckBox ChbCheckMessage
        {
            get
            {
                return new CheckBox("//div[2]/div/table/tbody/tr/td[2]/div/div");
            }
        }
        public Button BtReportSpam
        {
            get
            {
                return new Button("//div[2]/div/div/div/div/div/div/div/div/div/div[2]/div[2]");
            }
        }
    }
}
