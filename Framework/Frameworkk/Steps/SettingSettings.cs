using Framework.Core.Driver;
using Frameworkk.Elements;
using Frameworkk.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Frameworkk.Steps
{
    public class SettingSettings
    {
        Settings sett = new Settings();

        public void OpenSettings()
        {

           
            sett.BtSettings.Click();
        }

        public void OpenLinkSettings()
        {

            WebDriver.GetDriver().Navigate().GoToUrl(sett.uri);
        }

        public void ChooseForwardPage()
        {

           
            sett.LForwarding.FollowToLink();
        }

        public void AddForwardAddress(string address)
        {
            sett.BtAddForwAddress.Click();
            Thread.Sleep(100);
            sett.InpAddress.SetText(address);
            sett.BtNext.Click();

            WebDriver.GetDriver().SwitchTo()
                .Window(WebDriver.GetDriver().WindowHandles.Last());
            
            sett.BtProceed.Click();

            WebDriver.GetDriver().SwitchTo()
               .Window(WebDriver.GetDriver().WindowHandles.First());
            
            sett.BtOk.Click();
           
        }

        public void ForwardAcopyOfIncomeMail()
        {
            sett.RbForwardACopy.Select();
            sett.BtSaveChanges.Click();
        }

        public void SetFilters(string address)
        {
            sett.LFilters.FollowToLink();
            sett.InpFrom.SetText(address);
            sett.ChbHasAttachment.Select();
            sett.LFilterWithSearch.FollowToLink();
            sett.ChbDeleteIt.Select();
            sett.ChbMarkAsImportant.Select();
            sett.BtCreateFilters.Click();
        }

    }
}
