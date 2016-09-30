using System.Linq;
using TechTalk.SpecFlow;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Interactions;
using System.Collections.ObjectModel;
using OpenQA.Selenium.Support.PageObjects;


namespace valtech1
{
    [Binding]
    public sealed class StepDefinitionValtech
    {

        ValtechPageObject HomepagePageObjects = new ValtechPageObject();
        IWebDriver driver = new InternetExplorerDriver();

        [Given(@"that I navigate to the url ""(.*)""")]
        public void GivenThatINavigateToTheUrl(string p0)
        {
            driver.Navigate().GoToUrl(p0);
            driver.Manage().Window.Maximize();

        }

        [When(@"I scroll to the “Latest News”")]
        public void WhenIScrollToTheLatestNews()
        {
            PageFactory.InitElements(driver, HomepagePageObjects);

            Actions actions = new Actions(driver);
            actions.MoveToElement(HomepagePageObjects.LatestnewsText);
            actions.Perform();
        }


        [Then(@"I should see it the ""(.*)"" on the page")]
        public void ThenIShouldSeeItTheOnThePage(string p0)
        {
            Assert.IsTrue(HomepagePageObjects.LatestnewsText.Displayed);
            driver.Close();
        }



        [When(@"I click on CASES")]
        public void WhenIClickOnCASES()
        {
            PageFactory.InitElements(driver, HomepagePageObjects);
            driver.SwitchTo().Window("Where Experiences are Engineered - Valtech");

            //driver.SwitchTo().Window(driver.WindowHandles.Last());

            HomepagePageObjects.Cases.SendKeys(Keys.Enter);
            driver.SwitchTo().Window(driver.WindowHandles.Last());

        }

        [Then(@"the CASES page should be displayed")]
        public void ThenTheCASESPageShouldBeDisplayed()
        {

            Assert.IsTrue(HomepagePageObjects.CasesHeader.Displayed);
            driver.Close();
        }

        [When(@"I click on SERVICES")]
        public void WhenIClickOnSERVICES()
        {
            PageFactory.InitElements(driver, HomepagePageObjects);
            HomepagePageObjects.Services.SendKeys(Keys.Enter);
            driver.SwitchTo().Window(driver.WindowHandles.Last());

        }

        [Then(@"the SERVICES page should be displayed")]
        public void ThenTheSERVICESPageShouldBeDisplayed()
        {
            Assert.IsTrue(HomepagePageObjects.ServicesHeader.Displayed);
            driver.Close();
        }

        [When(@"I click on JOBS")]
        public void WhenIClickOnJOBS()
        {
            PageFactory.InitElements(driver, HomepagePageObjects);
            HomepagePageObjects.Jobs.SendKeys(Keys.Enter);
            driver.SwitchTo().Window(driver.WindowHandles.Last());
        }

        [Then(@"the JOBS page should be displayed")]
        public void ThenTheJOBSPageShouldBeDisplayed()
        {
            Assert.IsTrue(HomepagePageObjects.JobsHeader.Displayed);
            driver.Close();
        }

        [When(@"I navigate to the contact page")]
        public void WhenINavigateToTheContactPage()
        {
            PageFactory.InitElements(driver, HomepagePageObjects);
            HomepagePageObjects.ContactUs.SendKeys(Keys.Enter);
            driver.SwitchTo().Window(driver.WindowHandles.Last());

        }

        [Then(@"I can displaythe total number of Valtech offices")]
        public void ThenICanDisplaytheTotalNumberOfValtechOffices()
        {
            ReadOnlyCollection<IWebElement> elements = driver.FindElements(By.CssSelector(".office"));
            System.Diagnostics.Trace.WriteLine("Number of Offices: " + elements.Count);
            driver.Close();

        }

    }
}
