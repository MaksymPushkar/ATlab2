using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;

namespace lab2
{
    public class Tests
    {
        public IWebDriver Driver;

        [SetUp]
        public void Setup()
        {
            Console.WriteLine("Setup");
            Driver = new ChromeDriver();
        }

        [Test]
        public void Test1()
        {
            int pauseIntervalInMiliseconds = 1000;
            int endPauseIntervalInMiliseconds = 3000;

            Driver.Navigate().GoToUrl("https://www.saucedemo.com/");
            Driver.Manage().Window.Maximize();


            IWebElement inputUserName = Driver.FindElement(By.Id("user-name"));
            inputUserName.SendKeys("problem_user");
            Thread.Sleep(pauseIntervalInMiliseconds);
            IWebElement inputPassword = Driver.FindElement(By.Id("password"));
            inputPassword.SendKeys("secret_sauce");
            Thread.Sleep(pauseIntervalInMiliseconds);
            IWebElement buttonLogin = Driver.FindElement(By.Id("login-button"));
            buttonLogin.Click();
            Thread.Sleep(pauseIntervalInMiliseconds);


            IWebElement buttonAddToCartSauceLabsBackpack = Driver.FindElement(By.Id("add-to-cart-sauce-labs-backpack"));
            buttonAddToCartSauceLabsBackpack.Click();
            Thread.Sleep(pauseIntervalInMiliseconds);
            IWebElement linkShoppingCartLink = Driver.FindElement(By.ClassName("shopping_cart_link"));
            linkShoppingCartLink.Click();
            Thread.Sleep(pauseIntervalInMiliseconds);
            IWebElement buttonRemoveSauceLabsBackpack = Driver.FindElement(By.Id("remove-sauce-labs-backpack"));
            buttonRemoveSauceLabsBackpack.Click();
            Thread.Sleep(pauseIntervalInMiliseconds);
            IWebElement buttonContinueShopping = Driver.FindElement(By.Id("continue-shopping"));
            buttonContinueShopping.Click();
            Thread.Sleep(pauseIntervalInMiliseconds);


            Thread.Sleep(endPauseIntervalInMiliseconds);
            Driver.Quit();
            Console.WriteLine("Test1");
            Assert.Pass();
        }
    }
}