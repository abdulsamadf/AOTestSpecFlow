using System;
using TechTalk.SpecFlow;
using PageObjects;

namespace AOTestFramework.Steps
{
    [Binding]
     class SearchForWashingMachineSteps : Tests.BaseTest
    {
        HomePage Search;
        [BeforeScenario]
        public new void SetUp()
        {
            Search = new HomePage(Driver);
        }

        [AfterScenario()]
        public new void TearDown()
        {
            Driver.Quit();
        }

        [Given(@"I have searched for Washing machines")]
        public void GivenIHaveSearchedForWashingMachines()
        {
            Search.With("Washing machines");
        }
        
        [Given(@"I have selected the Hotpoint Brand")]
        public void GivenIHaveSelectedTheHotpointBrand()
        {
            Search.SelectTopBrandHotpoint();           
        }
        
        [When(@"I filter for 3 or more star customer rated washing machines")]
        public void WhenIFilterForOrMoreStarCustomerRatedWashingMachines()
        {
            Search.SelectCustomerStarRatingAs3();
        }
        
        [Then(@"the result should display Hotpoint Washing Machines with a 3-o & above rating")]
        public void ThenTheResultShouldDisplayHotpointWashingMachinesWithAAboveRating()
        {
            Search.SearchResultsTitle("Hotpoint Washing Machines with a 3-0 & above rating");
        }
    }
}
