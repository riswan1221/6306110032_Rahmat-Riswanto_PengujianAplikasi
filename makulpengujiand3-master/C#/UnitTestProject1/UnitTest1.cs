using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Automation.Peers;
using System.Windows.Controls;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyCalculatorv1;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        private MainWindow aps = new MainWindow();
        [TestMethod]
        public void tesTambah()
        {
            
            double exp = 4;
            double act = aps.tmbh(2, 2);
            Assert.AreEqual<double>(exp, act, "ok ?");
        }

        [TestMethod]
        public void tesKurang()
        {
            double exp = 0;
            double act = aps.krng(2, 2);
            Assert.AreEqual<double>(exp, act, "ok ?");
        }

        [TestMethod]
        public void tekKali()
        {
            double exp = 4;
            double act = aps.kali(2, 2);
            Assert.AreEqual<double>(exp, act, "ok ?");
        }
        [TestMethod]
        public void tesBagi()
        {
            double exp = 1;
            double act = aps.bagi(2, 2);
            Assert.AreEqual<double>(exp, act, "ok ?");
        }
        [TestMethod]
        public void tesDel_btn()
        {
            aps.Show();
            WindowAutomationPeer wpa = new WindowAutomationPeer(aps);
            List<AutomationPeer> anak = wpa.GetChildren();

            TextBoxAutomationPeer textBoxPeer = (TextBoxAutomationPeer)anak[1];
            ButtonAutomationPeer buttonPeer = (ButtonAutomationPeer)anak[17];

            Button but = (Button)buttonPeer.Owner;
            TextBox tek = (TextBox)textBoxPeer.Owner;

            RoutedEventArgs args = new RoutedEventArgs(Button.ClickEvent, but);
            but.RaiseEvent(args);
            Assert.AreEqual("", tek.Text.ToString(), "Invalid");
        }
    }
}
