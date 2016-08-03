﻿using Framework.Core.Driver;
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
    public class Authorisation
    {
        LoginPage lp = new LoginPage("http://gmail.com/");
        public void SetLogin(string login)
        {
            lp.InpLogin.SetText(login);
            lp.BtNext.Click();
        }

        public void SetPassword(string password)
        {
            lp.InpPassword.SetText(password);
            lp.BtLogIn.Click();
        }
    }
}
