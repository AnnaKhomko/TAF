using Framework.Elements;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework.Pages
{
    public class MailPage
    {
        public Button BtCompose
        {
            get
            {
                return new Button("//div[text()='COMPOSE']");
            }
        }
        public Link LMore
        {
            get
            {
                return new Link("//span[text()='More']");
            }
        }
        
        public Link LSpam
        {
            get
            {
                return new Link("//div[3]/div/div/div/div[4]/div/div/div");
            }
        }
        public Link LAccount
        {
            get
            {
                return new Link("//div/a/span");
            }
        }
        public Button BtSignOut
        {
            get
            {
                return new Button("//a[text()='Sign out']");
            }
        }
        public Link LMessage
        {
            get
            {
                return new Link("//td[6]/div/div/div");
            }
        }
        public TextArea TaMessageText
        {
            get
            {
                return new TextArea("//div[2]/div[7]/div/div");
            }
        }

        public Link LChangeAccount
        {
            get
            {
                return new Link("//*[@id=\"account-chooser-link\"]");

            }
        } 

        public Link LAddAccount
        {
            get
            {
                return new Link("//a[text()='Add account']");
            }
        }

        public Button BtWin
        {
            get
            {
                return new Button("//div[23]");
            }
        }

        public Link LTrash
        {
            get
            {
                return new Link("//div[3]/div/div/div/div[5]/div/div/div");
            }
        }

        public Link LImportant
        {
            get
            {
                return new Link("//div[@aria-label='Important because it matched one of your importance filters.']");
            }
        }
        public Link LUnImportant
        {
            get
            {
                return new Link("//div[@aria-label='Not important']");
            }
        }

        public Button BtFirstEmodi
        {
            get
            {
                return new Button("//img[@data-goomoji='1f60e']");
            }
        }

        public Button BtSecondEmodi
        {
            get
            {
                return new Button("//img[@data-goomoji='1f60d']");
            }
        }

        public Link LInbox
        {
            get
            {
                return new Link("//span/a");
            }
        }

        public Button BtNotSpam
        {
            get
            {
                return new Button("//div[text()='Not spam']");
            }
        }

        public CheckBox ChbSpamCheckbox
        {
            get
            {
                return new CheckBox("//div[4]/div/div/table/tbody/tr/td[2]/div");
            }
        }

        public Link LStar
        {
            get
            {
                return new Link("//span[@aria-label='Not starred']");
            }
        }

        public Link LStarred
        {
            get
            {
                return new Link("//a[contains(text(),'Starred')]");
            }
        }

        public CheckBox ChbStarred
        {
            get
            {
                return new CheckBox("//div[4]/div/div/table/tbody/tr/td[3]/span");
            }
        }

    }
}
