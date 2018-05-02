using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLoginProject
{
    class LoginPage
    {
        public const string XloginBtn = ".//button[@type = 'submit']";

        private static IWebElement TxtUserName = SetMethod.FindElement(By.XPath(".//input[@name = 'userNameOrEmailAddress']"));
        private static IWebElement TxtPassword = SetMethod.FindElement(By.XPath(".//input[@name = 'password']"));
        private static IWebElement BtnLogin = SetMethod.FindElement(By.XPath(XloginBtn));

        public static void Login (string userName, string passWord)
        {
            TxtUserName.SendKeys(userName);
            TxtPassword.SendKeys(passWord);
            BtnLogin.Click();
        }
    }
}
