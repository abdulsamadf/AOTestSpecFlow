using NUnit.Framework;
using PageObjects;

namespace Tests
{
    [TestFixture]
    class SearchTest : BaseTest
    {
        HomePage Search;

        [SetUp]
        public new void SetUp()
        {
            Search = new HomePage(Driver);
        }

        [Test]
        public void ValidSearch()
        {
            //Search from home page
            Search.With("Washing machines");

            //Search for only Hotpoints
            Search.SelectTopBrandHotpoint();

            //With 3 star or above rating
            Search.SelectCustomerStarRatingAs3();
            
            //Verify Search Completed
            Search.SearchResultsTitle("Hotpoint Washing Machines with a 3-0 & above rating");
          
        }


      
    }
}
