using Microsoft.VisualStudio.TestTools.UnitTesting;
using FitnessApp;
using System.Reflection;
using System.Threading;
using System.Windows.Forms;
using System;

namespace FitnessAppTests
{
    [TestClass]
    public class MainFormTests
    {
        private MainForm mainForm;
        private bool isLoggedIn;
        private string currentUsername;

        [TestInitialize]
        public void SetUp()
        {
            mainForm = new MainForm();
            // Default login for tests requiring user to be logged in
            isLoggedIn = mainForm.Login("test", "test");
            SimulateKeyPress("{ENTER}"); // Handle message box for login
            RefreshLoginStatus();
        }

        [TestCleanup]
        public void TearDown()
        {
            mainForm.Dispose();
        }

        private void SimulateKeyPress(string keys)
        {
            Thread.Sleep(500); // Adjust this time based on the actual time it takes for the message box to appear

            // Attempt to find and focus the message box window before sending keys
            IntPtr messageBoxWindow = FindWindow("#32770", "Alerta"); // #32770 is the class for a standard message box, "Alerta" is the new title
            if (messageBoxWindow != IntPtr.Zero)
            {
                SetForegroundWindow(messageBoxWindow);  // Set focus to the message box
            }

            SendKeys.SendWait(keys);
            Thread.Sleep(500); // Allow time for the message box to close
        }


        // You'll need to import these methods from the user32.dll
        [System.Runtime.InteropServices.DllImport("user32.dll", SetLastError = true)]
        static extern IntPtr FindWindow(string lpClassName, string lpWindowName);

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        [return: System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.Bool)]
        static extern bool SetForegroundWindow(IntPtr hWnd);


        private void RefreshLoginStatus()
        {
            isLoggedIn = (bool)mainForm.GetType().GetField("isLoggedIn", BindingFlags.NonPublic | BindingFlags.Instance).GetValue(mainForm);
            currentUsername = (string)mainForm.GetType().GetField("currentUsername", BindingFlags.NonPublic | BindingFlags.Instance).GetValue(mainForm);
        }

       
}
