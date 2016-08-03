using Framework.Core.Driver;
using Frameworkk.Elements;
using Frameworkk.Pages;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frameworkk.Steps
{
    public class Exit
    {
        MailPage mp = new MailPage();

        public void LogOut()
        {

           
            mp.LAccount.FollowToLink();
            mp.BtSignOut.Click();


        }

        public void ChangeAccount()
        {
            mp.LChangeAccount.FollowToLink();
           

        }

        public void AddAccount()
        {
           
            mp.LAddAccount.FollowToLink();
        }

    }
}
