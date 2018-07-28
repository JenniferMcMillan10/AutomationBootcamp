using System;
using TechTalk.SpecFlow;

namespace AutomationBootcamp...
{
    [Binding]
    public class SpecFlowFeature1Steps
    {
        [Given(@"the user has navigated to wikipedia")]
        public void GivenTheUserHasNavigatedToWikipedia()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"the user enters '(.*)' into the search field")]
        public void WhenTheUserEntersIntoTheSearchField(string p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"clicks search")]
        public void WhenClicksSearch()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"they will have results on '(.*)'")]
        public void ThenTheyWillHaveResultsOn(string p0)
        {
            ScenarioContext.Current.Pending();
        }
    }
}
