using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace AutomationPractice.PageObject
{
    public class ContactDressesClick : Header
    {
        public ContactDressesClick(IWebDriver driver)
        {
            _driver = driver;
        }
    }
}
