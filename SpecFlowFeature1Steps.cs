using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;

namespace AutomationBootcamp
{
    [Binding]
    public class SpecFlowFeature1Steps
    {
        IWebDriver driver;
        [Given(@"the user has navigated to wikipedia")]
        public void GivenTheUserHasNavigatedToWikipedia()
        {
            driver = new ChromeDriver
            {
                Url = "https://en.wikipedia.org/wiki/Main_Page"
            };
        }

        [When(@"the user enters '(.*)' into the search field")]
        public void WhenTheUserEntersIntoTheSearchField(string data)
        {
            driver.FindElement(By.Id("searchInput")).SendKeys(data);
        }

        [When(@"clicks search")]
        public void WhenClicksSearch()
        {
            driver.FindElement(By.Id("searchButton")).Click();
        }

        [Then(@"they will have results on '(.*)'")]
        public void ThenTheyWillHaveResultsOn(string data)
        {
            string title = driver.Title;
            Assert.IsTrue(title.Contains(data));
        }
    }
}
