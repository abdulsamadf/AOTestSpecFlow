using OpenQA.Selenium;
using NUnit.Framework;
using System.Collections.Generic;

namespace PageObjects
{
    class HomePage : BasePage
    {
        By HomePageIcon = By.CssSelector("#headerTools > div.aoSiteLogoLink > a > i");
        By SearchInput = By.CssSelector("#searchAOL");
        By SearchButton = By.CssSelector("#lbSearch");
        By TopBrandHotpoint = By.CssSelector("#brands > li:nth-child(2) > a");
        By MoreFilterOptions = By.CssSelector("#moreFilterOptions > div");
        By CustomerRatingListHeading = By.XPath("//*[@id='header' and contains(text(), 'Customer Rating')]");
        By CustomerRatingThreeAndAboveStars = By.XPath("//a[@href='/l/washing_machines-hotpoint-32d0andabove/1-6-41/1/']");
        By SuccessfullSearch = By.XPath("//*[@id='SeoTitle']");
      

        public HomePage(IWebDriver driver) : base(driver)
        {
            Visit("");
            Assert.That(IsDisplayed(HomePageIcon));
        }

        public void With(string searchCriteria)
        {
            Type(SearchInput, searchCriteria);
            Click(SearchButton);
        }

        public void SearchResultsTitle(string resultsCriteria)
        {
            string actualvalue = Find(SuccessfullSearch).Text;
            Assert.IsTrue(actualvalue.Contains(resultsCriteria), actualvalue + " is not as expected");
        }

        public void SelectTopBrandHotpoint()
        {
            Click(TopBrandHotpoint);
        }

        public void ExpandFilterOptionsCustomerRating() 
        {
            Click(MoreFilterOptions);
            Assert.That(IsDisplayed(CustomerRatingListHeading, 10));
            Click(CustomerRatingListHeading);

        }

        public void SelectCustomerStarRatingAs3()
        {
            ExpandFilterOptionsCustomerRating();
            Assert.That(IsDisplayed(CustomerRatingThreeAndAboveStars, 10));
            Click(CustomerRatingThreeAndAboveStars);
            
        }

    }
}
