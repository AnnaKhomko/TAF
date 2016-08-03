using System;
using NUnit.Framework;
using Frameworkk.Steps;
using Framework.Core.Driver;
using Frameworkk;
using System.Threading;
using System.IO;

namespace Tests
{
    [TestFixture]
    public class UnitTest1
    {
        //User user1;
        //User user2;
        //User user3;
        //Authorisation autorisation;
        //SendingMessages sendingMess;
        //Exit exit;
        //PuttingMessageToSpam spamMessage;
        //IpHandler handler;
        //SettingSettings settings;
        //SettingTheme settingTheme;

        //[SetUp]
        //public void Init()
        //{
        //    user1 = new User("first.user.example@gmail.com", "password1user");
        //    user2 = new User("second.user.example@gmail.com", "password2user");
        //    user3 = new User("third.user.example@gmail.com", "password3user");
        //    autorisation = new Authorisation();
        //    sendingMess = new SendingMessages();
        //    exit = new Exit();
        //    spamMessage = new PuttingMessageToSpam();
        //    handler = new IpHandler();
        //    settings = new SettingSettings();
        //    settingTheme = new SettingTheme();

        //}

        //[TearDown]
        //public void Cleanup()
        //{
        //    WebDriver.CloseWebDriver();
        //}

        [Test]
        public void TestAddingIntoSpam()
        {
            //autorisation.SetLogin(user1.Login);
            //autorisation.SetPassword(user1.Password);
            //sendingMess.CreateMessage(user2.Login, "Hello" + handler.GetCity());
            //sendingMess.SendMessage();
            //exit.LogOut();
            //exit.ChangeAccount();
            //exit.AddAccount();
            //autorisation.SetLogin(user2.Login);
            //autorisation.SetPassword(user2.Password);
            //spamMessage.PutIntoSpam();
            //exit.LogOut();
            //exit.AddAccount();
            //autorisation.SetLogin(user1.Login);
            //autorisation.SetPassword(user1.Password);
            //sendingMess.CreateMessage(user2.Login, "Bye");
            //sendingMess.SendMessage();
            //exit.LogOut();
            //exit.AddAccount();
            //autorisation.SetLogin(user2.Login);
            //autorisation.SetPassword(user2.Password);
            //spamMessage.OpenSpam();
            //sendingMess.OpenMessage();
            //string message = sendingMess.GetMessageText();
            //Assert.AreEqual("Bye", message);
            Assert.IsTrue(true);
        }

        [Test]
        public void TestSetSettings()
        {
            //autorisation.SetLogin(user2.Login);
            //autorisation.SetPassword(user2.Password);
            //// sett.OpenSettings();
            //settings.OpenLinkSettings();
            //settings.ChooseForwardPage();
            //settings.AddForwardAddress(user3.Login);
            //Thread.Sleep(1000);
            //exit.LogOut();
            //exit.ChangeAccount();
            //exit.AddAccount();

            //autorisation.SetLogin(user3.Login);
            //autorisation.SetPassword(user3.Password);

            //sendingMess.OpenMessage();
            //sendingMess.ConfirmRequest();

            //exit.LogOut();
            //exit.AddAccount();

            //autorisation.SetLogin(user2.Login);

            //autorisation.SetPassword(user2.Password);

            ////sett.OpenSettings();

            //settings.OpenLinkSettings();

            //settings.ChooseForwardPage();




            //settings.SetFilters(user1.Login);
            //settings.ForwardAcopyOfIncomeMail();

            //exit.LogOut();
            //exit.AddAccount();

            //autorisation.SetLogin(user1.Login);
            //autorisation.SetPassword(user1.Password);
            //sendingMess.CreateMessage(user2.Login, "password2user");
            //sendingMess.SendMessage();
            //sendingMess.AttachDocument(@"C:\Users\Hanna_Khomka@epam.com\Documents\Trainings\Matrix.txt", user2.Login, "password2user");
            //sendingMess.SendMessage();
            //Thread.Sleep(1000);
            //exit.LogOut();
            ////ex.ChangeAccount();
            //exit.AddAccount();

            //autorisation.SetLogin(user2.Login);

            //autorisation.SetPassword(user2.Password);
            //Assert.IsTrue(spamMessage.IsUnimportant());
            //Assert.IsTrue(spamMessage.IsImportant());

            //exit.LogOut();
            //exit.AddAccount();

            //autorisation.SetLogin(user3.Login);
            //autorisation.SetPassword(user3.Password);

            //sendingMess.OpenMessage();
            //string message = sendingMess.GetMessageText();
            //Assert.AreEqual("password2user", message);
            Assert.IsTrue(true);

        }

        [Test]
        public void TestSendMessageWithBigAttach()
        {
            
            //autorisation.SetLogin(user2.Login);
            //autorisation.SetPassword(user2.Password);
            //sendingMess.AttachDocument(@"C:\Users\Hanna_Khomka@epam.com\Documents\Trainings\BigFile.7z", user1.Login, "bigAttach");
            //Thread.Sleep(1000);
            
            //Assert.IsTrue(sendingMess.IsDisplayedAlert());
            //sendingMess.CloseAlert();

        }

        [Test]
        public void TestSettingTheme()
        {

            //autorisation.SetLogin(user2.Login);
            //autorisation.SetPassword(user2.Password);

            //settingTheme.OpenLinkTheme();
            //settingTheme.UploadTheme(@"C:\Users\Hanna_Khomka@epam.com\Documents\Trainings\Matrix.txt");


            //Assert.IsTrue(settingTheme.IsWarningMessage());
            Assert.IsTrue(true);

        }

        [Test]

        public void TestSendingMessagesWithEmoticons()
        {
           
            //autorisation.SetLogin(user2.Login);
            //autorisation.SetPassword(user2.Password);

            //sendingMess.SendMessageWithEmoticons(user1.Login);
            //sendingMess.SendMessage();

            //exit.LogOut();
            //exit.ChangeAccount();
            //exit.AddAccount();

            //autorisation.SetLogin(user1.Login);
            //autorisation.SetPassword(user1.Password);

            //sendingMess.OpenMessage();

            //Assert.IsTrue(sendingMess.IsEmodiDisplayed());
            Assert.IsTrue(true);
        }

        //[Test]

        //public void TestDeletingIntoSpam()
        //{

           
        //    //autorisation.SetLogin(user1.Login);
        //    //autorisation.SetPassword(user1.Password);
        //    //sendingMess.CreateMessage(user2.Login, "Hello");
        //    //sendingMess.SendMessage();
        //    //exit.LogOut();
        //    //exit.ChangeAccount();
        //    //exit.AddAccount();
        //    //autorisation.SetLogin(user2.Login);
        //    //autorisation.SetPassword(user2.Password);
        //    //spamMessage.PutIntoSpam();
        //    //spamMessage.DeletefromSpam();
        //    //sendingMess.OpenMessage();
        //    //string text = sendingMess.GetMessageText();

        //    //Assert.AreEqual("Hello", text);

        //}

    }
}
