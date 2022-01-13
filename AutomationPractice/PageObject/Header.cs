using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;

namespace AutomationPractice.PageObject
{
    public class Header
    {
        protected IWebDriver _driver;

        private By _contactUs = By.LinkText("Contact us");
        private By _contactBannerSale70 = By.CssSelector(".row > a > .img-responsive");
        private By _contactSignIn = By.LinkText("Sign in");
        private By _contactWomenClick = By.CssSelector(".sfHover > .sf-with-ul");
        private By _contactWomenHoverTops = By.CssSelector(".submenu-container > .sfHover > .sf-with-ul");
        private By _contactWomenHoverTShips = By.CssSelector(".submenu-container > .sfHover .sfHover > a");
        private By _contactWomenHoverBlouses = By.XPath("//li[2]/a");
        private By _contactDressesClick = By.CssSelector(".sfHover > .sf-with-ul");
        private By _contactDressesHoverCasual = By.CssSelector(".sfHover:nth-child(1) > a");
        private By _contactDressesHoverEvening = By.CssSelector(".submenu-container > .sfHover > a");
        private By _contactDressesHoverSummer = By.CssSelector(".sfHover:nth-child(3) > a");
        private By _contactTShirtsClick = By.CssSelector(".sfHover > a");
        private By _contactWomenHoverDresses = By.CssSelector(".sfHover:nth-child(2) > .sf-with-ul");
        private By _contactWomenHoverCasual = By.CssSelector(".sfHoverForce .sfHover > a");
        private By _contactWomenHoverEvening = By.CssSelector(".sfHover:nth-child(2) .sfHover > a");
        private By _contactWomenHoverSummer = By.CssSelector(".sfHover:nth-child(3) > a");
        private By _contactYourLogo = By.CssSelector(".logo");
        private By _contactSearch = By.CssSelector("#search_query_top");
        private By _contactCart = By.CssSelector(".shopping_cart > a");
        public ContactBannerSale70 ContactBannerSale70()
        {
            _driver.FindElement(_contactUs).Click();
            _driver.FindElement(_contactBannerSale70).Click();
            return new ContactBannerSale70(_driver);
        }
        public ContactContact ContactContact()
        {
            _driver.FindElement(_contactUs).Click();
            _driver.FindElement(_contactUs).Click();
            return new ContactContact(_driver);
        }
        public ContactSignIn ContactSignIn()
        {
            _driver.FindElement(_contactUs).Click();
            _driver.FindElement(_contactSignIn).Click();
            return new ContactSignIn(_driver);
        }
        public ContactWomenClick ContactWomenClick()
        {
            _driver.FindElement(_contactUs).Click();
            _driver.FindElement(_contactWomenClick).Click();
            return new ContactWomenClick(_driver);
        }
        public ContactWomenHoverTops ContactWomenHoverTops()
        {
            _driver.FindElement(_contactUs).Click();
            Actions actions = new Actions(_driver);
            actions.MoveToElement(_driver.FindElement(_contactWomenClick)).Perform();
            _driver.FindElement(_contactWomenHoverTops).Click();
            return new ContactWomenHoverTops(_driver);
        }
        public ContactWomenHoverTShips ContactWomenHoverTShips()
        {
            _driver.FindElement(_contactUs).Click();
            Actions actions = new Actions(_driver);
            actions.MoveToElement(_driver.FindElement(_contactWomenClick)).Perform();
            _driver.FindElement(_contactWomenHoverTShips).Click();
            return new ContactWomenHoverTShips(_driver);
        }
        public ContactWomenHoverBlouses ContactWomenHoverBlouses()
        {
            _driver.FindElement(_contactUs).Click();
            Actions actions = new Actions(_driver);
            actions.MoveToElement(_driver.FindElement(_contactWomenClick)).Perform();
            _driver.FindElement(_contactWomenHoverBlouses).Click();
            return new ContactWomenHoverBlouses(_driver);
        }
        public ContactDressesClick ContactDressesClick()
        {
            _driver.FindElement(_contactUs).Click();
            _driver.FindElement(_contactDressesClick).Click();
            return new ContactDressesClick(_driver);
        }
        public ContactDressesHoverCasual ContactDressesHoverCasual()
        {
            _driver.FindElement(_contactUs).Click();
            Actions actions = new Actions(_driver);
            actions.MoveToElement(_driver.FindElement(_contactDressesClick)).Perform();
            _driver.FindElement(_contactDressesHoverCasual).Click();
            return new ContactDressesHoverCasual(_driver);
        }
        public ContactDressesHoverEvening ContactDressesHoverEvening()
        {
            _driver.FindElement(_contactUs).Click();
            Actions actions = new Actions(_driver);
            actions.MoveToElement(_driver.FindElement(_contactDressesClick)).Perform();
            _driver.FindElement(_contactDressesHoverEvening).Click();
            return new ContactDressesHoverEvening(_driver);
        }
        public ContactDressesHoverSummer ContactDressesHoverSummer()
        {
            _driver.FindElement(_contactUs).Click();
            Actions actions = new Actions(_driver);
            actions.MoveToElement(_driver.FindElement(_contactDressesClick)).Perform();
            _driver.FindElement(_contactDressesHoverSummer).Click();
            return new ContactDressesHoverSummer(_driver);
        }
        public ContactTShirtsClick ContactTShirtsClick()
        {
            _driver.FindElement(_contactUs).Click();
            _driver.FindElement(_contactTShirtsClick).Click();
            return new ContactTShirtsClick(_driver);
        }
        public ContactWomenHoverDresses ContactWomenHoverDresses()
        {
            _driver.FindElement(_contactUs).Click();
            Actions actions = new Actions(_driver);
            actions.MoveToElement(_driver.FindElement(_contactWomenClick)).Perform();
            _driver.FindElement(_contactWomenHoverDresses).Click();
            return new ContactWomenHoverDresses(_driver);
        }
        public ContactWomenHoverCasual ContactWomenHoverCasual()
        {
            _driver.FindElement(_contactUs).Click();
            Actions actions = new Actions(_driver);
            actions.MoveToElement(_driver.FindElement(_contactWomenClick)).Perform();
            _driver.FindElement(_contactWomenHoverCasual).Click();
            return new ContactWomenHoverCasual(_driver);
        }
        public ContactWomanHoverEvening ContactWomanHoverEvening()
        {
            _driver.FindElement(_contactUs).Click();
            Actions actions = new Actions(_driver);
            actions.MoveToElement(_driver.FindElement(_contactWomenClick)).Perform();
            _driver.FindElement(_contactWomenHoverEvening).Click();
            return new ContactWomanHoverEvening(_driver);
        }
        public ContactWomenHoverSummer ContactWomenHoverSummer()
        {
            _driver.FindElement(_contactUs).Click();
            Actions actions = new Actions(_driver);
            actions.MoveToElement(_driver.FindElement(_contactWomenClick)).Perform();
            _driver.FindElement(_contactWomenHoverSummer).Click();
            return new ContactWomenHoverSummer(_driver);
        }
        public ContactYourLogo ContactYourLogo()
        {
            _driver.FindElement(_contactUs).Click();
            _driver.FindElement(_contactYourLogo).Click();
            return new ContactYourLogo(_driver);
        }
        public ContactSearchShirts ContactSearchShirts()
        {
            _driver.FindElement(_contactUs).Click();
            _driver.FindElement(_contactSearch).SendKeys("Shirts");
            _driver.FindElement(_contactSearch).SendKeys(Keys.Enter);
            return new ContactSearchShirts(_driver);
        }
        public ContactCart ContactCart()
        {
            _driver.FindElement(_contactUs).Click();
            _driver.FindElement(_contactCart).Click();
            return new ContactCart(_driver);
        }
    }
}
