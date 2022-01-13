using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace AutomationPractice.PageObject
{
    public class ContactWomenHoverSummer : Header
    {
        public ContactWomenHoverSummer(IWebDriver driver)
        {
            _driver = driver;
        }
    }
}
