using System;
using NUnit.Framework;
using Framework.Steps;
using Framework.Core.Driver;
using Framework;
using System.Threading;
using System.IO;

namespace Tests
{
    [TestFixture]
    public class UnitTest1
    {
        User user1;
        User user2;
        User user3;
        Authorisation autorisation;
        SendingMessages sendingMess;
        Exit exit;
        PuttingMessageToSpam spamMessage;
        IpHandler handler;
        SettingSettings settings;
        SettingTheme settingTheme;
        StarredMessages starredMess;

        [SetUp]
        public void Init()
        {
            user1 = new User("first.user.example@gmail.com", "password1user");
            user2 = new User("second.user.example@gmail.com", "password2user");
            user3 = new User("third.user.example@gmail.com", "password3user");
            autorisation = new Authorisation();
            sendingMess = new SendingMessages();
            exit = new Exit();
            spamMessage = new PuttingMessageToSpam();
            handler = new IpHandler();
            settings = new SettingSettings();
            settingTheme = new SettingTheme();
            starredMess = new StarredMessages();

        }

        [TearDown]
        public void Cleanup()
        {
           
           WebDriver.CloseWebDriver();

        }

        [Test]
        public void TestAddingIntoSpam()
        {
            autorisation.SetLogin(user1.Login);
            autorisation.SetPassword(user1.Password);
            sendingMess.CreateMessage(user2.Login, "Hello" + handler.GetCity());
            sendingMess.SendMessage();
           
            exit.LogOut();
            exit.ChangeAccount();
            exit.AddAccount();
            autorisation.SetLogin(user2.Login);
            autorisation.SetPassword(user2.Password);
            spamMessage.PutIntoSpam();
            exit.LogOut();
            exit.AddAccount();
            autorisation.SetLogin(user1.Login);
            autorisation.SetPassword(user1.Password);
            sendingMess.CreateMessage(user2.Login, "Bye");
            sendingMess.SendMessage();
            exit.LogOut();
            exit.AddAccount();
            autorisation.SetLogin(user2.Login);
            autorisation.SetPassword(user2.Password);
            spamMessage.OpenSpam();
            sendingMess.OpenMessage();
            string message = sendingMess.GetMessageText();
            Assert.AreEqual("Bye", message);
            Assert.IsTrue(true);
        }

        [Test]
        public void TestSetSettings()
        {
            string path = TestContext.CurrentContext.TestDirectory;
            autorisation.SetLogin(user2.Login);
            autorisation.SetPassword(user2.Password);
            // sett.OpenSettings();
            settings.OpenLinkSettings();
            settings.ChooseForwardPage();
            settings.AddForwardAddress(user3.Login);
            //Thread.Sleep(1000);
            exit.LogOut();
            exit.ChangeAccount();
            exit.AddAccount();

            autorisation.SetLogin(user3.Login);
            autorisation.SetPassword(user3.Password);

            sendingMess.OpenMessage();
            sendingMess.ConfirmRequest();

            exit.LogOut();
            exit.AddAccount();

            autorisation.SetLogin(user2.Login);

            autorisation.SetPassword(user2.Password);

            //sett.OpenSettings();

            settings.OpenLinkSettings();

            settings.ChooseForwardPage();




            settings.SetFilters(user1.Login);
            settings.ForwardAcopyOfIncomeMail();

            //Thread.Sleep(1000);
            exit.LogOut();
            exit.AddAccount();

            autorisation.SetLogin(user1.Login);
            autorisation.SetPassword(user1.Password);
            sendingMess.CreateMessage(user2.Login, "password2user");
            sendingMess.SendMessage();
            sendingMess.AttachDocument(path+Data.FileName, user2.Login, "password2user");
            Thread.Sleep(1000);
            sendingMess.SendMessage();
            //Thread.Sleep(1000);
            exit.LogOut();
            //ex.ChangeAccount();
            exit.AddAccount();

            autorisation.SetLogin(user2.Login);

            autorisation.SetPassword(user2.Password);
            Assert.IsTrue(spamMessage.IsUnimportant());
            Assert.IsTrue(spamMessage.IsImportant());

            exit.LogOut();
            exit.AddAccount();

            autorisation.SetLogin(user3.Login);
            autorisation.SetPassword(user3.Password);

            sendingMess.OpenMessage();
            string message = sendingMess.GetMessageText();
            Assert.AreEqual("password2user", message);
            Assert.IsTrue(true);

            exit.LogOut();
            exit.AddAccount();

            autorisation.SetLogin(user2.Login);
            autorisation.SetPassword(user2.Password);
            // sett.OpenSettings();
            settings.OpenLinkSettings();
            settings.ChooseForwardPage();

            settings.ClearSettings();

        }

        [Test]
        public void TestSendMessageWithBigAttach()
        {
            string path = TestContext.CurrentContext.TestDirectory;
            autorisation.SetLogin(user2.Login);
            autorisation.SetPassword(user2.Password);
            sendingMess.AttachDocument(path+Data.BigFileName, user1.Login, "bigAttach");
            Thread.Sleep(1000);

            Assert.IsTrue(sendingMess.IsDisplayedAlert());
            sendingMess.CloseAlert();

        }

        [Test]
        public void TestSettingTheme()
        {
            string path = TestContext.CurrentContext.TestDirectory;
            autorisation.SetLogin(user2.Login);
            autorisation.SetPassword(user2.Password);

            settingTheme.OpenLinkTheme();
            settingTheme.UploadTheme(path+Data.FileName);


            Assert.IsTrue(settingTheme.IsWarningMessage());
            Assert.IsTrue(true);

        }

        [Test]

        public void TestSendingMessagesWithEmoticons()
        {

            autorisation.SetLogin(user2.Login);
            autorisation.SetPassword(user2.Password);

            sendingMess.SendMessageWithEmoticons(user1.Login);
            sendingMess.SendMessage();

            exit.LogOut();
            exit.ChangeAccount();
            exit.AddAccount();

            autorisation.SetLogin(user1.Login);
            autorisation.SetPassword(user1.Password);

            sendingMess.OpenMessage();

            Assert.IsTrue(sendingMess.IsEmodiDisplayed());
            Assert.IsTrue(true);
        }

        [Test]

        public void TestDeletingIntoSpam()
        {


            autorisation.SetLogin(user1.Login);
            autorisation.SetPassword(user1.Password);
            sendingMess.CreateMessage(user2.Login, "Hello");
            sendingMess.SendMessage();
            exit.LogOut();
            exit.ChangeAccount();
            exit.AddAccount();
            autorisation.SetLogin(user2.Login);
            autorisation.SetPassword(user2.Password);
            spamMessage.PutIntoSpam();
            spamMessage.DeletefromSpam();
            Thread.Sleep(1000);
            sendingMess.OpenMessage();
            string text = sendingMess.GetMessageText();

            Assert.AreEqual("Hello", text);

        }

        [Test]
        public void SettingSignature()
        {
            autorisation.SetLogin(user2.Login);
            autorisation.SetPassword(user2.Password);
           // sett.OpenSettings();
            settings.OpenLinkSettings();
            settings.SetSignature(user2.Login);
            Thread.Sleep(1000);
            //sendingMess.CreateMessage(user3.Login, "hello");

            Assert.IsTrue(settings.IsSignature(user2.Login));
        }

        [Test]
        public void StarredMessage()
        {
            autorisation.SetLogin(user3.Login);
            autorisation.SetPassword(user3.Password);
            starredMess.StarredMessage();
            Assert.IsTrue(starredMess.IsStarred());
        }
    }
}
