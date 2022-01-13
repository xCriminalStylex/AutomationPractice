using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;

namespace AutomationPractice.PageObject
{
    public class SlyderSymple1: Body
    {
        public SlyderSymple1(IWebDriver driver)
        {
            _driver = driver;
        }
    }
}
