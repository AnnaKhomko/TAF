using Frameworkk.Elements;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frameworkk.Pages
{
    public class Settings
    {
        public Button BtSettings
        {
            get
            {
                return new Button("//div[2]/div/div/div/div/div[4]/div[2]/div[2]/div");
            }
        }
        public Link LForwarding
        {
            get
            {
                return new Link("//a[text()='Forwarding and POP/IMAP']");

            }
        }
        public Button BtAddForwAddress
        {
            get
            {
                return new Button("//input[@value='Add a forwarding address']");
            }
        }
        public Input InpAddress
        {
            get
            {
                return new Input("//*[@class='PN']/input");
            }
        }
        public Button BtNext
        {
            get
            {
                return new Button("//button[text()='Next']");
            }
        }
        public Button BtProceed
        {
            get
            {
                return new Button("//input[@value='Proceed']");
            }
        }
        public Button BtOk
        {
            get
            {
                return new Button("//button[@name='ok']");
            }
        }
        public RadioButton RbForwardACopy
        {
            get
            {
                return new RadioButton("//span[contains(.,'Forward a copy of incoming mail to')]/../preceding-sibling::td/input");
            }
        }
        public Link LFilters
        {
            get
            {
                return new Link("//span[text()='creating a filter!']");
            }
        }
        public Input InpFrom
        {
            get
            {
                return new Input("//span[2]/input");
            }
        }
        public CheckBox ChbHasAttachment
        {
            get
            {
                return new CheckBox("//div[7]/span/input");
            }
        }
        public CheckBox ChbDeleteIt
        {
            get
            {
                return new CheckBox("//div[6]/input");
            }
        }
        public Link LFilterWithSearch
        {
            get
            {
                return new Link("//div[text()='Create filter with this search »']");
            }
        }
        public CheckBox ChbMarkAsImportant
        {
            get
            {
                return new CheckBox("//div[8]/input");
            }
        }
        public Button BtCreateFilters
        {
            get
            {
                return new Button("//div[text()='Create filter']");
            }
        }

        public Button BtConfirm
        {
            get
            {
                return new Button("//input[@value='Confirm']");
            }
        }


        public Link LconReq
        {
            get
            {
                return new Link("//a[4]");
            }
        } 

        public Button BtSaveChanges
        {
            get
            {
                return new Button("/html/body/div[7]/div[3]/div/div[2]/div[1]/div[2]/div/div/div/div[2]/div[1]/div[1]/div/div/div/div/div/div/div[6]/div/table/tbody/tr[4]/td/div/button[1]");
            }
        }



        public string uri = "https://mail.google.com/mail/#settings/general";
    }
}
