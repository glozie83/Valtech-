using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace valtech1
{
    public class ValtechPageObject
    {
        [FindsBy(How = How.XPath, Using = "//*/h2[contains(text(), 'Latest news')]")]
        public IWebElement LatestnewsText;

        [FindsBy(How = How.LinkText, Using = "CASES")]
        public IWebElement Cases;

        [FindsBy(How = How.XPath, Using = "//*[@id=\"container\"]/header/h1[contains(text(), 'Cases')]")]
        public IWebElement CasesHeader;

        [FindsBy(How = How.XPath, Using = "//*[@id=\"navigationMenuWrapper\"]/div/ul/li[2]/a")]
        public IWebElement Services;

        [FindsBy(How = How.XPath, Using = "//*[@id=\"container\"]/section/header/h1[contains(text(), 'Services')]")]
        public IWebElement ServicesHeader;

        [FindsBy(How = How.XPath, Using = "//*[@id=\"navigationMenuWrapper\"]/div/ul/li[4]/a")]
        public IWebElement Jobs;

        [FindsBy(How = How.XPath, Using = "//*[@id=\"container\"]/div[1]/h1[contains(text(), 'Jobs')]")]
        public IWebElement JobsHeader;


        [FindsBy(How = How.XPath, Using = "//*[@id=\"wrapper\"]/header/div/nav/div[2]/div/a")]
        public IWebElement ContactUs;

    }
}
