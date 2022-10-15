using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using System;

namespace Techbodia_Test
{
    internal class SearchChristmasInGoogle
    {
        IWebDriver driver = new ChromeDriver("C:/Users/engso/source/repos/Selenium_Test/packages/Selenium.Chrome.WebDriver.97.0.0");
        [SetUp]
        public void Initialize()
        {
            driver.Navigate().GoToUrl("https://www.google.com/");
            driver.Manage().Window.Maximize();

        }
        [Test]
        public void ExecuteTest()
        {
            IWebElement Input_Field = driver.FindElement(By.Name("q"));
            Input_Field.SendKeys("christmas");
            Input_Field.SendKeys(Keys.Enter);
            String date = driver.FindElement(By.CssSelector("#EtGB6d > div > div > span > div > div > div.zCubwf")).GetAttribute("textContent");
            Assert.AreEqual(date.ToString(), "Sunday, December 25");

        }

        [TearDown]
        public void EndTest()
        {
            // Close the Browser

            driver.Close();
            Console.WriteLine("Search Christmas In Google End");
        }
    }

    internal class SearchHalloweenInWikipedia
    {
        IWebDriver driver = new ChromeDriver("C:/Users/engso/source/repos/Selenium_Test/packages/Selenium.Chrome.WebDriver.97.0.0");
        [SetUp]
        public void Initialize()
        {
            // Open the browser
            // Navigate to url
            driver.Navigate().GoToUrl("https://www.wikipedia.org/");
            driver.Manage().Window.Maximize(); 
        }
        [Test]
        public void ExecuteTest()
        {

            SelectElement drop_down = new SelectElement(driver.FindElement(By.Id("searchLanguage")));
            drop_down.SelectByValue("en");

            IWebElement Input_Field = driver.FindElement(By.Id("searchInput"));
            Input_Field.SendKeys("Halloween");
            Input_Field.SendKeys(Keys.Enter);

            String title = driver.FindElement(By.CssSelector("#firstHeading > span")).GetAttribute("textContent");
            Assert.AreEqual(title.ToString(), "Halloween");

        }

        [TearDown]
        public void EndTest()
        {
            // Close the Browser

            driver.Close();
            Console.WriteLine(" Search Halloween In Wikipedia End");
        }
    }
}
