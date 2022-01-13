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
    public class BannerWomensCoats : Body
    {
        public BannerWomensCoats(IWebDriver driver)
        {
            _driver = driver;
        }
    }
}
