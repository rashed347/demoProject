using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLoginProject
{
    class Program
    {
        static void Main(string[] args)
        {
        }
        [SetUp]
        public void OpenBrowser()
        {
          PropertiesCollection.driver = new ChromeDriver();
            PropertiesCollection.driver.Manage().Window.Maximize();
           PropertiesCollection.driver.Navigate().GoToUrl("http://bridge-app.azurewebsites.net/");
            WaitFor.PageLoading();
            WaitFor.ElementNotVisible(".//div[@class = 'blockUI blockOverlay']");
            WaitFor.ElementToVisible(By.XPath(LoginPage.XloginBtn));
        }
     
        [Test]
        public void LoginWithValidCredential()
        {
            LoginPage.Login("rashed", "1qaz!QAZ");
        }
    }
}
