using Frameworkk.Elements;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frameworkk.Pages
{
    public class MessageBoxPage
    {
        public TextArea TaReceiver
        {
            get
            {
                return new TextArea("//textarea[@name='to']");
            }
        }
        public TextArea TaMessage
        {
            get
            {
                return new TextArea("//tbody/tr/td[2]/div[2]/div");
            }
        }
        public Button BtSend
        {
            get
            {
                return new Button("//div[text()='Send']");
            }
        }

        public Button BtAttach
        {
            get
            {
                return new Button("//td[4]/div/div/div/div");
            }
        }

        public TextArea WarningMessage
        {
            get
            {
                return new TextArea("//div[@class='bab']");
            }
        }

        public Button CloseAlert
        {
            get
            {
                return new Button("//span[@aria-label='Close']");
            }
        }

        public Button BtEmoticons
        {
            get
            {
                return new Button("//div[@class='QT aaA aMZ']");
            }
        }

        public Button BtFirsEmodi
        {
            get
            {
                return new Button("//button[@string='1f60e']");
            }
        }

        public Button BtSecondEmodi
        {
            get
            {
                return new Button("//button[@string='1f60d']");
            }
        }

        public Button BtAllEmoticons
        {
            get
            {
                return new Button("//button[@title='Show face emoticons']");
            }
        }
    }
}
