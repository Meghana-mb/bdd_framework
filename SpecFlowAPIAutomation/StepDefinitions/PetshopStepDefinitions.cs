using RestSharp;
using System;
using System.Net;
using TechTalk.SpecFlow;

[assembly: CollectionBehavior(DisableTestParallelization = true)]
namespace SpecFlowAPIAutomation.StepDefinitions
{
    [Binding]
    public class PetshopStepDefinitions
    {
        RestClient restClient;
        RestRequest request;
        RestResponse response;

        [Given(@"I have base url '([^']*)' and resource with petid '([^']*)'")]
        public void GivenIHaveBaseUrlAndResourceWithPetid(string baseUrl, string resource)
        {
           restClient = new RestClient(baseUrl + resource);
        }

        [When(@"I do the get request")]
        public void WhenIDoTheGetRequest()
        {
             request = new RestRequest();
            response=restClient.Execute(request);
        }

        [Then(@"I should get the response as (.*)")]
        public void ThenIShouldGetTheResponseAs(int p0)
        {
            //Assert.True(response.StatusCode.Equals(HttpStatusCode.OK));

            int actualStatusCode = (int)response.StatusCode;
            Assert.Equal(p0, actualStatusCode);
        }

        [Then(@"I should get pet details in json format")]
        public void ThenIShouldGetPetDetailsInJsonFormat()
        {
       
        }

        [Then(@"I should get message as '([^']*)'")]
        public void ThenIShouldGetMessageAs(string p0)
        {
            string actualResponse=response.Content;
            Assert.Contains(p0,actualResponse); 
        }

        [Given(@"I need add api_key '([^']*)' in the header")]
        public void GivenINeedAddApi_KeyInTheHeader(string p0)
        {
 
        }

        [When(@"I do the delete request")]
        public void WhenIDoTheDeleteRequest()
        {
            request = new RestRequest("", Method.Delete);
            response = restClient.Execute(request);
        }
    }
}
