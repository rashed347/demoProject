using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLoginProject
{
    class SetMethod
    {
        public static IWebElement FindElement (By element)
        {
            IWebElement fndelm = PropertiesCollection.driver.FindElement(element);
            return fndelm;
        }
    }
}
